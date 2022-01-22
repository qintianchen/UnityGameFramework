----------LuaBind Start----------
---@class LuaLoginSelectServerWindow: UIWindow
---@field content GameObject
---@field bg GameObject
----------LuaBind End----------
LuaLoginSelectServerWindow = NewObjectFrom(UIWindow)

function LuaLoginSelectServerWindow:OnOpen(onClick)
    SetButton(self.bg, function() self:Close() end)
    
    local children = CloneChildToCount(self.content, 24)
    for i, v in ipairs(children) do
        local txtName =TransformFind(v, "txtName")
        SetText(txtName, "服务器".. i)
        SetButton(txtName, function()
            self:Close()
            onClick(i)
        end)
    end
end 