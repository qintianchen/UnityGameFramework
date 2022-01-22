----------LuaBind Start----------
---@class LuaLoginWindow: UIWindow
---@field btnConfirm GameObject
---@field inputName GameObject
---@field btnChooseServer GameObject
---@field txtServer GameObject
----------LuaBind End----------
LuaLoginWindow = NewObjectFrom(UIWindow)

function LuaLoginWindow:OnOpen()
    self.serverID = self.serverID or 1
    self.accountName = self.accountName or ""
    
    SetButton(self.btnChooseServer, function(a) 
        self:OpenWindow("LoginSelectServerWindow", function(serverID)
            self.serverID = serverID
            self:Refresh()
        end)
    end)

    SetButton(self.btnConfirm, function(a)
        local inputField = GetComponent(self.inputName, E_SYS_TYPE.InputField)
        self.accountName = inputField.text
        Log(("登陆游戏 服务器=%s, 账户名=%s"):format("服务器".. self.serverID, self.accountName))
    end)
    
    self:Refresh()
end 

function LuaLoginWindow:Refresh()
    SetText(self.txtServer, "服务器".. self.serverID)
end 