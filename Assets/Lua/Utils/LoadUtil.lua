require("Utils")

---@param name string
---@param onLoaded fun(go:GameObject)
---@param parent Component|GameObject
function LoadGameObject(name, onLoaded, parent)
    ---@param go GameObject
    AssetManager.Instance:LoadAssetAsync(name, AssetType.GameObject, parent, function(go)
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
---@type fun():GameObject
WaitForGameObjectLoaded = Async2Sync(LoadGameObject, 2)