---@class UnityEngine.UIElements.ScrollView:UnityEngine.UIElements.VisualElement
---@field showHorizontal boolean
---@field showVertical boolean
---@field scrollOffset UnityEngine.Vector2
---@field horizontalPageSize number
---@field verticalPageSize number
---@field scrollDecelerationRate number
---@field elasticity number
---@field touchScrollBehavior UnityEngine.UIElements.ScrollView.TouchScrollBehavior
---@field contentViewport UnityEngine.UIElements.VisualElement
---@field horizontalScroller UnityEngine.UIElements.Scroller
---@field verticalScroller UnityEngine.UIElements.Scroller
---@field contentContainer UnityEngine.UIElements.VisualElement
---@field viewDataKey string
---@field userData System.Object
---@field canGrabFocus boolean
---@field focusController UnityEngine.UIElements.FocusController
---@field usageHints UnityEngine.UIElements.UsageHints
---@field transform UnityEngine.UIElements.ITransform
---@field layout UnityEngine.Rect
---@field contentRect UnityEngine.Rect
---@field worldBound UnityEngine.Rect
---@field localBound UnityEngine.Rect
---@field worldTransform UnityEngine.Matrix4x4
---@field pickingMode UnityEngine.UIElements.PickingMode
---@field name string
---@field enabledInHierarchy boolean
---@field enabledSelf boolean
---@field visible boolean
---@field generateVisualContent any
---@field experimental UnityEngine.UIElements.IExperimentalFeatures
---@field hierarchy UnityEngine.UIElements.VisualElement.Hierarchy
---@field cacheAsBitmap boolean
---@field parent UnityEngine.UIElements.VisualElement
---@field panel UnityEngine.UIElements.IPanel
---@field Item UnityEngine.UIElements.VisualElement
---@field childCount number
---@field schedule UnityEngine.UIElements.IVisualElementScheduler
---@field style UnityEngine.UIElements.IStyle
---@field customStyle UnityEngine.UIElements.ICustomStyle
---@field styleSheets UnityEngine.UIElements.VisualElementStyleSheetSet
---@field tooltip string
---@field resolvedStyle UnityEngine.UIElements.IResolvedStyle
---@field focusable boolean
---@field tabIndex number
---@field delegatesFocus boolean
---@field ScrollTo fun(child:UnityEngine.UIElements.VisualElement)
---@field Focus fun()
---@field SendEvent fun(e:UnityEngine.UIElements.EventBase)
---@field SetEnabled fun(value:boolean)
---@field MarkDirtyRepaint fun()
---@field ContainsPoint fun(localPoint:UnityEngine.Vector2):boolean
---@field Overlaps fun(rectangle:UnityEngine.Rect):boolean
---@field ToString fun():string
---@field ClearClassList fun()
---@field AddToClassList fun(className:string)
---@field RemoveFromClassList fun(className:string)
---@field ToggleInClassList fun(className:string)
---@field EnableInClassList fun(className:string, enable:boolean)
---@field ClassListContains fun(cls:string):boolean
---@field FindAncestorUserData fun():System.Object
---@field Add fun(child:UnityEngine.UIElements.VisualElement)
---@field Insert fun(index:number, element:UnityEngine.UIElements.VisualElement)
---@field Remove fun(element:UnityEngine.UIElements.VisualElement)
---@field RemoveAt fun(index:number)
---@field Clear fun()
---@field ElementAt fun(index:number):UnityEngine.UIElements.VisualElement
---@field IndexOf fun(element:UnityEngine.UIElements.VisualElement):number
---@field BringToFront fun()
---@field SendToBack fun()
---@field PlaceBehind fun(sibling:UnityEngine.UIElements.VisualElement)
---@field PlaceInFront fun(sibling:UnityEngine.UIElements.VisualElement)
---@field RemoveFromHierarchy fun()
---@field GetFirstOfType fun():nil
---@field GetFirstAncestorOfType fun():nil
---@field Contains fun(child:UnityEngine.UIElements.VisualElement):boolean
---@field FindCommonAncestor fun(other:UnityEngine.UIElements.VisualElement):UnityEngine.UIElements.VisualElement
---@field Blur fun()
---@field HandleEvent fun(evt:UnityEngine.UIElements.EventBase)
---@field HasTrickleDownHandlers fun():boolean
---@field HasBubbleUpHandlers fun():boolean
---@field Equals fun(obj:System.Object):boolean
---@field GetHashCode fun():number
---@field GetType fun():System.Type
UnityEngine.UIElements.ScrollView = {}
