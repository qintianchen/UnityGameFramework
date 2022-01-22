LuaEvent = {}

local luaEventID_callbackList = {} ---@type table<LuaEventID, fun[]>

function LuaEvent.AddListener(luaEventID, callback)
    if string.IsNullOrEmpty(luaEventID) then
        return
    end

    luaEventID_callbackList[luaEventID] = luaEventID_callbackList[luaEventID] or {}
    table.insert(luaEventID_callbackList[luaEventID], callback)
end 

function LuaEvent.Publish(luaEventID, arg)
    if string.IsNullOrEmpty(luaEventID) or not luaEventID_callbackList[luaEventID] then
        return
    end
    
    local callbackList = DeepCopy(luaEventID_callbackList[luaEventID])
    for i, v in ipairs(callbackList) do
        PCALL(v, arg)
    end
end

function LuaEvent.RemoveListener(luaEventID, callback)
    if string.IsNullOrEmpty(luaEventID) or not callback then
        return
    end

    if not luaEventID_callbackList[luaEventID] then
        return
    end
    
    local removedIndex = -1
    for i, v in ipairs(luaEventID_callbackList[luaEventID]) do
        if v == callback then
            removedIndex = i
        end
    end

    if removedIndex ~= -1 then
        table.remove(luaEventID_callbackList[luaEventID], callback)
    end
end 

function LuaEvent.RemoveAllListenerByID(luaEventID)
    if string.IsNullOrEmpty(luaEventID) or not luaEventID_callbackList[luaEventID] then
        return
    end

    luaEventID_callbackList[luaEventID] = {}
end 

function LuaEvent.Reset()
    luaEventID_callbackList = {}
end 