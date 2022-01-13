---@class Slider:Selectable
---@field fillRect RectTransform
---@field handleRect RectTransform
---@field direction Slider.Direction
---@field minValue number
---@field maxValue number
---@field wholeNumbers boolean
---@field value number
---@field normalizedValue number
---@field onValueChanged Slider.SliderEvent
---@field navigation Navigation
---@field transition Selectable.Transition
---@field colors ColorBlock
---@field spriteState SpriteState
---@field animationTriggers AnimationTriggers
---@field targetGraphic Graphic
---@field interactable boolean
---@field image Image
---@field animator Animator
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
---@field SetValueWithoutNotify fun(self:Slider, input:number)
---@field Rebuild fun(self:Slider, executing:CanvasUpdate)
---@field LayoutComplete fun(self:Slider)
---@field GraphicUpdateComplete fun(self:Slider)
---@field OnPointerDown fun(self:Slider, eventData:EventSystems.PointerEventData)
---@field OnDrag fun(self:Slider, eventData:EventSystems.PointerEventData)
---@field OnMove fun(self:Slider, eventData:EventSystems.AxisEventData)
---@field FindSelectableOnLeft fun(self:Slider):Selectable
---@field FindSelectableOnRight fun(self:Slider):Selectable
---@field FindSelectableOnUp fun(self:Slider):Selectable
---@field FindSelectableOnDown fun(self:Slider):Selectable
---@field OnInitializePotentialDrag fun(self:Slider, eventData:EventSystems.PointerEventData)
---@field SetDirection fun(self:Slider, direction:Slider.Direction, includeRectLayouts:boolean)
---@field IsInteractable fun(self:Selectable):boolean
---@field FindSelectable fun(self:Selectable, dir:Vector3):Selectable
---@field OnPointerUp fun(self:Selectable, eventData:EventSystems.PointerEventData)
---@field OnPointerEnter fun(self:Selectable, eventData:EventSystems.PointerEventData)
---@field OnPointerExit fun(self:Selectable, eventData:EventSystems.PointerEventData)
---@field OnSelect fun(self:Selectable, eventData:EventSystems.BaseEventData)
---@field OnDeselect fun(self:Selectable, eventData:EventSystems.BaseEventData)
---@field Select fun(self:Selectable)
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
Slider = {}
