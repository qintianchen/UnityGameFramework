---@class UnityEngine.RectTransformUtility:System.Object
---@field PixelAdjustPoint fun(point:UnityEngine.Vector2, elementTransform:UnityEngine.Transform, canvas:UnityEngine.Canvas):UnityEngine.Vector2
---@field PixelAdjustRect fun(rectTransform:UnityEngine.RectTransform, canvas:UnityEngine.Canvas):UnityEngine.Rect
---@field RectangleContainsScreenPoint fun(rect:UnityEngine.RectTransform, screenPoint:UnityEngine.Vector2):boolean
---@field RectangleContainsScreenPoint fun(rect:UnityEngine.RectTransform, screenPoint:UnityEngine.Vector2, cam:UnityEngine.Camera):boolean
---@field RectangleContainsScreenPoint fun(rect:UnityEngine.RectTransform, screenPoint:UnityEngine.Vector2, cam:UnityEngine.Camera, offset:UnityEngine.Vector4):boolean
---@field ScreenPointToWorldPointInRectangle fun(rect:UnityEngine.RectTransform, screenPoint:UnityEngine.Vector2, cam:UnityEngine.Camera, worldPoint:UnityEngine.Vector3&):boolean
---@field ScreenPointToLocalPointInRectangle fun(rect:UnityEngine.RectTransform, screenPoint:UnityEngine.Vector2, cam:UnityEngine.Camera, localPoint:UnityEngine.Vector2&):boolean
---@field ScreenPointToRay fun(cam:UnityEngine.Camera, screenPos:UnityEngine.Vector2):UnityEngine.Ray
---@field WorldToScreenPoint fun(cam:UnityEngine.Camera, worldPoint:UnityEngine.Vector3):UnityEngine.Vector2
---@field CalculateRelativeRectTransformBounds fun(root:UnityEngine.Transform, child:UnityEngine.Transform):UnityEngine.Bounds
---@field CalculateRelativeRectTransformBounds fun(trans:UnityEngine.Transform):UnityEngine.Bounds
---@field FlipLayoutOnAxis fun(rect:UnityEngine.RectTransform, axis:number, keepPositioning:boolean, recursive:boolean)
---@field FlipLayoutAxes fun(rect:UnityEngine.RectTransform, keepPositioning:boolean, recursive:boolean)
---@field Equals fun(obj:System.Object):boolean
---@field GetHashCode fun():number
---@field GetType fun():System.Type
---@field ToString fun():string
UnityEngine.RectTransformUtility = {}
