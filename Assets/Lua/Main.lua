inspect = require("inspect")

-- 基础数据结构和算法部分
require("LuaObject")
require("DefCommon")

-- 基础框架部分
require("Utils")
require("LoadUtil")

-- 基础业务框架部分
require("UIManager")

-- 全局
GameObject = UnityEngine.GameObject
Instantiate = UnityEngine.Object.Instantiate

UIManager.Init()
