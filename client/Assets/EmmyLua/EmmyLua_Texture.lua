---@class Texture:Object
---@field masterTextureLimit number
---@field mipmapCount number
---@field anisotropicFiltering AnisotropicFiltering
---@field graphicsFormat Experimental.Rendering.GraphicsFormat
---@field width number
---@field height number
---@field dimension Rendering.TextureDimension
---@field isReadable boolean
---@field wrapMode TextureWrapMode
---@field wrapModeU TextureWrapMode
---@field wrapModeV TextureWrapMode
---@field wrapModeW TextureWrapMode
---@field filterMode FilterMode
---@field anisoLevel number
---@field mipMapBias number
---@field texelSize Vector2
---@field updateCount System.UInt32
---@field imageContentsHash Hash128
---@field totalTextureMemory number
---@field desiredTextureMemory number
---@field targetTextureMemory number
---@field currentTextureMemory number
---@field nonStreamingTextureMemory number
---@field streamingMipmapUploadCount number
---@field streamingRendererCount number
---@field streamingTextureCount number
---@field nonStreamingTextureCount number
---@field streamingTexturePendingLoadCount number
---@field streamingTextureLoadingCount number
---@field streamingTextureForceLoadAll boolean
---@field streamingTextureDiscardUnusedMips boolean
---@field allowThreadedTextureCreation boolean
---@field name string
---@field hideFlags HideFlags
---@field SetGlobalAnisotropicFilteringLimits fun(forcedMin:number, globalMax:number)
---@field GetNativeTexturePtr fun(self:Texture):System.IntPtr
---@field GetNativeTextureID fun(self:Texture):number
---@field IncrementUpdateCount fun(self:Texture)
---@field SetStreamingTextureMaterialDebugProperties fun()
---@field GetInstanceID fun(self:Object):number
---@field GetHashCode fun(self:Object):number
---@field Equals fun(self:Object, other:System.Object):boolean
---@field ToString fun(self:Object):string
---@field GetType fun(self:System.Object):System.Type
Texture = {}
