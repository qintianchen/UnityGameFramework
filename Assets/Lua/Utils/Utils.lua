﻿function IsNull(obj)
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

function WaitToDo(secs, action)
    local c = coroutine.create( function()
        Yield(WaitForSeconds(secs))
        xpcall(action, GameLogger.Error)
        --PCALL(action)
    end )
    coroutine.resume(c)
    return c
end
--endregion