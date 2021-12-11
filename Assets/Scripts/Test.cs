using System.Collections;
using System.Collections.Generic;
using QTC;
using UnityEngine;

public class Test : MonoBehaviour
{
	private IEnumerator Start ()
	{
		Application.targetFrameRate = 30;

		AssetManager.Instance.onInit = () =>
		{
			AssetManager.Instance.LoadAssetAsync<GameObject>("prefab_cube", go =>
			{
				// Debug.Log($"加载物体");
				// var go1 = GameObject.Instantiate(go);
				// var go2 = GameObject.Instantiate(go);
				//
				// gos.Add(go1);
				// gos.Add(go2);
				
				
				
				// StartCoroutine(DoSomething());
			});
		};
		StartCoroutine(AssetManager.Instance.Init());
		
		List<GameObject> gos = new List<GameObject>();
		var go1 = new GameObject("go1");
		var go2 = new GameObject("go2");
		var go3 = new GameObject("go2");
		var go4 = new GameObject("go2");
		gos.Add(go1);
		gos.Add(go2);
		gos.Add(go3);
		gos.Add(go4);

		yield return new WaitForSeconds(2);
		GameObject.Destroy(go2);
		GameObject.Destroy(go3);
		
		yield return null;

		Debug.Log(gos.Count);

		gos.RemoveAll(item => item == null);
		Debug.Log(gos.Count);

	}

	IEnumerator DoSomething()
	{
		// yield return new WaitForSeconds(2);
		
		
		// Debug.Log("卸载资源");
		// // AssetManager.Instance.UnLoadAssetBundle("content_environment_materials");
		// AssetManager.Instance.UnLoadAssetBundle("content_shaders");
		//
		// yield return new WaitForSeconds(2);
		// Debug.Log("等了两秒，又开始加载");
		//
		// AssetManager.Instance.LoadAssetAsync<GameObject>("prefab_cube", go =>
		// {
		// 	Debug.Log($"加载物体");
		// 	var newGo = GameObject.Instantiate(go);
		// });
		
		yield break;
	}
}
