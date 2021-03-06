---@class Video.VideoPlayer:Behaviour
---@field source Video.VideoSource
---@field url string
---@field clip Video.VideoClip
---@field renderMode Video.VideoRenderMode
---@field targetCamera Camera
---@field targetTexture RenderTexture
---@field targetMaterialRenderer Renderer
---@field targetMaterialProperty string
---@field aspectRatio Video.VideoAspectRatio
---@field targetCameraAlpha number
---@field targetCamera3DLayout Video.Video3DLayout
---@field texture Texture
---@field isPrepared boolean
---@field waitForFirstFrame boolean
---@field playOnAwake boolean
---@field isPlaying boolean
---@field isPaused boolean
---@field canSetTime boolean
---@field time System.Double
---@field frame System.Int64
---@field clockTime System.Double
---@field canStep boolean
---@field canSetPlaybackSpeed boolean
---@field playbackSpeed number
---@field isLooping boolean
---@field canSetTimeSource boolean
---@field timeSource Video.VideoTimeSource
---@field timeReference Video.VideoTimeReference
---@field externalReferenceTime System.Double
---@field canSetSkipOnDrop boolean
---@field skipOnDrop boolean
---@field frameCount number
---@field frameRate number
---@field length System.Double
---@field width System.UInt32
---@field height System.UInt32
---@field pixelAspectRatioNumerator System.UInt32
---@field pixelAspectRatioDenominator System.UInt32
---@field audioTrackCount System.UInt16
---@field controlledAudioTrackMaxCount System.UInt16
---@field controlledAudioTrackCount System.UInt16
---@field audioOutputMode Video.VideoAudioOutputMode
---@field canSetDirectAudioVolume boolean
---@field sendFrameReadyEvents boolean
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
---@field Prepare fun(self:Video.VideoPlayer)
---@field Play fun(self:Video.VideoPlayer)
---@field Pause fun(self:Video.VideoPlayer)
---@field Stop fun(self:Video.VideoPlayer)
---@field StepForward fun(self:Video.VideoPlayer)
---@field GetAudioLanguageCode fun(self:Video.VideoPlayer, trackIndex:System.UInt16):string
---@field GetAudioChannelCount fun(self:Video.VideoPlayer, trackIndex:System.UInt16):System.UInt16
---@field GetAudioSampleRate fun(self:Video.VideoPlayer, trackIndex:System.UInt16):System.UInt32
---@field EnableAudioTrack fun(self:Video.VideoPlayer, trackIndex:System.UInt16, enabled:boolean)
---@field IsAudioTrackEnabled fun(self:Video.VideoPlayer, trackIndex:System.UInt16):boolean
---@field GetDirectAudioVolume fun(self:Video.VideoPlayer, trackIndex:System.UInt16):number
---@field SetDirectAudioVolume fun(self:Video.VideoPlayer, trackIndex:System.UInt16, volume:number)
---@field GetDirectAudioMute fun(self:Video.VideoPlayer, trackIndex:System.UInt16):boolean
---@field SetDirectAudioMute fun(self:Video.VideoPlayer, trackIndex:System.UInt16, mute:boolean)
---@field GetTargetAudioSource fun(self:Video.VideoPlayer, trackIndex:System.UInt16):AudioSource
---@field SetTargetAudioSource fun(self:Video.VideoPlayer, trackIndex:System.UInt16, source:AudioSource)
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
Video.VideoPlayer = {}
