E_SYS_TYPE = {
    ---@type GameObject
    GameObject = UnityEngine.GameObject,
    ---@type Transform
    Transform = UnityEngine.Transform,
    ---@type DontDestroyOnLoad
    DontDestroyOnLoad = DontDestroyOnLoad,
    ---@type Canvas
    Canvas = UnityEngine.Canvas,
    ---@type LuaBehaviour
    LuaBehaviour = LuaBehaviour,
    ---@type GraphicRaycaster
    GraphicRaycaster = UnityEngine.UI.GraphicRaycaster
}

E_WINDOW_TYPE ={
    Main = 1,   -- 处理一些常规弹窗，所有后开遮住先开的窗口都属于该类型
    Upper = 2,  -- 不受窗口打开顺序影响的窗口属于这一层，比如跑马灯之类的
    System = 3, -- 系统级弹窗，所有UI的最顶层
}