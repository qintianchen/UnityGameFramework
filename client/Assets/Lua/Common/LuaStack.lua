---@class LuaStack
local stack = {
    elements = {},
    maxSize = 10
}

function stack:Push(e)
    if self:Size() >= self.maxSize then
        return false
    end
    
    table.insert(self.elements, e)
    return true
end

function stack:Pop()
    if #self.elements == 0 then
        return
    end

    local e = self.elements[#self.elements]
    self.elements[#self.elements] = nil

    return e
end

function stack:Peek()
    return self.elements[#self.elements]
end

function stack:Clear()
    self.elements = {}
end

function stack:IsEmpty()
    return #self.elements == 0
end

function stack:Size()
    return #self.elements
end


---@type fun(): LuaStack
LuaStack = setmetatable({}, {__call = function(t, args)
    local s = NewObjectFrom(stack)
    s.elements = {}
    s.maxSize = args or 100000000
    return s
end})