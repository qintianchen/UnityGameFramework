----------LuaBind Start----------
---@class LuaLoginWindow: UIWindow
---@field btnConfirm GameObject
---@field inputName GameObject
---@field btnChooseServer GameObject
---@field txtServer GameObject
----------LuaBind End----------
LuaLoginWindow = NewObjectFrom(UIWindow)

function LuaLoginWindow:OnOpen()
    SetButton(self.btnConfirm, function()  end)
end 