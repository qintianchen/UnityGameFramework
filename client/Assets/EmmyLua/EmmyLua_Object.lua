---@class Object:System.Object
---@field name string
---@field hideFlags HideFlags
---@field GetInstanceID fun(self:Object):number
---@field GetHashCode fun(self:Object):number
---@field Equals fun(self:Object, other:System.Object):boolean
---@field Instantiate fun(original:Object, position:Vector3, rotation:Quaternion):Object
---@field Instantiate fun(original:Object, position:Vector3, rotation:Quaternion, parent:Transform):Object
---@field Instantiate fun(original:Object):Object
---@field Instantiate fun(original:Object, parent:Transform):Object
---@field Instantiate fun(original:Object, parent:Transform, instantiateInWorldSpace:boolean):Object
---@field Instantiate fun(original:nil):nil
---@field Instantiate fun(original:nil, position:Vector3, rotation:Quaternion):nil
---@field Instantiate fun(original:nil, position:Vector3, rotation:Quaternion, parent:Transform):nil
---@field Instantiate fun(original:nil, parent:Transform):nil
---@field Instantiate fun(original:nil, parent:Transform, worldPositionStays:boolean):nil
---@field Destroy fun(obj:Object, t:number)
---@field Destroy fun(obj:Object)
---@field DestroyImmediate fun(obj:Object, allowDestroyingAssets:boolean)
---@field DestroyImmediate fun(obj:Object)
---@field FindObjectsOfType fun(type:System.Type):Object[]
---@field FindObjectsOfType fun(type:System.Type, includeInactive:boolean):Object[]
---@field DontDestroyOnLoad fun(target:Object)
---@field DestroyObject fun(obj:Object, t:number)
---@field DestroyObject fun(obj:Object)
---@field FindSceneObjectsOfType fun(type:System.Type):Object[]
---@field FindObjectsOfTypeIncludingAssets fun(type:System.Type):Object[]
---@field FindObjectsOfType fun():nil
---@field FindObjectsOfType fun(includeInactive:boolean):nil
---@field FindObjectOfType fun():nil
---@field FindObjectOfType fun(includeInactive:boolean):nil
---@field FindObjectsOfTypeAll fun(type:System.Type):Object[]
---@field FindObjectOfType fun(type:System.Type):Object
---@field FindObjectOfType fun(type:System.Type, includeInactive:boolean):Object
---@field ToString fun(self:Object):string
---@field GetType fun(self:System.Object):System.Type
Object = {}
