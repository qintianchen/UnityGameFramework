TransformFind = LuaUtil.TransformFind

function IsNull(obj)
    if obj == nil then
        return true
    end
    
    if type(obj) == "userdata" then
        return tolua.isnull(obj)
    else
        return false
    end
end

--region Get/Add Component
---@generic T
---@param go GameObject|Component
---@param t T
---@return T
function GetOrAddComponent(go, t)
    if IsNull(go) then
        GameLogger.Error("GetOrAddComponent go is null")
        return
    end
    
    return go.gameObject:GetOrAddComponent(typeof(t))
end

---@generic T
---@param go GameObject|Component
---@param t T
---@return T
function GetComponent(go, t)
    if IsNull(go) or IsNull(t) then
        GameLogger.Error(("GetComponent Error: go or type can not be null. go = %s, t = %s"):format(go, t))
        return
    end

    return go.gameObject:GetComponent(typeof(t))
end

---@generic T
---@param go GameObject|Component
---@param t T
---@return T
function GetComponentInParent(go, t)
    if IsNull(go) or IsNull(t) then
        GameLogger.Error(("GetComponent Error: go or type can not be null. go = %s, t = %s"):format(go, t))
        return
    end

    return go.gameObject:GetComponentInParent(typeof(t))
end
--endregion

--region corotine
function StartCoroutine(func)
    local co = coroutine.create(func)
    local status, error = coroutine.resume(co)
    if not status then
        GameLogger.Error(error)
    end
end

--- 异步转同步的接口，需要在协程的上下文里面执行
--- 注意有一些方法的参数可能为nil，为了使得异步转同步不出问题，我们必须把可为nil的参数都放在callback的后面
---@param func fun() 异步带回调的接口
---@param callbackPos number 用来指示回调是在 func 的第几个参数，默认为最后一个
function Async2Sync(func, callbackPos)
    return function(...)
        local _co = coroutine.running() or LogError("this function should run in coroutine")
        local rets
        local waiting = false
        local function cb (...)
            if waiting then
                assert(coroutine.resume(_co, ...))
            else
                rets = {...}
            end
        end

        local params = {...}

        table.insert(params, callbackPos or (#params + 1), cb)

        func(unpack(params))

        if rets == nil then
            waiting = true
            rets = {coroutine.yield()}
        end

        return unpack(rets)
    end
end

WaitForSeconds = Async2Sync(function(sec, action)
    UnityTimer.New(sec, action):Start()
end)
--endregion

--region Lua
function GetLuaObject(go)
    if IsNull(go) then
        return nil
    end
    
    local behaviour = GetComponent(go, E_SYS_TYPE.LuaBehaviour)
    if IsNull(behaviour) then
        return nil
    end
    
    return behaviour:GetLuaObject()
end
--endregion

--region UI
---@param go Component|GameObject
---@param onClick fun(data: EventSystems.PointerEventData)
function SetButton(go, onClick)
    LuaUtil.SetButton(go.gameObject, onClick)
end

---@param go Component|GameObject
---@param content string
function SetText(go, content)
    LuaUtil.SetText(go, content)
end
--endregion

--region GameObject/Component Helper
function SetActive(go, isActive)
    LuaUtil.SetActive(go, isActive)
end

function CloneGameObject(go, parent, isStayPosition)
    if IsNull(go) then
        LogError("clone gameObject cannot be null")
        return
    end

    if IsNull(parent) then
        LogError("clone gameObject parent cannot be null #" .. go.name)
        return
    end

    local newObj = GameObject.Instantiate(go, parent);
    if not isStayPosition then
        newObj.transform.localPosition = Vector3.zero
    end
    
    newObj.name = go.name
    SetActive(newObj, true)
    return newObj
end

--- 拷贝父物体 parent 下的子物体到count数量，多余的节点会隐藏
---@param parent GameObject|Component
---@param count number
---@return Transform[] 返回拷贝之后，节点下活跃的物体
function CloneChildToCount(parent, count)
    local trans = parent.transform
    if trans.childCount == 0 and count == 0 then
        return {}
    end

    local firstChild = trans:GetChild(0)
    if trans.childCount < count then
        for i = trans.childCount + 1, count do
            CloneGameObject(firstChild.gameObject, trans)
        end
    end

    if trans.childCount > count then
        local children = {}
        for i = count + 1, trans.childCount do
            local child = trans:GetChild(i-1)
            table.insert(children, child)
        end

        for i = 1, #children do
            SetActive(children[i], false)
        end
    end

    for i = 1, count do
        local child = trans:GetChild(i - 1)
        local luaObj = GetLuaObject(child)
        if not IsNull(luaObj) and luaObj.Register then
            luaObj:Register()
        end

        SetActive(trans:GetChild(i-1), true)
    end

    return GetActiveChildren(parent)
end

---@return Transform[]
function GetActiveChildren(parent)
    local trans = parent.transform
    local children = {}
    for i = 1, trans.childCount do
        local child = trans:GetChild(i-1)
        if child.gameObject.activeSelf then
            table.insert(children, child)
        end
    end

    return children
end
--endregion