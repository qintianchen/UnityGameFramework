---@class RectTransformUtility:System.Object
---@field PixelAdjustPoint fun(point:Vector2, elementTransform:Transform, canvas:Canvas):Vector2
---@field PixelAdjustRect fun(rectTransform:RectTransform, canvas:Canvas):Rect
---@field RectangleContainsScreenPoint fun(rect:RectTransform, screenPoint:Vector2):boolean
---@field RectangleContainsScreenPoint fun(rect:RectTransform, screenPoint:Vector2, cam:Camera):boolean
---@field RectangleContainsScreenPoint fun(rect:RectTransform, screenPoint:Vector2, cam:Camera, offset:Vector4):boolean
---@field ScreenPointToWorldPointInRectangle fun(rect:RectTransform, screenPoint:Vector2, cam:Camera, worldPoint:Vector3&):boolean
---@field ScreenPointToLocalPointInRectangle fun(rect:RectTransform, screenPoint:Vector2, cam:Camera, localPoint:Vector2&):boolean
---@field ScreenPointToRay fun(cam:Camera, screenPos:Vector2):Ray
---@field WorldToScreenPoint fun(cam:Camera, worldPoint:Vector3):Vector2
---@field CalculateRelativeRectTransformBounds fun(root:Transform, child:Transform):Bounds
---@field CalculateRelativeRectTransformBounds fun(trans:Transform):Bounds
---@field FlipLayoutOnAxis fun(rect:RectTransform, axis:number, keepPositioning:boolean, recursive:boolean)
---@field FlipLayoutAxes fun(rect:RectTransform, keepPositioning:boolean, recursive:boolean)
---@field Equals fun(self:System.Object, obj:System.Object):boolean
---@field GetHashCode fun(self:System.Object):number
---@field GetType fun(self:System.Object):System.Type
---@field ToString fun(self:System.Object):string
RectTransformUtility = {}
