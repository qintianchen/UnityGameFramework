using System.Collections;
using System.Collections.Generic;
using QTC;
using UnityEngine;

public class GameMain_AssetManager : MonoBehaviour
{
    IEnumerator Start()
    {
        Application.targetFrameRate = 30;
        yield return AssetManager.Instance.Init();

        // 加载一个名为 prefab_cube 的GameObject
        AssetManager.Instance.LoadAssetAsync<GameObject>("prefab_cube", this, go =>
        {
            var newGo = Instantiate(go);
            newGo.name = go.name;
        });
        
        // 卸载所有未被引用的AssetBundle
        AssetManager.Instance.UnloadAllUnusedAssetBundle();
        
        // 打印所有已经加载了的AssetBundle信息
        Debug.Log($"Loaded AssetBundle: {AssetManager.Instance.GetLoadedAssetBundlesInfo()}");
    }
}
