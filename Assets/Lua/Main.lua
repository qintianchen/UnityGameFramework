inspect = require("inspect")

-- 基础设施，数据结构和算法部分
require("Log")
require("LuaObject")
require("LuaStack")
require("LuaQueue")
require("DefCommon")

-- 基础框架部分
require("Utils")
require("LoadUtil")

-- 基础业务框架部分
require("UIManager")

-- 全局
GameObject = UnityEngine.GameObject
Instantiate = UnityEngine.Object.Instantiate
TransformFind = LuaUtil.TransformFind

StartCoroutine(function()
    UIManager.CoInit()

    UIManager.OpenWindow("LoginWindow", nil, 1111, 332)
end)


