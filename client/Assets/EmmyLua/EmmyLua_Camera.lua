---@class Camera:Behaviour
---@field nearClipPlane number
---@field farClipPlane number
---@field fieldOfView number
---@field renderingPath RenderingPath
---@field actualRenderingPath RenderingPath
---@field allowHDR boolean
---@field allowMSAA boolean
---@field allowDynamicResolution boolean
---@field forceIntoRenderTexture boolean
---@field orthographicSize number
---@field orthographic boolean
---@field opaqueSortMode Rendering.OpaqueSortMode
---@field transparencySortMode TransparencySortMode
---@field transparencySortAxis Vector3
---@field depth number
---@field aspect number
---@field velocity Vector3
---@field cullingMask number
---@field eventMask number
---@field layerCullSpherical boolean
---@field cameraType CameraType
---@field overrideSceneCullingMask number
---@field layerCullDistances System.Single[]
---@field useOcclusionCulling boolean
---@field cullingMatrix Matrix4x4
---@field backgroundColor Color
---@field clearFlags CameraClearFlags
---@field depthTextureMode DepthTextureMode
---@field clearStencilAfterLightingPass boolean
---@field usePhysicalProperties boolean
---@field sensorSize Vector2
---@field lensShift Vector2
---@field focalLength number
---@field gateFit Camera.GateFitMode
---@field rect Rect
---@field pixelRect Rect
---@field pixelWidth number
---@field pixelHeight number
---@field scaledPixelWidth number
---@field scaledPixelHeight number
---@field targetTexture RenderTexture
---@field activeTexture RenderTexture
---@field targetDisplay number
---@field cameraToWorldMatrix Matrix4x4
---@field worldToCameraMatrix Matrix4x4
---@field projectionMatrix Matrix4x4
---@field nonJitteredProjectionMatrix Matrix4x4
---@field useJitteredProjectionMatrixForTransparentRendering boolean
---@field previousViewProjectionMatrix Matrix4x4
---@field main Camera
---@field current Camera
---@field scene SceneManagement.Scene
---@field stereoEnabled boolean
---@field stereoSeparation number
---@field stereoConvergence number
---@field areVRStereoViewMatricesWithinSingleCullTolerance boolean
---@field stereoTargetEye StereoTargetEyeMask
---@field stereoActiveEye Camera.MonoOrStereoscopicEye
---@field allCamerasCount number
---@field allCameras Camera[]
---@field sceneViewFilterMode Camera.SceneViewFilterMode
---@field commandBufferCount number
---@field isOrthoGraphic boolean
---@field mainCamera Camera
---@field near number
---@field far number
---@field fov number
---@field hdr boolean
---@field stereoMirrorMode boolean
---@field enabled boolean
---@field isActiveAndEnabled boolean
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
---@field Reset fun(self:Camera)
---@field ResetTransparencySortSettings fun(self:Camera)
---@field ResetAspect fun(self:Camera)
---@field ResetCullingMatrix fun(self:Camera)
---@field SetReplacementShader fun(self:Camera, shader:Shader, replacementTag:string)
---@field ResetReplacementShader fun(self:Camera)
---@field GetGateFittedFieldOfView fun(self:Camera):number
---@field GetGateFittedLensShift fun(self:Camera):Vector2
---@field SetTargetBuffers fun(self:Camera, colorBuffer:RenderBuffer, depthBuffer:RenderBuffer)
---@field SetTargetBuffers fun(self:Camera, colorBuffer:RenderBuffer[], depthBuffer:RenderBuffer)
---@field ResetWorldToCameraMatrix fun(self:Camera)
---@field ResetProjectionMatrix fun(self:Camera)
---@field CalculateObliqueMatrix fun(self:Camera, clipPlane:Vector4):Matrix4x4
---@field WorldToScreenPoint fun(self:Camera, position:Vector3, eye:Camera.MonoOrStereoscopicEye):Vector3
---@field WorldToViewportPoint fun(self:Camera, position:Vector3, eye:Camera.MonoOrStereoscopicEye):Vector3
---@field ViewportToWorldPoint fun(self:Camera, position:Vector3, eye:Camera.MonoOrStereoscopicEye):Vector3
---@field ScreenToWorldPoint fun(self:Camera, position:Vector3, eye:Camera.MonoOrStereoscopicEye):Vector3
---@field WorldToScreenPoint fun(self:Camera, position:Vector3):Vector3
---@field WorldToViewportPoint fun(self:Camera, position:Vector3):Vector3
---@field ViewportToWorldPoint fun(self:Camera, position:Vector3):Vector3
---@field ScreenToWorldPoint fun(self:Camera, position:Vector3):Vector3
---@field ScreenToViewportPoint fun(self:Camera, position:Vector3):Vector3
---@field ViewportToScreenPoint fun(self:Camera, position:Vector3):Vector3
---@field ViewportPointToRay fun(self:Camera, pos:Vector3, eye:Camera.MonoOrStereoscopicEye):Ray
---@field ViewportPointToRay fun(self:Camera, pos:Vector3):Ray
---@field ScreenPointToRay fun(self:Camera, pos:Vector3, eye:Camera.MonoOrStereoscopicEye):Ray
---@field ScreenPointToRay fun(self:Camera, pos:Vector3):Ray
---@field CalculateFrustumCorners fun(self:Camera, viewport:Rect, z:number, eye:Camera.MonoOrStereoscopicEye, outCorners:Vector3[])
---@field CalculateProjectionMatrixFromPhysicalProperties fun(output:Matrix4x4&, focalLength:number, sensorSize:Vector2, lensShift:Vector2, nearClip:number, farClip:number, gateFitParameters:Camera.GateFitParameters)
---@field FocalLengthToFieldOfView fun(focalLength:number, sensorSize:number):number
---@field FieldOfViewToFocalLength fun(fieldOfView:number, sensorSize:number):number
---@field HorizontalToVerticalFieldOfView fun(horizontalFieldOfView:number, aspectRatio:number):number
---@field VerticalToHorizontalFieldOfView fun(verticalFieldOfView:number, aspectRatio:number):number
---@field GetStereoNonJitteredProjectionMatrix fun(self:Camera, eye:Camera.StereoscopicEye):Matrix4x4
---@field GetStereoViewMatrix fun(self:Camera, eye:Camera.StereoscopicEye):Matrix4x4
---@field CopyStereoDeviceProjectionMatrixToNonJittered fun(self:Camera, eye:Camera.StereoscopicEye)
---@field GetStereoProjectionMatrix fun(self:Camera, eye:Camera.StereoscopicEye):Matrix4x4
---@field SetStereoProjectionMatrix fun(self:Camera, eye:Camera.StereoscopicEye, matrix:Matrix4x4)
---@field ResetStereoProjectionMatrices fun(self:Camera)
---@field SetStereoViewMatrix fun(self:Camera, eye:Camera.StereoscopicEye, matrix:Matrix4x4)
---@field ResetStereoViewMatrices fun(self:Camera)
---@field GetAllCameras fun(cameras:Camera[]):number
---@field RenderToCubemap fun(self:Camera, cubemap:Cubemap, faceMask:number):boolean
---@field RenderToCubemap fun(self:Camera, cubemap:Cubemap):boolean
---@field RenderToCubemap fun(self:Camera, cubemap:RenderTexture, faceMask:number):boolean
---@field RenderToCubemap fun(self:Camera, cubemap:RenderTexture):boolean
---@field RenderToCubemap fun(self:Camera, cubemap:RenderTexture, faceMask:number, stereoEye:Camera.MonoOrStereoscopicEye):boolean
---@field Render fun(self:Camera)
---@field RenderWithShader fun(self:Camera, shader:Shader, replacementTag:string)
---@field RenderDontRestore fun(self:Camera)
---@field SubmitRenderRequests fun(self:Camera, renderRequests:System.Collections.Generic.List`1[[Camera.RenderRequest, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field SetupCurrent fun(cur:Camera)
---@field CopyFrom fun(self:Camera, other:Camera)
---@field RemoveCommandBuffers fun(self:Camera, evt:Rendering.CameraEvent)
---@field RemoveAllCommandBuffers fun(self:Camera)
---@field AddCommandBuffer fun(self:Camera, evt:Rendering.CameraEvent, buffer:Rendering.CommandBuffer)
---@field AddCommandBufferAsync fun(self:Camera, evt:Rendering.CameraEvent, buffer:Rendering.CommandBuffer, queueType:Rendering.ComputeQueueType)
---@field RemoveCommandBuffer fun(self:Camera, evt:Rendering.CameraEvent, buffer:Rendering.CommandBuffer)
---@field GetCommandBuffers fun(self:Camera, evt:Rendering.CameraEvent):Rendering.CommandBuffer[]
---@field TryGetCullingParameters fun(self:Camera, cullingParameters:Rendering.ScriptableCullingParameters&):boolean
---@field TryGetCullingParameters fun(self:Camera, stereoAware:boolean, cullingParameters:Rendering.ScriptableCullingParameters&):boolean
---@field GetScreenWidth fun(self:Camera):number
---@field GetScreenHeight fun(self:Camera):number
---@field DoClear fun(self:Camera)
---@field ResetFieldOfView fun(self:Camera)
---@field SetStereoViewMatrices fun(self:Camera, leftMatrix:Matrix4x4, rightMatrix:Matrix4x4)
---@field SetStereoProjectionMatrices fun(self:Camera, leftMatrix:Matrix4x4, rightMatrix:Matrix4x4)
---@field GetStereoViewMatrices fun(self:Camera):Matrix4x4[]
---@field GetStereoProjectionMatrices fun(self:Camera):Matrix4x4[]
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
---@field DOAspect fun(target:Camera, endValue:number, duration:number):DG.Tweening.Core.TweenerCore`3[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[DG.Tweening.Plugins.Options.FloatOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOColor fun(target:Camera, endValue:Color, duration:number):DG.Tweening.Core.TweenerCore`3[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.ColorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOFarClipPlane fun(target:Camera, endValue:number, duration:number):DG.Tweening.Core.TweenerCore`3[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[DG.Tweening.Plugins.Options.FloatOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOFieldOfView fun(target:Camera, endValue:number, duration:number):DG.Tweening.Core.TweenerCore`3[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[DG.Tweening.Plugins.Options.FloatOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DONearClipPlane fun(target:Camera, endValue:number, duration:number):DG.Tweening.Core.TweenerCore`3[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[DG.Tweening.Plugins.Options.FloatOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOOrthoSize fun(target:Camera, endValue:number, duration:number):DG.Tweening.Core.TweenerCore`3[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[DG.Tweening.Plugins.Options.FloatOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOPixelRect fun(target:Camera, endValue:Rect, duration:number):DG.Tweening.Core.TweenerCore`3[[Rect, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Rect, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.RectOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DORect fun(target:Camera, endValue:Rect, duration:number):DG.Tweening.Core.TweenerCore`3[[Rect, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Rect, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.RectOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOShakePosition fun(target:Camera, duration:number, strength:number, vibrato:number, randomness:number, fadeOut:boolean):DG.Tweening.Tweener
---@field DOShakePosition fun(target:Camera, duration:number, strength:Vector3, vibrato:number, randomness:number, fadeOut:boolean):DG.Tweening.Tweener
---@field DOShakeRotation fun(target:Camera, duration:number, strength:number, vibrato:number, randomness:number, fadeOut:boolean):DG.Tweening.Tweener
---@field DOShakeRotation fun(target:Camera, duration:number, strength:Vector3, vibrato:number, randomness:number, fadeOut:boolean):DG.Tweening.Tweener
Camera = {}
