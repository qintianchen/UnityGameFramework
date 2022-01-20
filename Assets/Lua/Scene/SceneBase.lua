---@class SceneBase
SceneBase = NewObjectFrom(LuaObject)

SceneBase.scene_name = nil ---@type string 对应的场景名称
SceneBase.main_ui_name = nil ---@type string 当前场景的主窗口名字，我们假定每个场景可能都有一个主窗口，因为这样我们才有基本的用户交互
SceneBase.is_using_cutscene_animation = nil ---@type boolean 是否使用过场动画

