----------LuaBind Start----------
---@class LuaLoginSelectServerWindow: UIWindow
---@field content GameObject
---@field bg GameObject
----------LuaBind End----------
LuaLoginSelectServerWindow = NewObjectFrom(UIWindow)

function LuaLoginSelectServerWindow:OnOpen(onClick)
    SetButton(self.bg, function() self:Close() end)
    
    local child0 = self.content.transform:GetChild(0)
    for i = 1, 24 do
        local child = Instantiate(child0.gameObject)
        child.transform:SetParent(self.content)
        child.transform.localScale = Vector3.one
        child.name = child0.name.. i
        
        local txtName =TransformFind(child, "txtName") 
        SetText(txtName, "服务器".. i)
        SetButton(txtName, function() 
            self:Close()
            onClick(i)
        end)
    end
end 