---@class Material:Object
---@field shader Shader
---@field color Color
---@field mainTexture Texture
---@field mainTextureOffset Vector2
---@field mainTextureScale Vector2
---@field renderQueue number
---@field globalIlluminationFlags MaterialGlobalIlluminationFlags
---@field doubleSidedGI boolean
---@field enableInstancing boolean
---@field passCount number
---@field shaderKeywords System.String[]
---@field name string
---@field hideFlags HideFlags
---@field Create fun(scriptContents:string):Material
---@field HasProperty fun(self:Material, nameID:number):boolean
---@field HasProperty fun(self:Material, name:string):boolean
---@field EnableKeyword fun(self:Material, keyword:string)
---@field DisableKeyword fun(self:Material, keyword:string)
---@field IsKeywordEnabled fun(self:Material, keyword:string):boolean
---@field SetShaderPassEnabled fun(self:Material, passName:string, enabled:boolean)
---@field GetShaderPassEnabled fun(self:Material, passName:string):boolean
---@field GetPassName fun(self:Material, pass:number):string
---@field FindPass fun(self:Material, passName:string):number
---@field SetOverrideTag fun(self:Material, tag:string, val:string)
---@field GetTag fun(self:Material, tag:string, searchFallbacks:boolean, defaultValue:string):string
---@field GetTag fun(self:Material, tag:string, searchFallbacks:boolean):string
---@field Lerp fun(self:Material, start:Material, end:Material, t:number)
---@field SetPass fun(self:Material, pass:number):boolean
---@field CopyPropertiesFromMaterial fun(self:Material, mat:Material)
---@field ComputeCRC fun(self:Material):number
---@field GetTexturePropertyNames fun(self:Material):System.String[]
---@field GetTexturePropertyNameIDs fun(self:Material):System.Int32[]
---@field GetTexturePropertyNames fun(self:Material, outNames:System.Collections.Generic.List`1[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]])
---@field GetTexturePropertyNameIDs fun(self:Material, outNames:System.Collections.Generic.List`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]])
---@field SetFloat fun(self:Material, name:string, value:number)
---@field SetFloat fun(self:Material, nameID:number, value:number)
---@field SetInt fun(self:Material, name:string, value:number)
---@field SetInt fun(self:Material, nameID:number, value:number)
---@field SetColor fun(self:Material, name:string, value:Color)
---@field SetColor fun(self:Material, nameID:number, value:Color)
---@field SetVector fun(self:Material, name:string, value:Vector4)
---@field SetVector fun(self:Material, nameID:number, value:Vector4)
---@field SetMatrix fun(self:Material, name:string, value:Matrix4x4)
---@field SetMatrix fun(self:Material, nameID:number, value:Matrix4x4)
---@field SetTexture fun(self:Material, name:string, value:Texture)
---@field SetTexture fun(self:Material, nameID:number, value:Texture)
---@field SetTexture fun(self:Material, name:string, value:RenderTexture, element:Rendering.RenderTextureSubElement)
---@field SetTexture fun(self:Material, nameID:number, value:RenderTexture, element:Rendering.RenderTextureSubElement)
---@field SetBuffer fun(self:Material, name:string, value:ComputeBuffer)
---@field SetBuffer fun(self:Material, nameID:number, value:ComputeBuffer)
---@field SetBuffer fun(self:Material, name:string, value:GraphicsBuffer)
---@field SetBuffer fun(self:Material, nameID:number, value:GraphicsBuffer)
---@field SetConstantBuffer fun(self:Material, name:string, value:ComputeBuffer, offset:number, size:number)
---@field SetConstantBuffer fun(self:Material, nameID:number, value:ComputeBuffer, offset:number, size:number)
---@field SetConstantBuffer fun(self:Material, name:string, value:GraphicsBuffer, offset:number, size:number)
---@field SetConstantBuffer fun(self:Material, nameID:number, value:GraphicsBuffer, offset:number, size:number)
---@field SetFloatArray fun(self:Material, name:string, values:System.Collections.Generic.List`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]])
---@field SetFloatArray fun(self:Material, nameID:number, values:System.Collections.Generic.List`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]])
---@field SetFloatArray fun(self:Material, name:string, values:System.Single[])
---@field SetFloatArray fun(self:Material, nameID:number, values:System.Single[])
---@field SetColorArray fun(self:Material, name:string, values:System.Collections.Generic.List`1[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field SetColorArray fun(self:Material, nameID:number, values:System.Collections.Generic.List`1[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field SetColorArray fun(self:Material, name:string, values:Color[])
---@field SetColorArray fun(self:Material, nameID:number, values:Color[])
---@field SetVectorArray fun(self:Material, name:string, values:System.Collections.Generic.List`1[[Vector4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field SetVectorArray fun(self:Material, nameID:number, values:System.Collections.Generic.List`1[[Vector4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field SetVectorArray fun(self:Material, name:string, values:Vector4[])
---@field SetVectorArray fun(self:Material, nameID:number, values:Vector4[])
---@field SetMatrixArray fun(self:Material, name:string, values:System.Collections.Generic.List`1[[Matrix4x4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field SetMatrixArray fun(self:Material, nameID:number, values:System.Collections.Generic.List`1[[Matrix4x4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field SetMatrixArray fun(self:Material, name:string, values:Matrix4x4[])
---@field SetMatrixArray fun(self:Material, nameID:number, values:Matrix4x4[])
---@field GetFloat fun(self:Material, name:string):number
---@field GetFloat fun(self:Material, nameID:number):number
---@field GetInt fun(self:Material, name:string):number
---@field GetInt fun(self:Material, nameID:number):number
---@field GetColor fun(self:Material, name:string):Color
---@field GetColor fun(self:Material, nameID:number):Color
---@field GetVector fun(self:Material, name:string):Vector4
---@field GetVector fun(self:Material, nameID:number):Vector4
---@field GetMatrix fun(self:Material, name:string):Matrix4x4
---@field GetMatrix fun(self:Material, nameID:number):Matrix4x4
---@field GetTexture fun(self:Material, name:string):Texture
---@field GetTexture fun(self:Material, nameID:number):Texture
---@field GetFloatArray fun(self:Material, name:string):System.Single[]
---@field GetFloatArray fun(self:Material, nameID:number):System.Single[]
---@field GetColorArray fun(self:Material, name:string):Color[]
---@field GetColorArray fun(self:Material, nameID:number):Color[]
---@field GetVectorArray fun(self:Material, name:string):Vector4[]
---@field GetVectorArray fun(self:Material, nameID:number):Vector4[]
---@field GetMatrixArray fun(self:Material, name:string):Matrix4x4[]
---@field GetMatrixArray fun(self:Material, nameID:number):Matrix4x4[]
---@field GetFloatArray fun(self:Material, name:string, values:System.Collections.Generic.List`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]])
---@field GetFloatArray fun(self:Material, nameID:number, values:System.Collections.Generic.List`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]])
---@field GetColorArray fun(self:Material, name:string, values:System.Collections.Generic.List`1[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetColorArray fun(self:Material, nameID:number, values:System.Collections.Generic.List`1[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetVectorArray fun(self:Material, name:string, values:System.Collections.Generic.List`1[[Vector4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetVectorArray fun(self:Material, nameID:number, values:System.Collections.Generic.List`1[[Vector4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetMatrixArray fun(self:Material, name:string, values:System.Collections.Generic.List`1[[Matrix4x4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field GetMatrixArray fun(self:Material, nameID:number, values:System.Collections.Generic.List`1[[Matrix4x4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]])
---@field SetTextureOffset fun(self:Material, name:string, value:Vector2)
---@field SetTextureOffset fun(self:Material, nameID:number, value:Vector2)
---@field SetTextureScale fun(self:Material, name:string, value:Vector2)
---@field SetTextureScale fun(self:Material, nameID:number, value:Vector2)
---@field GetTextureOffset fun(self:Material, name:string):Vector2
---@field GetTextureOffset fun(self:Material, nameID:number):Vector2
---@field GetTextureScale fun(self:Material, name:string):Vector2
---@field GetTextureScale fun(self:Material, nameID:number):Vector2
---@field GetInstanceID fun(self:Object):number
---@field GetHashCode fun(self:Object):number
---@field Equals fun(self:Object, other:System.Object):boolean
---@field ToString fun(self:Object):string
---@field GetType fun(self:System.Object):System.Type
---@field DOColor fun(target:Material, endValue:Color, duration:number):DG.Tweening.Core.TweenerCore`3[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.ColorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOColor fun(target:Material, endValue:Color, property:string, duration:number):DG.Tweening.Core.TweenerCore`3[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.ColorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOColor fun(target:Material, endValue:Color, propertyID:number, duration:number):DG.Tweening.Core.TweenerCore`3[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.ColorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOFade fun(target:Material, endValue:number, duration:number):DG.Tweening.Core.TweenerCore`3[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.ColorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOFade fun(target:Material, endValue:number, property:string, duration:number):DG.Tweening.Core.TweenerCore`3[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.ColorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOFade fun(target:Material, endValue:number, propertyID:number, duration:number):DG.Tweening.Core.TweenerCore`3[[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Color, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.ColorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOFloat fun(target:Material, endValue:number, property:string, duration:number):DG.Tweening.Core.TweenerCore`3[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[DG.Tweening.Plugins.Options.FloatOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOFloat fun(target:Material, endValue:number, propertyID:number, duration:number):DG.Tweening.Core.TweenerCore`3[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[DG.Tweening.Plugins.Options.FloatOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOOffset fun(target:Material, endValue:Vector2, duration:number):DG.Tweening.Core.TweenerCore`3[[Vector2, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Vector2, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOOffset fun(target:Material, endValue:Vector2, property:string, duration:number):DG.Tweening.Core.TweenerCore`3[[Vector2, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Vector2, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOTiling fun(target:Material, endValue:Vector2, duration:number):DG.Tweening.Core.TweenerCore`3[[Vector2, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Vector2, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOTiling fun(target:Material, endValue:Vector2, property:string, duration:number):DG.Tweening.Core.TweenerCore`3[[Vector2, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Vector2, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOVector fun(target:Material, endValue:Vector4, property:string, duration:number):DG.Tweening.Core.TweenerCore`3[[Vector4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Vector4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOVector fun(target:Material, endValue:Vector4, propertyID:number, duration:number):DG.Tweening.Core.TweenerCore`3[[Vector4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[Vector4, CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
---@field DOBlendableColor fun(target:Material, endValue:Color, duration:number):DG.Tweening.Tweener
---@field DOBlendableColor fun(target:Material, endValue:Color, property:string, duration:number):DG.Tweening.Tweener
---@field DOBlendableColor fun(target:Material, endValue:Color, propertyID:number, duration:number):DG.Tweening.Tweener
---@field DOComplete fun(target:Material, withCallbacks:boolean):number
---@field DOKill fun(target:Material, complete:boolean):number
---@field DOFlip fun(target:Material):number
---@field DOGoto fun(target:Material, to:number, andPlay:boolean):number
---@field DOPause fun(target:Material):number
---@field DOPlay fun(target:Material):number
---@field DOPlayBackwards fun(target:Material):number
---@field DOPlayForward fun(target:Material):number
---@field DORestart fun(target:Material, includeDelay:boolean):number
---@field DORewind fun(target:Material, includeDelay:boolean):number
---@field DOSmoothRewind fun(target:Material):number
---@field DOTogglePause fun(target:Material):number
Material = {}
