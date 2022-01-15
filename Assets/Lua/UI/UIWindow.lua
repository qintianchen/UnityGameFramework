---@class UIWindow: UIBase
UIWindow = NewObjectFrom(UIBase)

function UIWindow:OnFocus()
     
end

function UIWindow:OnLostFocus()

end

function UIWindow:OpenWindow(wndName, ...)
    UIManager.OpenWindow(wndName, self, ...)
end

function UIWindow:Close()
    UIManager.CloseWindow(self)
end 