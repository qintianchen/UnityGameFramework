----------LuaBind Start----------
---@class LuaTestWindow1
---@field Button GameObject
---@field Text GameObject
----------LuaBind End----------
LuaTestWindow1 = NewObjectFrom(UIWindow)

function LuaTestWindow1:OnOpen(a, b)
    LogYellow(("1 打开了 a = %s, b = %s"):format(a, b))
    
    --self:Close()
    
    self:OpenWindow("TestWindow2", "斯巴达", {a = 11, b = 232323})
end 