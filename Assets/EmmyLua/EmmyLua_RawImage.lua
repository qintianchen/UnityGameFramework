---@class RawImage:MaskableGraphic
---@field mainTexture Texture
---@field texture Texture
---@field uvRect Rect
---@field onCullStateChanged MaskableGraphic.CullStateChangedEvent
---@field maskable boolean
---@field isMaskingGraphic boolean
---@field color Color
---@field raycastTarget boolean
---@field raycastPadding Vector4
---@field depth number
---@field rectTransform RectTransform
---@field canvas Canvas
---@field canvasRenderer CanvasRenderer
---@field defaultMaterial Material
---@field material Material
---@field materialForRendering Material
---@field useGUILayout boolean
---@field runInEditMode boolean
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
---@field SetNativeSize fun(self:RawImage)
---@field GetModifiedMaterial fun(self:MaskableGraphic, baseMaterial:Material):Material
---@field Cull fun(self:MaskableGraphic, clipRect:Rect, validRect:boolean)
---@field SetClipRect fun(self:MaskableGraphic, clipRect:Rect, validRect:boolean)
---@field SetClipSoftness fun(self:MaskableGraphic, clipSoftness:Vector2)
---@field ParentMaskStateChanged fun(self:MaskableGraphic)
---@field RecalculateClipping fun(self:MaskableGraphic)
---@field RecalculateMasking fun(self:MaskableGraphic)
---@field SetAllDirty fun(self:Graphic)
---@field SetLayoutDirty fun(self:Graphic)
---@field SetVerticesDirty fun(self:Graphic)
---@field SetMaterialDirty fun(self:Graphic)
---@field OnCullingChanged fun(self:Graphic)
---@field Rebuild fun(self:Graphic, update:CanvasUpdate)
---@field LayoutComplete fun(self:Graphic)
---@field GraphicUpdateComplete fun(self:Graphic)
---@field OnRebuildRequested fun(self:Graphic)
---@field Raycast fun(self:Graphic, sp:Vector2, eventCamera:Camera):boolean
---@field PixelAdjustPoint fun(self:Graphic, point:Vector2):Vector2
---@field GetPixelAdjustedRect fun(self:Graphic):Rect
---@field CrossFadeColor fun(self:Graphic, targetColor:Color, duration:number, ignoreTimeScale:boolean, useAlpha:boolean)
---@field CrossFadeColor fun(self:Graphic, targetColor:Color, duration:number, ignoreTimeScale:boolean, useAlpha:boolean, useRGB:boolean)
---@field CrossFadeAlpha fun(self:Graphic, alpha:number, duration:number, ignoreTimeScale:boolean)
---@field RegisterDirtyLayoutCallback fun(self:Graphic, action:Events.UnityAction)
---@field UnregisterDirtyLayoutCallback fun(self:Graphic, action:Events.UnityAction)
---@field RegisterDirtyVerticesCallback fun(self:Graphic, action:Events.UnityAction)
---@field UnregisterDirtyVerticesCallback fun(self:Graphic, action:Events.UnityAction)
---@field RegisterDirtyMaterialCallback fun(self:Graphic, action:Events.UnityAction)
---@field UnregisterDirtyMaterialCallback fun(self:Graphic, action:Events.UnityAction)
---@field IsActive fun(self:EventSystems.UIBehaviour):boolean
---@field IsDestroyed fun(self:EventSystems.UIBehaviour):boolean
---@field IsInvoking fun(self:MonoBehaviour):boolean
---@field CancelInvoke fun(self:MonoBehaviour)
---@field Invoke fun(self:MonoBehaviour, methodName:string, time:number)
---@field InvokeRepeating fun(self:MonoBehaviour, methodName:string, time:number, repeatRate:number)
---@field CancelInvoke fun(self:MonoBehaviour, methodName:string)
---@field IsInvoking fun(self:MonoBehaviour, methodName:string):boolean
---@field StartCoroutine fun(self:MonoBehaviour, methodName:string):Coroutine
---@field StartCoroutine fun(self:MonoBehaviour, methodName:string, value:System.Object):Coroutine
---@field StartCoroutine fun(self:MonoBehaviour, routine:System.Collections.IEnumerator):Coroutine
---@field StartCoroutine_Auto fun(self:MonoBehaviour, routine:System.Collections.IEnumerator):Coroutine
---@field StopCoroutine fun(self:MonoBehaviour, routine:System.Collections.IEnumerator)
---@field StopCoroutine fun(self:MonoBehaviour, routine:Coroutine)
---@field StopCoroutine fun(self:MonoBehaviour, methodName:string)
---@field StopAllCoroutines fun(self:MonoBehaviour)
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
---@field GetComponentsInChildren fun(self:Component, includeInactive:boolean):T[]
---@field GetComponentsInChildren fun(self:Component, includeInactive:boolean, result:nil)
---@field GetComponentsInChildren fun(self:Component):T[]
---@field GetComponentsInChildren fun(self:Component, results:nil)
---@field GetComponentInParent fun(self:Component, t:System.Type):Component
---@field GetComponentInParent fun(self:Component):nil
---@field GetComponentsInParent fun(self:Component, t:System.Type, includeInactive:boolean):Component[]
---@field GetComponentsInParent fun(self:Component, t:System.Type):Component[]
---@field GetComponentsInParent fun(self:Component, includeInactive:boolean):T[]
---@field GetComponentsInParent fun(self:Component, includeInactive:boolean, results:nil)
---@field GetComponentsInParent fun(self:Component):T[]
---@field GetComponents fun(self:Component, type:System.Type):Component[]
---@field GetComponents fun(self:Component, type:System.Type, results:System.Collections.Generic.List`1[[Component, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetComponents fun(self:Component, results:nil)
---@field GetComponents fun(self:Component):T[]
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
RawImage = {}
