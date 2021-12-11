using System.Collections;
using QTC;
using UnityEngine;

public class Test : MonoBehaviour
{
	private void Start ()
	{
		Application.targetFrameRate = 30;

		AssetManager.Instance.onInit = () =>
		{
			AssetManager.Instance.LoadAssetAsync<GameObject>("prefab_cube", go =>
			{
				Debug.Log($"加载物体");
				var newGo = GameObject.Instantiate(go);
			
				// StartCoroutine(DoSomething());
			});
		};
		StartCoroutine(AssetManager.Instance.Init());
	}

	IEnumerator DoSomething()
	{
		yield return new WaitForSeconds(2);
		// Debug.Log("卸载资源");
		// AssetManager.Instance.UnLoadAssetBundle("content_environment_prefabs");

		// yield return new WaitForSeconds(2);
		Debug.Log("等了两秒，又开始加载");
		
		AssetManager.Instance.LoadAssetAsync<GameObject>("prefab_cube", go =>
		{
			Debug.Log($"加载物体");
			var newGo = GameObject.Instantiate(go);
			newGo.name = "bababa";
		});
	}
}
