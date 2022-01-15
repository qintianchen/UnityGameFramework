require("UIWindow")
require("UIBase")

--[[
N: 可以使用 UIManager.OpenWindow 来打开窗口
Y: 建议使用 UIWindow 的 OpenWindow 来打开窗口，窗口的生命周期会跟着打开它的窗口走，建议只有在打开第一个窗口的时候才使用  UIManager.OpenWindow
N: 不建议使用 UIManager.CloseWindow 来关闭窗口
Y: 建议使用 UIWindow 的 Close 来关闭自己，同时如果当前窗口并不是处于窗口堆栈的最上层，会先把堆栈上层的窗口都清空
]]--

UIManager = {}
local mgr = {}
mgr.isInit = false -- 是否初始化
mgr.loading_queue = LuaQueue(100) -- queue of element like {state = LOAD_STATE.loading, parentLuaObject = parentLuaObject, args = {...}}
mgr.window_stack = LuaStack(100) -- stack of element like { luaObj = wndLuaObj }

local LOAD_STATE = {
    loading = 2,    -- 加载中
    loaded = 3,     -- 加载完成
    dead = 4,       -- 已无效
}

local UIROOT_NAME = "UIRoot"

---@param wndName string
---@param parentLuaObject UIBase
function UIManager.OpenWindow(wndName, parentLuaObject, ...)
    if parentLuaObject then
        if IsNull(parentLuaObject.gameObject) then
            LogError("打开窗口失败，上下文已丢失：".. wndName)
            return
        end

        local peekWnd = mgr.window_stack:Peek()
        if peekWnd and peekWnd.luaObj ~= parentLuaObject then
            LogError("栈顶窗口上下文丢失：".. wndName)
            return
        end
    end
    
    local load_request = {state = LOAD_STATE.loading, parentLuaObject = parentLuaObject, args = {...}}
    LoadGameObject(wndName, UIManager.MainUICanvas.gameObject, function(go)
        -- 如果回调的 go 是空，说明已超时
        if IsNull(go) then
            load_request.state = LOAD_STATE.dead
            return
        end
        
        -- 如果上下文已丢失，就销毁窗口
        if parentLuaObject and IsNull(parentLuaObject.gameObject) then
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
end

function UIManager.CloseWindow(wndLuaObj)
    if not wndLuaObj or IsNull(wndLuaObj.gameObject) then
        return
    end

    if mgr.window_stack:IsEmpty() then
        LogError("尝试关闭窗口，但是窗口堆栈为空：", wndLuaObj.gameObject.name)
        GameObject.Destroy(wndLuaObj.gameObject)
        return
    end
    
    local peekWnd = mgr.window_stack:Peek()
    
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
            mgr.window_stack:Pop()
            if mgr.window_stack:IsEmpty() then
                return
            end
            peekWnd = mgr.window_stack:Peek()
        else
            GameObject.Destroy(wndLuaObj.gameObject)
            mgr.window_stack:Pop()
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

-- todo: 调查一下为什么 UpdateBeat 用不了
function UIManagerUpdate()
    mgr.Update()
end

function mgr.RegisterWindow(wndLuaObj)
    local parentCanvas = GetComponentInParent(wndLuaObj.gameObject, E_SYS_TYPE.Canvas)
    
    local canvas = GetOrAddComponent(wndLuaObj.gameObject, E_SYS_TYPE.Canvas)
    GetOrAddComponent(wndLuaObj.gameObject, E_SYS_TYPE.GraphicRaycaster)
    
    canvas.overrideSorting = true
    canvas.sortingLayerName = parentCanvas.sortingLayerName
    canvas.sortingOrder = parentCanvas.sortingOrder + 5 + mgr.window_stack:Size() * 50
    
    local ret = mgr.window_stack:Push({
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

        if request.state == LOAD_STATE.dead then
            mgr.loading_queue:Dequeue()
            if not IsNull(request.gameObject) then
                GameObject.Destroy(request.gameObject)
            end
        elseif request.state == LOAD_STATE.loading then
            return
        else
            -- loaded 状态
            mgr.loading_queue:Dequeue()
            local go = request.gameObject
            if request.parentLuaObject and IsNull(request.parentLuaObject.gameObject) then
                -- 上下文已丢失
                GameObject.Destroy(go)
            else
                go:SetActive(true)
                local luaObj = GetLuaObject(go)
                local ret = mgr.RegisterWindow(luaObj)
                if not ret then
                    LogError("窗口入栈失败: ".. go.name)
                    GameObject.Destroy(request.gameObject)
                elseif luaObj.OnOpen then
                    luaObj:OnOpen(unpack(request.args))
                end
            end
        end
    end
end