---@class EventSystems.PointerEventData:EventSystems.BaseEventData
---@field pointerEnter GameObject
---@field lastPress GameObject
---@field rawPointerPress GameObject
---@field pointerDrag GameObject
---@field pointerClick GameObject
---@field pointerCurrentRaycast EventSystems.RaycastResult
---@field pointerPressRaycast EventSystems.RaycastResult
---@field eligibleForClick boolean
---@field pointerId number
---@field position Vector2
---@field delta Vector2
---@field pressPosition Vector2
---@field worldPosition Vector3
---@field worldNormal Vector3
---@field clickTime number
---@field clickCount number
---@field scrollDelta Vector2
---@field useDragThreshold boolean
---@field dragging boolean
---@field button EventSystems.PointerEventData.InputButton
---@field pressure number
---@field tangentialPressure number
---@field altitudeAngle number
---@field azimuthAngle number
---@field twist number
---@field radius Vector2
---@field radiusVariance Vector2
---@field enterEventCamera Camera
---@field pressEventCamera Camera
---@field pointerPress GameObject
---@field currentInputModule EventSystems.BaseInputModule
---@field selectedObject GameObject
---@field used boolean
---@field IsPointerMoving fun(self:EventSystems.PointerEventData):boolean
---@field IsScrolling fun(self:EventSystems.PointerEventData):boolean
---@field ToString fun(self:EventSystems.PointerEventData):string
---@field Reset fun(self:EventSystems.AbstractEventData)
---@field Use fun(self:EventSystems.AbstractEventData)
---@field Equals fun(self:System.Object, obj:System.Object):boolean
---@field GetHashCode fun(self:System.Object):number
---@field GetType fun(self:System.Object):System.Type
EventSystems.PointerEventData = {}
