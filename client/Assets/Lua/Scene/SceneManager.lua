--[[
在这个场景管理器中，我们使用 Type/Class 来表征一个场景对象
Type和实际的场景是多对多的关系，不同的Type即使加载同一个场景，可能也做不同的事情，比如说全局的渲染设置，相机的参数等等
这些不同导致同一个场景（Scene）在上层业务看来是不同的场景（Type）
]]--

SceneManager = {}

local sceneType_sceneClass = {
    E_SCENE_TYPE.Login
}

function SceneManager.LoadSceneByType(sceneType, onLoaded)
        
end 