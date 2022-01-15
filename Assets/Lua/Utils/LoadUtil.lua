require("Utils")

---@param name string
---@param onLoaded fun(go:GameObject)
---@param parent Component|GameObject
---@param timeout number 当底层出现异常时，不会处理回调，但是上层业务有时候必须要求回调返回，故增加超时机制
function LoadGameObject(name, parent, onLoaded, timeout)
    --Log(("LoadGameObject(%s, %s, %s)"):format(name, parent, onLoaded))
    local isTimeout = false
    local timer
    if timeout and timeout > 0 then
        timer = UnityTimer.New(timeout, function()
            isTimeout = true
            onLoaded(nil)
        end)
        
        timer:Start()
    end
    
    ---@param go GameObject
    AssetManager.Instance:LoadAssetAsync(name, AssetType.GameObject, parent, function(go)
        if isTimeout then
            GameObject.Destroy(go)
            return
        end

        if timer then
            timer:Cancel()
        end

        ---@type GameObject
        local newGO = Instantiate(go)
        newGO.name = go.name

        if not IsNull(parent) then
            newGO.transform:SetParent(parent.transform)
        end

        newGO.transform.localPosition = Vector3.zero
        newGO.transform.localScale = Vector3.one

        onLoaded(newGO)
    end)
end
WaitForGameObjectLoaded = Async2Sync(LoadGameObject, 3)
WaitForGameObjectLoadedNoParent = Async2Sync(function(name, onLoaded, timeout) 
    LoadGameObject(name, nil, onLoaded, timeout)  
end, 2)