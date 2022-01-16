---@class RectTransform:Transform
---@field rect Rect
---@field anchorMin Vector2
---@field anchorMax Vector2
---@field anchoredPosition Vector2
---@field sizeDelta Vector2
---@field pivot Vector2
---@field anchoredPosition3D Vector3
---@field offsetMin Vector2
---@field offsetMax Vector2
---@field drivenByObject Object
---@field position Vector3
---@field localPosition Vector3
---@field eulerAngles Vector3
---@field localEulerAngles Vector3
---@field right Vector3
---@field up Vector3
---@field forward Vector3
---@field rotation Quaternion
---@field localRotation Quaternion
---@field localScale Vector3
---@field parent Transform
---@field worldToLocalMatrix Matrix4x4
---@field localToWorldMatrix Matrix4x4
---@field root Transform
---@field childCount number
---@field lossyScale Vector3
---@field hasChanged boolean
---@field hierarchyCapacity number
---@field hierarchyCount number
---@field transform Transform
---@field gameObject GameObject
---@field tag string
---@field rigidbody Component
---@field rigidbody2D Component
---@field camera Component
---@field light Component
---@field animation Component
---@field constantForce Component
---@field renderer Component
---@field audio Component
---@field networkView Component
---@field collider Component
---@field collider2D Component
---@field hingeJoint Component
---@field particleSystem Component
---@field name string
---@field hideFlags HideFlags
---@field ForceUpdateRectTransforms fun(self:RectTransform)
---@field GetLocalCorners fun(self:RectTransform, fourCornersArray:Vector3[])
---@field GetWorldCorners fun(self:RectTransform, fourCornersArray:Vector3[])
---@field SetInsetAndSizeFromParentEdge fun(self:RectTransform, edge:RectTransform.Edge, inset:number, size:number)
---@field SetSizeWithCurrentAnchors fun(self:RectTransform, axis:RectTransform.Axis, size:number)
---@field SetParent fun(self:Transform, p:Transform)
---@field SetParent fun(self:Transform, parent:Transform, worldPositionStays:boolean)
---@field SetPositionAndRotation fun(self:Transform, position:Vector3, rotation:Quaternion)
---@field Translate fun(self:Transform, translation:Vector3, relativeTo:Space)
---@field Translate fun(self:Transform, translation:Vector3)
---@field Translate fun(self:Transform, x:number, y:number, z:number, relativeTo:Space)
---@field Translate fun(self:Transform, x:number, y:number, z:number)
---@field Translate fun(self:Transform, translation:Vector3, relativeTo:Transform)
---@field Translate fun(self:Transform, x:number, y:number, z:number, relativeTo:Transform)
---@field Rotate fun(self:Transform, eulers:Vector3, relativeTo:Space)
---@field Rotate fun(self:Transform, eulers:Vector3)
---@field Rotate fun(self:Transform, xAngle:number, yAngle:number, zAngle:number, relativeTo:Space)
---@field Rotate fun(self:Transform, xAngle:number, yAngle:number, zAngle:number)
---@field Rotate fun(self:Transform, axis:Vector3, angle:number, relativeTo:Space)
---@field Rotate fun(self:Transform, axis:Vector3, angle:number)
---@field RotateAround fun(self:Transform, point:Vector3, axis:Vector3, angle:number)
---@field LookAt fun(self:Transform, target:Transform, worldUp:Vector3)
---@field LookAt fun(self:Transform, target:Transform)
---@field LookAt fun(self:Transform, worldPosition:Vector3, worldUp:Vector3)
---@field LookAt fun(self:Transform, worldPosition:Vector3)
---@field TransformDirection fun(self:Transform, direction:Vector3):Vector3
---@field TransformDirection fun(self:Transform, x:number, y:number, z:number):Vector3
---@field InverseTransformDirection fun(self:Transform, direction:Vector3):Vector3
---@field InverseTransformDirection fun(self:Transform, x:number, y:number, z:number):Vector3
---@field TransformVector fun(self:Transform, vector:Vector3):Vector3
---@field TransformVector fun(self:Transform, x:number, y:number, z:number):Vector3
---@field InverseTransformVector fun(self:Transform, vector:Vector3):Vector3
---@field InverseTransformVector fun(self:Transform, x:number, y:number, z:number):Vector3
---@field TransformPoint fun(self:Transform, position:Vector3):Vector3
---@field TransformPoint fun(self:Transform, x:number, y:number, z:number):Vector3
---@field InverseTransformPoint fun(self:Transform, position:Vector3):Vector3
---@field InverseTransformPoint fun(self:Transform, x:number, y:number, z:number):Vector3
---@field DetachChildren fun(self:Transform)
---@field SetAsFirstSibling fun(self:Transform)
---@field SetAsLastSibling fun(self:Transform)
---@field SetSiblingIndex fun(self:Transform, index:number)
---@field GetSiblingIndex fun(self:Transform):number
---@field Find fun(self:Transform, n:string):Transform
---@field IsChildOf fun(self:Transform, parent:Transform):boolean
---@field FindChild fun(self:Transform, n:string):Transform
---@field RotateAround fun(self:Transform, axis:Vector3, angle:number)
---@field RotateAroundLocal fun(self:Transform, axis:Vector3, angle:number)
---@field GetChild fun(self:Transform, index:number):Transform
---@field GetChildCount fun(self:Transform):number
---@field GetComponent fun(self:Component, type:System.Type):Component
---@field GetComponent fun(self:Component):nil
---@field TryGetComponent fun(self:Component, type:System.Type, component:Component&):boolean
---@field TryGetComponent fun(self:Component, component:nil):boolean
---@field GetComponent fun(self:Component, type:string):Component
---@field GetComponentInChildren fun(self:Component, t:System.Type, includeInactive:boolean):Component
---@field GetComponentInChildren fun(self:Component, t:System.Type):Component
---@field GetComponentInChildren fun(self:Component, includeInactive:boolean):nil
---@field GetComponentInChildren fun(self:Component):nil
---@field GetComponentsInChildren fun(self:Component, t:System.Type, includeInactive:boolean):Component[]
---@field GetComponentsInChildren fun(self:Component, t:System.Type):Component[]
---@field GetComponentsInChildren fun(self:Component, includeInactive:boolean):nil
---@field GetComponentsInChildren fun(self:Component, includeInactive:boolean, result:nil)
---@field GetComponentsInChildren fun(self:Component):nil
---@field GetComponentsInChildren fun(self:Component, results:nil)
---@field GetComponentInParent fun(self:Component, t:System.Type, includeInactive:boolean):Component
---@field GetComponentInParent fun(self:Component, t:System.Type):Component
---@field GetComponentInParent fun(self:Component, includeInactive:boolean):nil
---@field GetComponentInParent fun(self:Component):nil
---@field GetComponentsInParent fun(self:Component, t:System.Type, includeInactive:boolean):Component[]
---@field GetComponentsInParent fun(self:Component, t:System.Type):Component[]
---@field GetComponentsInParent fun(self:Component, includeInactive:boolean):nil
---@field GetComponentsInParent fun(self:Component, includeInactive:boolean, results:nil)
---@field GetComponentsInParent fun(self:Component):nil
---@field GetComponents fun(self:Component, type:System.Type):Component[]
---@field GetComponents fun(self:Component, type:System.Type, results:System.Collections.Generic.List`1[[Component, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetComponents fun(self:Component, results:nil)
---@field GetComponents fun(self:Component):nil
---@field CompareTag fun(self:Component, tag:string):boolean
---@field SendMessageUpwards fun(self:Component, methodName:string, value:System.Object, options:SendMessageOptions)
---@field SendMessageUpwards fun(self:Component, methodName:string, value:System.Object)
---@field SendMessageUpwards fun(self:Component, methodName:string)
---@field SendMessageUpwards fun(self:Component, methodName:string, options:SendMessageOptions)
---@field SendMessage fun(self:Component, methodName:string, value:System.Object)
---@field SendMessage fun(self:Component, methodName:string)
---@field SendMessage fun(self:Component, methodName:string, value:System.Object, options:SendMessageOptions)
---@field SendMessage fun(self:Component, methodName:string, options:SendMessageOptions)
---@field BroadcastMessage fun(self:Component, methodName:string, parameter:System.Object, options:SendMessageOptions)
---@field BroadcastMessage fun(self:Component, methodName:string, parameter:System.Object)
---@field BroadcastMessage fun(self:Component, methodName:string)
---@field BroadcastMessage fun(self:Component, methodName:string, options:SendMessageOptions)
---@field GetInstanceID fun(self:Object):number
---@field GetHashCode fun(self:Object):number
---@field Equals fun(self:Object, other:System.Object):boolean
---@field ToString fun(self:Object):string
---@field GetType fun(self:System.Object):System.Type
RectTransform = {}
