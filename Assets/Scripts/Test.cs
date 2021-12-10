using UnityEngine;

public class Test : MonoBehaviour
{
	private void Start ()
	{
		Application.targetFrameRate = 30;

		AssetManager.Instance.onInit = () =>
		{
			Debug.Log($"onInit");
			AssetManager.Instance.LoadAssetAsync<GameObject>("prefab_cube", go =>
			{
				Debug.Log($"加载物体");
				var newGo = GameObject.Instantiate(go);
			});
		};
		StartCoroutine(AssetManager.Instance.Init());
	}
}
