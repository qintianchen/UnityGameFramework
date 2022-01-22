---@class LuaQueue
local queue = {}

queue.elements = {}
queue.maxSize = 10
queue.rear = 0 -- 指向当前队尾后面的空元素
queue.front = 0 -- 指向当前队头的元素，当front == rear 的时候，表示队列为空

function queue:Enqueue(e)
    if not e or self:IsFull() then
        return false
    end

    self.elements[self.rear] = e
    self.rear = self.rear % (self.maxSize + 1) + 1
    
    return true
end

function queue:Dequeue()
    if self:IsEmpty() then
        return
    end

    local e = self.elements[self.front]
    self.elements[self.front] = nil
    self.front = self.front % (self.maxSize + 1) + 1

    return e
end

function queue:Peek()
    if self:IsEmpty() then
        return
    end
    
    return self.elements[self.front]
end

function queue:IsEmpty()
    return self.rear == self.front
end

function queue:IsFull()
    return self.rear % (self.maxSize + 1) + 1 == self.front
end

---@type fun(): LuaQueue
LuaQueue = setmetatable({}, {__call = function(t, args)
    local q = NewObjectFrom(queue)
    q.elements = {}
    q.maxSize = args or 100000000
    q.rear = q.maxSize
    q.front = q.maxSize
    return q
end})