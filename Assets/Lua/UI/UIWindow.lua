---@class UIWindow: UIBase
UIWindow = NewObjectFrom(UIBase)

UIWindow.sysType = E_WINDOW_TYPE.Main

function UIWindow:OnFocus()
     
end

function UIWindow:OnLostFocus()

end

function UIWindow:OpenWindow(wndName, ...)
    if self.sysType ~= E_WINDOW_TYPE.Main then
        LogError("仅支持从MainUICanvas下的窗口打开新的窗口")
        return
    end
    
    UIManager.OpenWindow(wndName, self, ...)
end

function UIWindow:Close()
    UIManager.CloseWindow(self)
end 