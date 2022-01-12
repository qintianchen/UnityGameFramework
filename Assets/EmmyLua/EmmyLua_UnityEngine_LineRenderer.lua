---@class UnityEngine.LineRenderer:UnityEngine.Renderer
---@field numPositions number
---@field startWidth number
---@field endWidth number
---@field widthMultiplier number
---@field numCornerVertices number
---@field numCapVertices number
---@field useWorldSpace boolean
---@field loop boolean
---@field startColor UnityEngine.Color
---@field endColor UnityEngine.Color
---@field positionCount number
---@field shadowBias number
---@field generateLightingData boolean
---@field textureMode UnityEngine.LineTextureMode
---@field alignment UnityEngine.LineAlignment
---@field widthCurve UnityEngine.AnimationCurve
---@field colorGradient UnityEngine.Gradient
---@field lightmapTilingOffset UnityEngine.Vector4
---@field lightProbeAnchor UnityEngine.Transform
---@field castShadows boolean
---@field motionVectors boolean
---@field useLightProbes boolean
---@field bounds UnityEngine.Bounds
---@field enabled boolean
---@field isVisible boolean
---@field shadowCastingMode UnityEngine.Rendering.ShadowCastingMode
---@field receiveShadows boolean
---@field forceRenderingOff boolean
---@field motionVectorGenerationMode UnityEngine.MotionVectorGenerationMode
---@field lightProbeUsage UnityEngine.Rendering.LightProbeUsage
---@field reflectionProbeUsage UnityEngine.Rendering.ReflectionProbeUsage
---@field renderingLayerMask System.UInt32
---@field rendererPriority number
---@field rayTracingMode UnityEngine.Experimental.Rendering.RayTracingMode
---@field sortingLayerName string
---@field sortingLayerID number
---@field sortingOrder number
---@field allowOcclusionWhenDynamic boolean
---@field isPartOfStaticBatch boolean
---@field worldToLocalMatrix UnityEngine.Matrix4x4
---@field localToWorldMatrix UnityEngine.Matrix4x4
---@field lightProbeProxyVolumeOverride UnityEngine.GameObject
---@field probeAnchor UnityEngine.Transform
---@field lightmapIndex number
---@field realtimeLightmapIndex number
---@field lightmapScaleOffset UnityEngine.Vector4
---@field realtimeLightmapScaleOffset UnityEngine.Vector4
---@field materials UnityEngine.Material[]
---@field material UnityEngine.Material
---@field sharedMaterial UnityEngine.Material
---@field sharedMaterials UnityEngine.Material[]
---@field transform UnityEngine.Transform
---@field gameObject UnityEngine.GameObject
---@field tag string
---@field rigidbody UnityEngine.Component
---@field rigidbody2D UnityEngine.Component
---@field camera UnityEngine.Component
---@field light UnityEngine.Component
---@field animation UnityEngine.Component
---@field constantForce UnityEngine.Component
---@field renderer UnityEngine.Component
---@field audio UnityEngine.Component
---@field networkView UnityEngine.Component
---@field collider UnityEngine.Component
---@field collider2D UnityEngine.Component
---@field hingeJoint UnityEngine.Component
---@field particleSystem UnityEngine.Component
---@field name string
---@field hideFlags UnityEngine.HideFlags
---@field SetWidth fun(start:number, end:number)
---@field SetColors fun(start:UnityEngine.Color, end:UnityEngine.Color)
---@field SetVertexCount fun(count:number)
---@field SetPosition fun(index:number, position:UnityEngine.Vector3)
---@field GetPosition fun(index:number):UnityEngine.Vector3
---@field Simplify fun(tolerance:number)
---@field BakeMesh fun(mesh:UnityEngine.Mesh, useTransform:boolean)
---@field BakeMesh fun(mesh:UnityEngine.Mesh, camera:UnityEngine.Camera, useTransform:boolean)
---@field GetPositions fun(positions:UnityEngine.Vector3[]):number
---@field SetPositions fun(positions:UnityEngine.Vector3[])
---@field HasPropertyBlock fun():boolean
---@field SetPropertyBlock fun(properties:UnityEngine.MaterialPropertyBlock)
---@field SetPropertyBlock fun(properties:UnityEngine.MaterialPropertyBlock, materialIndex:number)
---@field GetPropertyBlock fun(properties:UnityEngine.MaterialPropertyBlock)
---@field GetPropertyBlock fun(properties:UnityEngine.MaterialPropertyBlock, materialIndex:number)
---@field GetComponent fun(type:System.Type):UnityEngine.Component
---@field GetComponent fun():nil
---@field TryGetComponent fun(type:System.Type, component:UnityEngine.Component&):boolean
---@field TryGetComponent fun(component:nil):boolean
---@field GetComponent fun(type:string):UnityEngine.Component
---@field GetComponentInChildren fun(t:System.Type, includeInactive:boolean):UnityEngine.Component
---@field GetComponentInChildren fun(t:System.Type):UnityEngine.Component
---@field GetComponentInChildren fun(includeInactive:boolean):nil
---@field GetComponentInChildren fun():nil
---@field GetComponentsInChildren fun(t:System.Type, includeInactive:boolean):UnityEngine.Component[]
---@field GetComponentsInChildren fun(t:System.Type):UnityEngine.Component[]
---@field GetComponentsInChildren fun(includeInactive:boolean):T[]
---@field GetComponentsInChildren fun():T[]
---@field GetComponentInParent fun(t:System.Type):UnityEngine.Component
---@field GetComponentInParent fun():nil
---@field GetComponentsInParent fun(t:System.Type, includeInactive:boolean):UnityEngine.Component[]
---@field GetComponentsInParent fun(t:System.Type):UnityEngine.Component[]
---@field GetComponentsInParent fun(includeInactive:boolean):T[]
---@field GetComponentsInParent fun():T[]
---@field GetComponents fun(type:System.Type):UnityEngine.Component[]
---@field GetComponents fun():T[]
---@field CompareTag fun(tag:string):boolean
---@field SendMessageUpwards fun(methodName:string, value:System.Object, options:UnityEngine.SendMessageOptions)
---@field SendMessageUpwards fun(methodName:string, value:System.Object)
---@field SendMessageUpwards fun(methodName:string)
---@field SendMessageUpwards fun(methodName:string, options:UnityEngine.SendMessageOptions)
---@field SendMessage fun(methodName:string, value:System.Object)
---@field SendMessage fun(methodName:string)
---@field SendMessage fun(methodName:string, value:System.Object, options:UnityEngine.SendMessageOptions)
---@field SendMessage fun(methodName:string, options:UnityEngine.SendMessageOptions)
---@field BroadcastMessage fun(methodName:string, parameter:System.Object, options:UnityEngine.SendMessageOptions)
---@field BroadcastMessage fun(methodName:string, parameter:System.Object)
---@field BroadcastMessage fun(methodName:string)
---@field BroadcastMessage fun(methodName:string, options:UnityEngine.SendMessageOptions)
---@field GetInstanceID fun():number
---@field GetHashCode fun():number
---@field Equals fun(other:System.Object):boolean
---@field ToString fun():string
---@field GetType fun():System.Type
UnityEngine.LineRenderer = {}
