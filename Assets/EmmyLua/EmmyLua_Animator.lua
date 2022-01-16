---@class Animator:Behaviour
---@field isOptimizable boolean
---@field isHuman boolean
---@field hasRootMotion boolean
---@field humanScale number
---@field isInitialized boolean
---@field deltaPosition Vector3
---@field deltaRotation Quaternion
---@field velocity Vector3
---@field angularVelocity Vector3
---@field rootPosition Vector3
---@field rootRotation Quaternion
---@field applyRootMotion boolean
---@field linearVelocityBlending boolean
---@field animatePhysics boolean
---@field updateMode AnimatorUpdateMode
---@field hasTransformHierarchy boolean
---@field gravityWeight number
---@field bodyPosition Vector3
---@field bodyRotation Quaternion
---@field stabilizeFeet boolean
---@field layerCount number
---@field parameters AnimatorControllerParameter[]
---@field parameterCount number
---@field feetPivotActive number
---@field pivotWeight number
---@field pivotPosition Vector3
---@field isMatchingTarget boolean
---@field speed number
---@field targetPosition Vector3
---@field targetRotation Quaternion
---@field cullingMode AnimatorCullingMode
---@field playbackTime number
---@field recorderStartTime number
---@field recorderStopTime number
---@field recorderMode AnimatorRecorderMode
---@field runtimeAnimatorController RuntimeAnimatorController
---@field hasBoundPlayables boolean
---@field avatar Avatar
---@field playableGraph Playables.PlayableGraph
---@field layersAffectMassCenter boolean
---@field leftFeetBottomHeight number
---@field rightFeetBottomHeight number
---@field logWarnings boolean
---@field fireEvents boolean
---@field keepAnimatorControllerStateOnDisable boolean
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
---@field GetCurrentAnimationClipState fun(self:Animator, layerIndex:number):AnimationInfo[]
---@field GetNextAnimationClipState fun(self:Animator, layerIndex:number):AnimationInfo[]
---@field Stop fun(self:Animator)
---@field GetFloat fun(self:Animator, name:string):number
---@field GetFloat fun(self:Animator, id:number):number
---@field SetFloat fun(self:Animator, name:string, value:number)
---@field SetFloat fun(self:Animator, name:string, value:number, dampTime:number, deltaTime:number)
---@field SetFloat fun(self:Animator, id:number, value:number)
---@field SetFloat fun(self:Animator, id:number, value:number, dampTime:number, deltaTime:number)
---@field GetBool fun(self:Animator, name:string):boolean
---@field GetBool fun(self:Animator, id:number):boolean
---@field SetBool fun(self:Animator, name:string, value:boolean)
---@field SetBool fun(self:Animator, id:number, value:boolean)
---@field GetInteger fun(self:Animator, name:string):number
---@field GetInteger fun(self:Animator, id:number):number
---@field SetInteger fun(self:Animator, name:string, value:number)
---@field SetInteger fun(self:Animator, id:number, value:number)
---@field SetTrigger fun(self:Animator, name:string)
---@field SetTrigger fun(self:Animator, id:number)
---@field ResetTrigger fun(self:Animator, name:string)
---@field ResetTrigger fun(self:Animator, id:number)
---@field IsParameterControlledByCurve fun(self:Animator, name:string):boolean
---@field IsParameterControlledByCurve fun(self:Animator, id:number):boolean
---@field GetIKPosition fun(self:Animator, goal:AvatarIKGoal):Vector3
---@field SetIKPosition fun(self:Animator, goal:AvatarIKGoal, goalPosition:Vector3)
---@field GetIKRotation fun(self:Animator, goal:AvatarIKGoal):Quaternion
---@field SetIKRotation fun(self:Animator, goal:AvatarIKGoal, goalRotation:Quaternion)
---@field GetIKPositionWeight fun(self:Animator, goal:AvatarIKGoal):number
---@field SetIKPositionWeight fun(self:Animator, goal:AvatarIKGoal, value:number)
---@field GetIKRotationWeight fun(self:Animator, goal:AvatarIKGoal):number
---@field SetIKRotationWeight fun(self:Animator, goal:AvatarIKGoal, value:number)
---@field GetIKHintPosition fun(self:Animator, hint:AvatarIKHint):Vector3
---@field SetIKHintPosition fun(self:Animator, hint:AvatarIKHint, hintPosition:Vector3)
---@field GetIKHintPositionWeight fun(self:Animator, hint:AvatarIKHint):number
---@field SetIKHintPositionWeight fun(self:Animator, hint:AvatarIKHint, value:number)
---@field SetLookAtPosition fun(self:Animator, lookAtPosition:Vector3)
---@field SetLookAtWeight fun(self:Animator, weight:number)
---@field SetLookAtWeight fun(self:Animator, weight:number, bodyWeight:number)
---@field SetLookAtWeight fun(self:Animator, weight:number, bodyWeight:number, headWeight:number)
---@field SetLookAtWeight fun(self:Animator, weight:number, bodyWeight:number, headWeight:number, eyesWeight:number)
---@field SetLookAtWeight fun(self:Animator, weight:number, bodyWeight:number, headWeight:number, eyesWeight:number, clampWeight:number)
---@field SetBoneLocalRotation fun(self:Animator, humanBoneId:HumanBodyBones, rotation:Quaternion)
---@field GetBehaviour fun(self:Animator):nil
---@field GetBehaviours fun(self:Animator):nil
---@field GetBehaviours fun(self:Animator, fullPathHash:number, layerIndex:number):StateMachineBehaviour[]
---@field GetLayerName fun(self:Animator, layerIndex:number):string
---@field GetLayerIndex fun(self:Animator, layerName:string):number
---@field GetLayerWeight fun(self:Animator, layerIndex:number):number
---@field SetLayerWeight fun(self:Animator, layerIndex:number, weight:number)
---@field GetCurrentAnimatorStateInfo fun(self:Animator, layerIndex:number):AnimatorStateInfo
---@field GetNextAnimatorStateInfo fun(self:Animator, layerIndex:number):AnimatorStateInfo
---@field GetAnimatorTransitionInfo fun(self:Animator, layerIndex:number):AnimatorTransitionInfo
---@field GetCurrentAnimatorClipInfoCount fun(self:Animator, layerIndex:number):number
---@field GetNextAnimatorClipInfoCount fun(self:Animator, layerIndex:number):number
---@field GetCurrentAnimatorClipInfo fun(self:Animator, layerIndex:number):AnimatorClipInfo[]
---@field GetNextAnimatorClipInfo fun(self:Animator, layerIndex:number):AnimatorClipInfo[]
---@field GetCurrentAnimatorClipInfo fun(self:Animator, layerIndex:number, clips:System.Collections.Generic.List`1[[AnimatorClipInfo, AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetNextAnimatorClipInfo fun(self:Animator, layerIndex:number, clips:System.Collections.Generic.List`1[[AnimatorClipInfo, AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field IsInTransition fun(self:Animator, layerIndex:number):boolean
---@field GetParameter fun(self:Animator, index:number):AnimatorControllerParameter
---@field MatchTarget fun(self:Animator, matchPosition:Vector3, matchRotation:Quaternion, targetBodyPart:AvatarTarget, weightMask:MatchTargetWeightMask, startNormalizedTime:number)
---@field MatchTarget fun(self:Animator, matchPosition:Vector3, matchRotation:Quaternion, targetBodyPart:AvatarTarget, weightMask:MatchTargetWeightMask, startNormalizedTime:number, targetNormalizedTime:number)
---@field MatchTarget fun(self:Animator, matchPosition:Vector3, matchRotation:Quaternion, targetBodyPart:AvatarTarget, weightMask:MatchTargetWeightMask, startNormalizedTime:number, targetNormalizedTime:number, completeMatch:boolean)
---@field InterruptMatchTarget fun(self:Animator)
---@field InterruptMatchTarget fun(self:Animator, completeMatch:boolean)
---@field ForceStateNormalizedTime fun(self:Animator, normalizedTime:number)
---@field CrossFadeInFixedTime fun(self:Animator, stateName:string, fixedTransitionDuration:number)
---@field CrossFadeInFixedTime fun(self:Animator, stateName:string, fixedTransitionDuration:number, layer:number)
---@field CrossFadeInFixedTime fun(self:Animator, stateName:string, fixedTransitionDuration:number, layer:number, fixedTimeOffset:number)
---@field CrossFadeInFixedTime fun(self:Animator, stateName:string, fixedTransitionDuration:number, layer:number, fixedTimeOffset:number, normalizedTransitionTime:number)
---@field CrossFadeInFixedTime fun(self:Animator, stateHashName:number, fixedTransitionDuration:number, layer:number, fixedTimeOffset:number)
---@field CrossFadeInFixedTime fun(self:Animator, stateHashName:number, fixedTransitionDuration:number, layer:number)
---@field CrossFadeInFixedTime fun(self:Animator, stateHashName:number, fixedTransitionDuration:number)
---@field CrossFadeInFixedTime fun(self:Animator, stateHashName:number, fixedTransitionDuration:number, layer:number, fixedTimeOffset:number, normalizedTransitionTime:number)
---@field WriteDefaultValues fun(self:Animator)
---@field CrossFade fun(self:Animator, stateName:string, normalizedTransitionDuration:number, layer:number, normalizedTimeOffset:number)
---@field CrossFade fun(self:Animator, stateName:string, normalizedTransitionDuration:number, layer:number)
---@field CrossFade fun(self:Animator, stateName:string, normalizedTransitionDuration:number)
---@field CrossFade fun(self:Animator, stateName:string, normalizedTransitionDuration:number, layer:number, normalizedTimeOffset:number, normalizedTransitionTime:number)
---@field CrossFade fun(self:Animator, stateHashName:number, normalizedTransitionDuration:number, layer:number, normalizedTimeOffset:number, normalizedTransitionTime:number)
---@field CrossFade fun(self:Animator, stateHashName:number, normalizedTransitionDuration:number, layer:number, normalizedTimeOffset:number)
---@field CrossFade fun(self:Animator, stateHashName:number, normalizedTransitionDuration:number, layer:number)
---@field CrossFade fun(self:Animator, stateHashName:number, normalizedTransitionDuration:number)
---@field PlayInFixedTime fun(self:Animator, stateName:string, layer:number)
---@field PlayInFixedTime fun(self:Animator, stateName:string)
---@field PlayInFixedTime fun(self:Animator, stateName:string, layer:number, fixedTime:number)
---@field PlayInFixedTime fun(self:Animator, stateNameHash:number, layer:number, fixedTime:number)
---@field PlayInFixedTime fun(self:Animator, stateNameHash:number, layer:number)
---@field PlayInFixedTime fun(self:Animator, stateNameHash:number)
---@field Play fun(self:Animator, stateName:string, layer:number)
---@field Play fun(self:Animator, stateName:string)
---@field Play fun(self:Animator, stateName:string, layer:number, normalizedTime:number)
---@field Play fun(self:Animator, stateNameHash:number, layer:number, normalizedTime:number)
---@field Play fun(self:Animator, stateNameHash:number, layer:number)
---@field Play fun(self:Animator, stateNameHash:number)
---@field SetTarget fun(self:Animator, targetIndex:AvatarTarget, targetNormalizedTime:number)
---@field IsControlled fun(self:Animator, transform:Transform):boolean
---@field GetBoneTransform fun(self:Animator, humanBoneId:HumanBodyBones):Transform
---@field StartPlayback fun(self:Animator)
---@field StopPlayback fun(self:Animator)
---@field StartRecording fun(self:Animator, frameCount:number)
---@field StopRecording fun(self:Animator)
---@field HasState fun(self:Animator, layerIndex:number, stateID:number):boolean
---@field StringToHash fun(name:string):number
---@field Update fun(self:Animator, deltaTime:number)
---@field Rebind fun(self:Animator)
---@field ApplyBuiltinRootMotion fun(self:Animator)
---@field GetVector fun(self:Animator, name:string):Vector3
---@field GetVector fun(self:Animator, id:number):Vector3
---@field SetVector fun(self:Animator, name:string, value:Vector3)
---@field SetVector fun(self:Animator, id:number, value:Vector3)
---@field GetQuaternion fun(self:Animator, name:string):Quaternion
---@field GetQuaternion fun(self:Animator, id:number):Quaternion
---@field SetQuaternion fun(self:Animator, name:string, value:Quaternion)
---@field SetQuaternion fun(self:Animator, id:number, value:Quaternion)
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
Animator = {}
