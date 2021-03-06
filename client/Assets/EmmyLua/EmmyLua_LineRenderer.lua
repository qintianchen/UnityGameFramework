---@class LineRenderer:Renderer
---@field numPositions number
---@field startWidth number
---@field endWidth number
---@field widthMultiplier number
---@field numCornerVertices number
---@field numCapVertices number
---@field useWorldSpace boolean
---@field loop boolean
---@field startColor Color
---@field endColor Color
---@field positionCount number
---@field shadowBias number
---@field generateLightingData boolean
---@field textureMode LineTextureMode
---@field alignment LineAlignment
---@field widthCurve AnimationCurve
---@field colorGradient Gradient
---@field lightmapTilingOffset Vector4
---@field lightProbeAnchor Transform
---@field castShadows boolean
---@field motionVectors boolean
---@field useLightProbes boolean
---@field bounds Bounds
---@field localBounds Bounds
---@field enabled boolean
---@field isVisible boolean
---@field shadowCastingMode Rendering.ShadowCastingMode
---@field receiveShadows boolean
---@field forceRenderingOff boolean
---@field staticShadowCaster boolean
---@field motionVectorGenerationMode MotionVectorGenerationMode
---@field lightProbeUsage Rendering.LightProbeUsage
---@field reflectionProbeUsage Rendering.ReflectionProbeUsage
---@field renderingLayerMask System.UInt32
---@field rendererPriority number
---@field rayTracingMode Experimental.Rendering.RayTracingMode
---@field sortingLayerName string
---@field sortingLayerID number
---@field sortingOrder number
---@field allowOcclusionWhenDynamic boolean
---@field isPartOfStaticBatch boolean
---@field worldToLocalMatrix Matrix4x4
---@field localToWorldMatrix Matrix4x4
---@field lightProbeProxyVolumeOverride GameObject
---@field probeAnchor Transform
---@field lightmapIndex number
---@field realtimeLightmapIndex number
---@field lightmapScaleOffset Vector4
---@field realtimeLightmapScaleOffset Vector4
---@field materials Material[]
---@field material Material
---@field sharedMaterial Material
---@field sharedMaterials Material[]
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
---@field SetWidth fun(self:LineRenderer, start:number, end:number)
---@field SetColors fun(self:LineRenderer, start:Color, end:Color)
---@field SetVertexCount fun(self:LineRenderer, count:number)
---@field SetPosition fun(self:LineRenderer, index:number, position:Vector3)
---@field GetPosition fun(self:LineRenderer, index:number):Vector3
---@field Simplify fun(self:LineRenderer, tolerance:number)
---@field BakeMesh fun(self:LineRenderer, mesh:Mesh, useTransform:boolean)
---@field BakeMesh fun(self:LineRenderer, mesh:Mesh, camera:Camera, useTransform:boolean)
---@field GetPositions fun(self:LineRenderer, positions:Vector3[]):number
---@field SetPositions fun(self:LineRenderer, positions:Vector3[])
---@field SetPositions fun(self:LineRenderer, positions:Unity.Collections.NativeArray`1[[Vector3, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field SetPositions fun(self:LineRenderer, positions:Unity.Collections.NativeSlice`1[[Vector3, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetPositions fun(self:LineRenderer, positions:Unity.Collections.NativeArray`1[[Vector3, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]):number
---@field GetPositions fun(self:LineRenderer, positions:Unity.Collections.NativeSlice`1[[Vector3, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]):number
---@field ResetBounds fun(self:Renderer)
---@field ResetLocalBounds fun(self:Renderer)
---@field HasPropertyBlock fun(self:Renderer):boolean
---@field SetPropertyBlock fun(self:Renderer, properties:MaterialPropertyBlock)
---@field SetPropertyBlock fun(self:Renderer, properties:MaterialPropertyBlock, materialIndex:number)
---@field GetPropertyBlock fun(self:Renderer, properties:MaterialPropertyBlock)
---@field GetPropertyBlock fun(self:Renderer, properties:MaterialPropertyBlock, materialIndex:number)
---@field GetMaterials fun(self:Renderer, m:System.Collections.Generic.List`1[[Material, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetSharedMaterials fun(self:Renderer, m:System.Collections.Generic.List`1[[Material, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetClosestReflectionProbes fun(self:Renderer, result:System.Collections.Generic.List`1[[Rendering.ReflectionProbeBlendInfo, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
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
---@field DOColor fun(target:LineRenderer, startValue:DG.Tweening.Color2, endValue:DG.Tweening.Color2, duration:number):DG.Tweening.Tweener
LineRenderer = {}
