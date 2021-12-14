using System.Collections;
using QTC;
using UnityEngine;
using Logger = QTC.Logger;

public class Test : MonoBehaviour
{
	private GameObject go;
	private GameObject go2;
	
	private void Start()
	{
		Application.targetFrameRate = 30;
		Logger.Instance.Init();

		AssetManager.Instance.onInit += () =>
		{
			StartCoroutine(T1());
		};
		StartCoroutine(AssetManager.Instance.Init());
	}

	private IEnumerator T1()
	{
		yield return null;

		Debug.Log($"生成父节点");
		go = new GameObject("parent");
		go2 = new GameObject("parent2");
		Debug.Log($"开始加载预置体");
		AssetManager.Instance.LoadAssetAsync<GameObject>("prefab_cube", go, goo =>
		{
			// Debug.Log($"加载完成: {AssetManager.Instance.GetLoadedAssetBundlesInfo()}");

			Debug.Log($"1111111111111");
			
			AssetManager.Instance.LoadAssetAsync<GameObject>("prefab_sphere", go2, gooo =>
			{
				Debug.Log($"加载完成: {AssetManager.Instance.GetLoadedAssetBundlesInfo()}");
			
				StartCoroutine(T2());
			});
		});
		
		
	}

	private IEnumerator T2()
	{
		Debug.Log($"启动协程");
		yield return new WaitForSeconds(1);
		AssetManager.Instance.UnloadAllUnusedAssetBundle();
		Debug.Log($"卸载资源 {AssetManager.Instance.GetLoadedAssetBundlesInfo()}");
		
		GameObject.Destroy(go);

		yield return null;
		
		AssetManager.Instance.UnloadAllUnusedAssetBundle();
		Debug.Log($"卸载资源 {AssetManager.Instance.GetLoadedAssetBundlesInfo()}");
	}
}
