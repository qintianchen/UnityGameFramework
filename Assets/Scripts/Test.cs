using QTC;
using UnityEngine;
using Logger = QTC.Logger;

public class Test : MonoBehaviour
{
	private void Start()
	{
		Application.targetFrameRate = 30;
		Logger.Instance.Init();
		
		StartCoroutine(AssetManager.Instance.Init());
	}
}
