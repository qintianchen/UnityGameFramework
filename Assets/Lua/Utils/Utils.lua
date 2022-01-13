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
    if IsNull(go) then
        return
    end

    return go.gameObject:GetComponent(typeof(t))
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

--- 异步转同步
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
--endregion