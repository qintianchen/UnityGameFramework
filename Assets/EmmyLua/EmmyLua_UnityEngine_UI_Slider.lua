---@class UnityEngine.UI.Slider:UnityEngine.UI.Selectable
---@field fillRect UnityEngine.RectTransform
---@field handleRect UnityEngine.RectTransform
---@field direction UnityEngine.UI.Slider.Direction
---@field minValue number
---@field maxValue number
---@field wholeNumbers boolean
---@field value number
---@field normalizedValue number
---@field onValueChanged UnityEngine.UI.Slider.SliderEvent
---@field navigation UnityEngine.UI.Navigation
---@field transition UnityEngine.UI.Selectable.Transition
---@field colors UnityEngine.UI.ColorBlock
---@field spriteState UnityEngine.UI.SpriteState
---@field animationTriggers UnityEngine.UI.AnimationTriggers
---@field targetGraphic UnityEngine.UI.Graphic
---@field interactable boolean
---@field image UnityEngine.UI.Image
---@field animator UnityEngine.Animator
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
---@field SetValueWithoutNotify fun(input:number)
---@field Rebuild fun(executing:UnityEngine.UI.CanvasUpdate)
---@field LayoutComplete fun()
---@field GraphicUpdateComplete fun()
---@field OnPointerDown fun(eventData:UnityEngine.EventSystems.PointerEventData)
---@field OnDrag fun(eventData:UnityEngine.EventSystems.PointerEventData)
---@field OnMove fun(eventData:UnityEngine.EventSystems.AxisEventData)
---@field FindSelectableOnLeft fun():UnityEngine.UI.Selectable
---@field FindSelectableOnRight fun():UnityEngine.UI.Selectable
---@field FindSelectableOnUp fun():UnityEngine.UI.Selectable
---@field FindSelectableOnDown fun():UnityEngine.UI.Selectable
---@field OnInitializePotentialDrag fun(eventData:UnityEngine.EventSystems.PointerEventData)
---@field SetDirection fun(direction:UnityEngine.UI.Slider.Direction, includeRectLayouts:boolean)
---@field IsInteractable fun():boolean
---@field FindSelectable fun(dir:UnityEngine.Vector3):UnityEngine.UI.Selectable
---@field OnPointerUp fun(eventData:UnityEngine.EventSystems.PointerEventData)
---@field OnPointerEnter fun(eventData:UnityEngine.EventSystems.PointerEventData)
---@field OnPointerExit fun(eventData:UnityEngine.EventSystems.PointerEventData)
---@field OnSelect fun(eventData:UnityEngine.EventSystems.BaseEventData)
---@field OnDeselect fun(eventData:UnityEngine.EventSystems.BaseEventData)
---@field Select fun()
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
UnityEngine.UI.Slider = {}
