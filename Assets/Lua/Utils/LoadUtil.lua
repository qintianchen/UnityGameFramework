require("Utils")

---@param name string
---@param parent Component|GameObject
---@param onLoaded fun(go:GameObject)
function LoadGameObject(name, parent, onLoaded)
    ---@param go GameObject
    AssetManager.Instance:LoadAssetAsync(name, AssetType.GameObject, parent, function(go)
        ---@type GameObject
        local newGO = Instantiate(go)
        newGO.name = go.name
        newGO.transform.localPosition = Vector3.zero

        if not IsNull(parent) then
            newGO.transform:SetParent(parent.transform)
        end
        
        local tmp = onLoaded and onLoaded(go)
    end)
end
---@type fun():GameObject
WaitForGameObjectLoaded = Async2Sync(LoadGameObject, 3)