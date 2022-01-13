---@class Sprite:Object
---@field bounds Bounds
---@field rect Rect
---@field border Vector4
---@field texture Texture2D
---@field pixelsPerUnit number
---@field spriteAtlasTextureScale number
---@field associatedAlphaSplitTexture Texture2D
---@field pivot Vector2
---@field packed boolean
---@field packingMode SpritePackingMode
---@field packingRotation SpritePackingRotation
---@field textureRect Rect
---@field textureRectOffset Vector2
---@field vertices Vector2[]
---@field triangles System.UInt16[]
---@field uv Vector2[]
---@field name string
---@field hideFlags HideFlags
---@field GetPhysicsShapeCount fun(self:Sprite):number
---@field GetPhysicsShapePointCount fun(self:Sprite, shapeIdx:number):number
---@field GetPhysicsShape fun(self:Sprite, shapeIdx:number, physicsShape:System.Collections.Generic.List`1[[Vector2, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]):number
---@field OverridePhysicsShape fun(self:Sprite, physicsShapes:System.Collections.Generic.IList`1[[Vector2[], CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field OverrideGeometry fun(self:Sprite, vertices:Vector2[], triangles:System.UInt16[])
---@field Create fun(texture:Texture2D, rect:Rect, pivot:Vector2, pixelsPerUnit:number, extrude:System.UInt32, meshType:SpriteMeshType, border:Vector4, generateFallbackPhysicsShape:boolean):Sprite
---@field Create fun(texture:Texture2D, rect:Rect, pivot:Vector2, pixelsPerUnit:number, extrude:System.UInt32, meshType:SpriteMeshType, border:Vector4):Sprite
---@field Create fun(texture:Texture2D, rect:Rect, pivot:Vector2, pixelsPerUnit:number, extrude:System.UInt32, meshType:SpriteMeshType):Sprite
---@field Create fun(texture:Texture2D, rect:Rect, pivot:Vector2, pixelsPerUnit:number, extrude:System.UInt32):Sprite
---@field Create fun(texture:Texture2D, rect:Rect, pivot:Vector2, pixelsPerUnit:number):Sprite
---@field Create fun(texture:Texture2D, rect:Rect, pivot:Vector2):Sprite
---@field GetInstanceID fun(self:Object):number
---@field GetHashCode fun(self:Object):number
---@field Equals fun(self:Object, other:System.Object):boolean
---@field ToString fun(self:Object):string
---@field GetType fun(self:System.Object):System.Type
Sprite = {}
