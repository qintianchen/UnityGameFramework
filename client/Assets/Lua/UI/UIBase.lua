---@class UIBase
UIBase = NewObjectFrom(LuaObject)

---@param duration number
---@param onComplete fun()
---@param onUpdate fun()
---@param isLooped boolean
---@param useTimeScale boolean
---@return UnityTimer
function UIBase:StartTimer(duration, onComplete, onUpdate, isLooped, useTimeScale)
    local timer = UnityTimer.New(
            duration, 
            onComplete or function()  end,
            onUpdate,
            isLooped == true,
            useTimeScale == true,
            self.transform
    )
    
    timer:Start()
    return timer
end

function UIBase:OnDestroy()
    
end