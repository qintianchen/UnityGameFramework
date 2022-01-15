require("UIWindow")
require("UIBase")

UIManager = {}
local mgr = {}
mgr.isInit = false

local uiroot_prefab_name = "UIRoot" 

---@param wndName string
---@param parentObj UIBase
function UIManager.OpenWindow(wndName, parentObj)
    --local prefabName = wndClass.prefabName
    
    LoadGameObject(wndName, function(go)
        local luaObj = GetComponent(go.transform, E_SYS_TYPE.LuaBehaviour):GetLuaObject()
        luaObj:OnOpen()
    end, UIManager.MainUICanvas.gameObject)

    --LoadGameObject(wndName, UIManager.MainUICanvas.gameObject, function(go)
    --    local luaObj = GetComponent(go.transform, E_SYS_TYPE.LuaBehaviour):GetLuaObject()
    --    luaObj:OnOpen()
    --end)
end

function UIManager.Init()
   StartCoroutine(mgr.CoInit)
end

function mgr.CoInit()
    GameLogger.Info("mgr.CoInit")

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
    
    --LoadGameObject(uiroot_prefab_name, nil, function(go)
    --    GameLogger.Info("执行逻辑")
    --    GetOrAddComponent(go, E_SYS_TYPE.DontDestroyOnLoad)
    --    UIManager.uiRoot = go
    --
    --    UIManager.FullScreenEffectCanvas = GetComponent(go.transform:Find("FullScreenEffectCanvas"), E_SYS_TYPE.Canvas)
    --    UIManager.SystemUICanvas = GetComponent(go.transform:Find("SystemUICanvas"), E_SYS_TYPE.Canvas)
    --    UIManager.GuideUICanvas = GetComponent(go.transform:Find("GuideUICanvas"), E_SYS_TYPE.Canvas)
    --    UIManager.UpperUICanvas = GetComponent(go.transform:Find("UpperUICanvas"), E_SYS_TYPE.Canvas)
    --    UIManager.MainUICanvas = GetComponent(go.transform:Find("MainUICanvas"), E_SYS_TYPE.Canvas)
    --    UIManager.HUDCanvas = GetComponent(go.transform:Find("HUDCanvas"), E_SYS_TYPE.Canvas)
    --
    --    assert(UIManager.FullScreenEffectCanvas)
    --    assert(UIManager.SystemUICanvas)
    --    assert(UIManager.GuideUICanvas)
    --    assert(UIManager.UpperUICanvas)
    --    assert(UIManager.MainUICanvas)
    --    assert(UIManager.HUDCanvas)
    --
    --    mgr.isInit = true
    --end)
    
    
end 