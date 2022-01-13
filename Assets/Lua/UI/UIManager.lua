require("UIWindow")
require("UIBase")

UIManager = {}
local mgr = {}
mgr.isInit = false

local uiroot_prefab_name = "UIRoot" 

---@generic T
---@param wndClass fun():T
---@param parentObj UIBase
function UIManager.OpenWindow(wndClass, parentObj)
    
end

function UIManager.Init()
   StartCoroutine(mgr.CoInit)
end

function mgr.CoInit()
    local go = WaitForGameObjectLoaded(uiroot_prefab_name)

    GameLogger.Info("执行逻辑")
    GetOrAddComponent(go, E_SYS_TYPE.DontDestroyOnLoad)
    UIManager.uiRoot = go
    
    UIManager.FullScreenEffectCanvas = GetComponent(go.transform:Find("FullScreenEffectCanvas"), E_SYS_TYPE.Canvas)
    UIManager.SystemUICanvas = GetComponent(go.transform:Find("SystemUICanvas"), E_SYS_TYPE.Canvas)
    UIManager.GuideUICanvas = GetComponent(go.transform:Find("GuideUICanvas"), E_SYS_TYPE.Canvas)
    UIManager.UpperUICanvas = GetComponent(go.transform:Find("UpperUICanvas"), E_SYS_TYPE.Canvas)
    UIManager.MainUICanvas = GetComponent(go.transform:Find("MainUICanvas"), E_SYS_TYPE.Canvas)
    UIManager.HUDCanvas = GetComponent(go.transform:Find("HUDCanvas"), E_SYS_TYPE.Canvas)
    
    assert(UIManager.FullScreenEffectCanvas)
    assert(UIManager.SystemUICanvas)
    assert(UIManager.GuideUICanvas)
    assert(UIManager.UpperUICanvas)
    assert(UIManager.MainUICanvas)
    assert(UIManager.HUDCanvas)
    
    mgr.isInit = true
end 