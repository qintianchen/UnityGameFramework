require("UIBase")
require("UIWindow")

--[[
三种窗口请查看 E_WINDOW_TYPE 的注释

N: 可以使用 UIManager.OpenWindow 来打开窗口
Y: 建议使用 UIWindow 的 OpenWindow 来打开窗口，窗口的生命周期会跟着打开它的窗口走，建议只有在打开第一个窗口的时候才使用  UIManager.OpenWindow
N: 不建议使用 UIManager.CloseWindow 来关闭窗口
Y: 建议使用 UIWindow 的 Close 来关闭自己，同时如果当前窗口并不是处于窗口堆栈的最上层，会先把堆栈上层的窗口都清空

窗口在经过正确打开（加载预置体，注册自己，OnOpen初始化被调用）之后，会抛出事件窗口成功打开的事件
]]--

UIManager = {}
local mgr = {}
mgr.isInit = false -- 是否初始化
mgr.loading_queue = LuaQueue(100) -- queue of element like {state = LOAD_STATE.loading, parentLuaObj = parentLuaObj, args = {...}}
mgr.main_ui_stack = LuaStack(100) -- stack of element like { luaObj = wndLuaObj }
mgr.upper_ui_stack = LuaStack(100) -- stack of element like { luaObj = wndLuaObj }
mgr.system_ui_stack = LuaStack(1) -- we assume that there can be only one system type window on the scene

local LOAD_STATE = {
    loading = 2, -- 加载中
    loaded = 3, -- 加载完成
    dead = 4, -- 已无效
}

local UIROOT_NAME = "UIRoot"

---@param wndName string
---@param parentLuaObj UIWindow
function UIManager.OpenWindow(wndName, parentLuaObj, ...)
    if parentLuaObj then
        if IsNull(parentLuaObj.gameObject) then
            LogError("打开窗口失败，上下文已丢失：" .. wndName)
            return
        end

        if parentLuaObj.sysType ~= E_WINDOW_TYPE.Main then
            LogError("不支持将生命周期绑定到其他Canvas下的窗口上")
        else
            local peekWnd = mgr.main_ui_stack:Peek()
            if peekWnd and peekWnd.luaObj ~= parentLuaObj then
                LogError("栈顶窗口上下文丢失：" .. wndName)
                return
            end
        end
    end

    local load_request = { state = LOAD_STATE.loading, parentLuaObj = parentLuaObj, wndName = wndName, args = { ... } }
    LoadGameObject(wndName, UIManager.MainUICanvas.gameObject, function(go)
        -- 如果回调的 go 是空，说明已超时
        if IsNull(go) then
            load_request.state = LOAD_STATE.dead
            return
        end

        -- 生命周期已经过期，比如切换了场景之类的
        if load_request.state == LOAD_STATE.dead then
            GameObject.Destroy(go)
            return
        end

        -- 如果上下文已丢失，就销毁窗口
        if parentLuaObj and IsNull(parentLuaObj.gameObject) then
            load_request.state = LOAD_STATE.dead
            GameObject.Destroy(go)
            return
        end

        -- 等待窗口被打开
        load_request.state = LOAD_STATE.loaded
        load_request.gameObject = go
        go:SetActive(false)
    end, 2)

    mgr.loading_queue:Enqueue(load_request)
    mgr.Update()
end

---@param wndLuaObj UIWindow
function UIManager.CloseWindow(wndLuaObj)
    if not wndLuaObj or IsNull(wndLuaObj.gameObject) then
        return
    end

    if wndLuaObj.sysType == E_WINDOW_TYPE.Main and mgr.main_ui_stack:IsEmpty()
            or wndLuaObj.sysType == E_WINDOW_TYPE.Upper and mgr.upper_ui_stack:IsEmpty()
    then
        LogError("尝试关闭窗口，但是窗口堆栈为空：", wndLuaObj.gameObject.name)
        GameObject.Destroy(wndLuaObj.gameObject)
        return
    end

    local stack
    if wndLuaObj.sysType == E_WINDOW_TYPE.Main then
        stack = mgr.main_ui_stack
    elseif wndLuaObj.sysType == E_WINDOW_TYPE.Upper then
        stack = mgr.upper_ui_stack
    else
        stack = mgr.system_ui_stack
    end
    local peekWnd = stack:Peek()

    local count = 0
    while true do
        count = count + 1
        if count > 100 then
            LogError("死循环！！")
            return
        end
        -- 当一个窗口尝试关闭自己，会把自己上层的所有窗口都给关掉
        -- 有些游戏可能采取另一种做法，即不允许这种事情的发生
        if peekWnd.luaObj ~= wndLuaObj then
            peekWnd.luaObj:Close()
            stack:Pop()
            if stack:IsEmpty() then
                return
            end
            peekWnd = stack:Peek()
        else
            GameObject.Destroy(wndLuaObj.gameObject)
            stack:Pop()
            return
        end
    end
end

function UIManager.CoInit()
    LogYellow("mgr.CoInit")

    local go = WaitForGameObjectLoadedNoParent(UIROOT_NAME)

    GetOrAddComponent(go, E_SYS_TYPE.DontDestroyOnLoad)
    UIManager.uiRoot = go

    UIManager.FullScreenEffectCanvas = GetComponent(TransformFind(go, "FullScreenEffectCanvas"), E_SYS_TYPE.Canvas)
    UIManager.SystemUICanvas = GetComponent(TransformFind(go, "SystemUICanvas"), E_SYS_TYPE.Canvas)
    UIManager.GuideUICanvas = GetComponent(TransformFind(go, "GuideUICanvas"), E_SYS_TYPE.Canvas)
    UIManager.UpperUICanvas = GetComponent(TransformFind(go, "UpperUICanvas"), E_SYS_TYPE.Canvas)
    UIManager.MainUICanvas = GetComponent(TransformFind(go, "MainUICanvas"), E_SYS_TYPE.Canvas)
    UIManager.HUDCanvas = GetComponent(TransformFind(go, "HUDCanvas"), E_SYS_TYPE.Canvas)

    assert(UIManager.FullScreenEffectCanvas)
    assert(UIManager.SystemUICanvas)
    assert(UIManager.GuideUICanvas)
    assert(UIManager.UpperUICanvas)
    assert(UIManager.MainUICanvas)
    assert(UIManager.HUDCanvas)

    local rootWindowGo = TransformFind(UIManager.MainUICanvas, "RootWindow")
    UIManager.rootWindowObj = GetLuaObject(rootWindowGo)

    UpdateBeat:Add(mgr.Update)

    mgr.isInit = true
end

function UIManager.Clear()
    while true do
        local peek = mgr.main_ui_stack:Pop()
        if not peek then
            break
        end

        peek.luaObj:Close()
    end

    while true do
        local peek = mgr.upper_ui_stack:Pop()
        if not peek then
            break
        end

        peek.luaObj:Close()
    end

    while true do
        local peek = mgr.system_ui_stack:Pop()
        if not peek then
            break
        end

        peek.luaObj:Close()
    end

    while true do
        local peek = mgr.loading_queue:Dequeue()
        if not peek then
            break
        end

        peek.state = LOAD_STATE.dead
    end
end

--- 注册窗口，处理层级问题，并入窗口堆栈
---@param wndLuaObj UIWindow
function mgr.RegisterWindow(wndLuaObj)
    -- System 和 Upper 的层级总是很特殊，因为当他们出现的时候总是希望自己在最上层
    -- 所以我们假设首先 System 和 Upper 类型的窗口不会太多，其次他们需要自己处理层级关系
    if wndLuaObj.sysType == E_WINDOW_TYPE.Upper then
        local ret = mgr.upper_ui_stack:Push({
            luaObj = wndLuaObj,
        })
        return ret
    end

    if wndLuaObj.sysType == E_WINDOW_TYPE.System then
        local ret = mgr.system_ui_stack:Push({
            luaObj = wndLuaObj,
        })
        return ret
    end

    local parentCanvas = GetComponentInParent(wndLuaObj.gameObject, E_SYS_TYPE.Canvas)

    local canvas = GetOrAddComponent(wndLuaObj.gameObject, E_SYS_TYPE.Canvas)
    GetOrAddComponent(wndLuaObj.gameObject, E_SYS_TYPE.GraphicRaycaster)

    canvas.overrideSorting = true
    canvas.sortingLayerName = parentCanvas.sortingLayerName
    canvas.sortingOrder = parentCanvas.sortingOrder + 5 + mgr.main_ui_stack:Size() * 50

    local ret = mgr.main_ui_stack:Push({
        luaObj = wndLuaObj,
    })
    return ret
end

function mgr.Update()
    -- 每次只检查队列头部的加载状态
    while true do
        local request = mgr.loading_queue:Peek()
        if not request then
            return
        end

        if request.state == LOAD_STATE.loading then
            return
        end

        if request.state == LOAD_STATE.dead then
            mgr.loading_queue:Dequeue()
            if not IsNull(request.gameObject) then
                GameObject.Destroy(request.gameObject)
            end
            return
        end


        -- loaded 状态
        mgr.loading_queue:Dequeue()
        local go = request.gameObject
        if request.parentLuaObj and IsNull(request.parentLuaObj.gameObject) then
            -- 上下文已丢失
            GameObject.Destroy(go)
            return
        end

        local luaObj = GetLuaObject(go)
        if luaObj.sysType == E_WINDOW_TYPE.Upper then
            go.transform:SetParent(UIManager.UpperUICanvas.transform)
        elseif luaObj.sysType == E_WINDOW_TYPE.System then
            go.transform:SetParent(UIManager.SystemUICanvas.transform)
        end

        go:SetActive(true)
        go.transform.localScale = Vector3.one
        local ret = mgr.RegisterWindow(luaObj)
        if not ret then
            LogError("窗口入栈失败: " .. go.name)
            GameObject.Destroy(request.gameObject)
        elseif luaObj.OnOpen then
            luaObj:OnOpen(unpack(request.args))
            LuaEvent.Publish(LuaEventID.EvtOpenWindow, request.wndName)
        end
    end
end