using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace QTC
{
    // 这是给Lua导出的加载接口，目前只认为导出异步接口就够了
    public partial class AssetManager: SingleTon<AssetManager>
    {
        public enum AssetType
        {
            UnityObject,
            GameObject,
            Material,
            Sprite,
            Texture,
            AnimationClip,
            VideoClip,
            Scene,
            TextAsset,
        }
        
        public void LoadAssetAsync(string assetName, AssetType assetType, Object objRef, Action<Object> onLoaded)
        {
            switch (assetType)
            {
                case AssetType.UnityObject:
                    LoadAssetAsync<Object>(assetName, objRef, onLoaded);
                    break;
                case AssetType.GameObject:
                    LoadAssetAsync<GameObject>(assetName, objRef, onLoaded);
                    break;
                case AssetType.Material:
                    LoadAssetAsync<Material>(assetName, objRef, onLoaded);
                    break;
                case AssetType.Sprite:
                    LoadAssetAsync<Sprite>(assetName, objRef, onLoaded);
                    break;
                case AssetType.Texture:
                    LoadAssetAsync<Texture>(assetName, objRef, onLoaded);
                    break;
                case AssetType.AnimationClip:
                    LoadAssetAsync<Texture>(assetName, objRef, onLoaded);
                    break;
                case AssetType.VideoClip:
                    LoadAssetAsync<Texture>(assetName, objRef, onLoaded);
                    break;
                case AssetType.Scene:
                    LoadAssetAsync<Texture>(assetName, objRef, onLoaded);
                    break;
                case AssetType.TextAsset:
                    LoadAssetAsync<TextAsset>(assetName, objRef, onLoaded);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(assetType), assetType, null);
            }
        }
    }
}