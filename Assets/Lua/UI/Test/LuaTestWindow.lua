----------LuaBind Start----------
---@class LuaTestWindow
---@field Scrollbar_Vertical GameObject
---@field Button GameObject
---@field Viewport GameObject
---@field Scrollbar_Horizontal GameObject
---@field Handle GameObject
---@field Sliding_Area GameObject
---@field Text GameObject
---@field Scroll_View GameObject
----------LuaBind End----------
LuaTestWindow = NewObjectFrom(UIBase)

function LuaTestWindow:OnOpen()
    GameLogger.Info("我被打开了".. inspect(self))
end 
