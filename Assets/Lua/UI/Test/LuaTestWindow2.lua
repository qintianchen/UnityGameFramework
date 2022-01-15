----------LuaBind Start----------
---@class LuaTestWindow2: UIWindow
---@field Button GameObject
---@field Text GameObject
----------LuaBind End----------
LuaTestWindow2 = NewObjectFrom(UIWindow)

function LuaTestWindow2:OnOpen(s, t)
    LogYellow(("2 打开了 s = %s, t = %s"):format(inspect(s), inspect(t, {newline = " "})))
end 