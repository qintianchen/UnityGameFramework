---@class DG.Tweening.Tween:DG.Tweening.Core.ABSSequentiable
---@field isRelative boolean
---@field active boolean
---@field fullPosition number
---@field hasLoops boolean
---@field playedOnce boolean
---@field position number
---@field Equals fun(self:System.Object, obj:System.Object):boolean
---@field GetHashCode fun(self:System.Object):number
---@field GetType fun(self:System.Object):System.Type
---@field ToString fun(self:System.Object):string
---@field Complete fun(t:DG.Tweening.Tween)
---@field Complete fun(t:DG.Tweening.Tween, withCallbacks:boolean)
---@field Flip fun(t:DG.Tweening.Tween)
---@field ForceInit fun(t:DG.Tweening.Tween)
---@field Goto fun(t:DG.Tweening.Tween, to:number, andPlay:boolean)
---@field GotoWithCallbacks fun(t:DG.Tweening.Tween, to:number, andPlay:boolean)
---@field Kill fun(t:DG.Tweening.Tween, complete:boolean)
---@field ManualUpdate fun(t:DG.Tweening.Tween, deltaTime:number, unscaledDeltaTime:number)
---@field PlayBackwards fun(t:DG.Tweening.Tween)
---@field PlayForward fun(t:DG.Tweening.Tween)
---@field Restart fun(t:DG.Tweening.Tween, includeDelay:boolean, changeDelayTo:number)
---@field Rewind fun(t:DG.Tweening.Tween, includeDelay:boolean)
---@field SmoothRewind fun(t:DG.Tweening.Tween)
---@field TogglePause fun(t:DG.Tweening.Tween)
---@field GotoWaypoint fun(t:DG.Tweening.Tween, waypointIndex:number, andPlay:boolean)
---@field WaitForCompletion fun(t:DG.Tweening.Tween):YieldInstruction
---@field WaitForRewind fun(t:DG.Tweening.Tween):YieldInstruction
---@field WaitForKill fun(t:DG.Tweening.Tween):YieldInstruction
---@field WaitForElapsedLoops fun(t:DG.Tweening.Tween, elapsedLoops:number):YieldInstruction
---@field WaitForPosition fun(t:DG.Tweening.Tween, position:number):YieldInstruction
---@field WaitForStart fun(t:DG.Tweening.Tween):Coroutine
---@field CompletedLoops fun(t:DG.Tweening.Tween):number
---@field Delay fun(t:DG.Tweening.Tween):number
---@field ElapsedDelay fun(t:DG.Tweening.Tween):number
---@field Duration fun(t:DG.Tweening.Tween, includeLoops:boolean):number
---@field Elapsed fun(t:DG.Tweening.Tween, includeLoops:boolean):number
---@field ElapsedPercentage fun(t:DG.Tweening.Tween, includeLoops:boolean):number
---@field ElapsedDirectionalPercentage fun(t:DG.Tweening.Tween):number
---@field IsActive fun(t:DG.Tweening.Tween):boolean
---@field IsBackwards fun(t:DG.Tweening.Tween):boolean
---@field IsComplete fun(t:DG.Tweening.Tween):boolean
---@field IsInitialized fun(t:DG.Tweening.Tween):boolean
---@field IsPlaying fun(t:DG.Tweening.Tween):boolean
---@field Loops fun(t:DG.Tweening.Tween):number
---@field PathGetPoint fun(t:DG.Tweening.Tween, pathPercentage:number):Vector3
---@field PathGetDrawPoints fun(t:DG.Tweening.Tween, subdivisionsXSegment:number):Vector3[]
---@field PathLength fun(t:DG.Tweening.Tween):number
DG.Tweening.Tween = {}
