---@class Empty4Raycast:UnityEngine.UI.MaskableGraphic
---@field onCullStateChanged UnityEngine.UI.MaskableGraphic.CullStateChangedEvent
---@field maskable boolean
---@field isMaskingGraphic boolean
---@field color UnityEngine.Color
---@field raycastTarget boolean
---@field raycastPadding UnityEngine.Vector4
---@field depth number
---@field rectTransform UnityEngine.RectTransform
---@field canvas UnityEngine.Canvas
---@field canvasRenderer UnityEngine.CanvasRenderer
---@field defaultMaterial UnityEngine.Material
---@field material UnityEngine.Material
---@field materialForRendering UnityEngine.Material
---@field mainTexture UnityEngine.Texture
---@field useGUILayout boolean
---@field runInEditMode boolean
---@field enabled boolean
---@field isActiveAndEnabled boolean
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
---@field GetModifiedMaterial fun(baseMaterial:UnityEngine.Material):UnityEngine.Material
---@field Cull fun(clipRect:UnityEngine.Rect, validRect:boolean)
---@field SetClipRect fun(clipRect:UnityEngine.Rect, validRect:boolean)
---@field SetClipSoftness fun(clipSoftness:UnityEngine.Vector2)
---@field ParentMaskStateChanged fun()
---@field RecalculateClipping fun()
---@field RecalculateMasking fun()
---@field SetAllDirty fun()
---@field SetLayoutDirty fun()
---@field SetVerticesDirty fun()
---@field SetMaterialDirty fun()
---@field OnCullingChanged fun()
---@field Rebuild fun(update:UnityEngine.UI.CanvasUpdate)
---@field LayoutComplete fun()
---@field GraphicUpdateComplete fun()
---@field OnRebuildRequested fun()
---@field SetNativeSize fun()
---@field Raycast fun(sp:UnityEngine.Vector2, eventCamera:UnityEngine.Camera):boolean
---@field PixelAdjustPoint fun(point:UnityEngine.Vector2):UnityEngine.Vector2
---@field GetPixelAdjustedRect fun():UnityEngine.Rect
---@field CrossFadeColor fun(targetColor:UnityEngine.Color, duration:number, ignoreTimeScale:boolean, useAlpha:boolean)
---@field CrossFadeColor fun(targetColor:UnityEngine.Color, duration:number, ignoreTimeScale:boolean, useAlpha:boolean, useRGB:boolean)
---@field CrossFadeAlpha fun(alpha:number, duration:number, ignoreTimeScale:boolean)
---@field RegisterDirtyLayoutCallback fun(action:UnityEngine.Events.UnityAction)
---@field UnregisterDirtyLayoutCallback fun(action:UnityEngine.Events.UnityAction)
---@field RegisterDirtyVerticesCallback fun(action:UnityEngine.Events.UnityAction)
---@field UnregisterDirtyVerticesCallback fun(action:UnityEngine.Events.UnityAction)
---@field RegisterDirtyMaterialCallback fun(action:UnityEngine.Events.UnityAction)
---@field UnregisterDirtyMaterialCallback fun(action:UnityEngine.Events.UnityAction)
---@field IsActive fun():boolean
---@field IsDestroyed fun():boolean
---@field IsInvoking fun():boolean
---@field CancelInvoke fun()
---@field Invoke fun(methodName:string, time:number)
---@field InvokeRepeating fun(methodName:string, time:number, repeatRate:number)
---@field CancelInvoke fun(methodName:string)
---@field IsInvoking fun(methodName:string):boolean
---@field StartCoroutine fun(methodName:string):UnityEngine.Coroutine
---@field StartCoroutine fun(methodName:string, value:System.Object):UnityEngine.Coroutine
---@field StartCoroutine fun(routine:System.Collections.IEnumerator):UnityEngine.Coroutine
---@field StartCoroutine_Auto fun(routine:System.Collections.IEnumerator):UnityEngine.Coroutine
---@field StopCoroutine fun(routine:System.Collections.IEnumerator)
---@field StopCoroutine fun(routine:UnityEngine.Coroutine)
---@field StopCoroutine fun(methodName:string)
---@field StopAllCoroutines fun()
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
Empty4Raycast = {}
