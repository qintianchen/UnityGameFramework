using System.Collections;
using QTC;
using UnityEngine;
using Logger = QTC.Logger;

public class GameMain : MonoBehaviour
{
	private IEnumerator Start()
	{
		Application.targetFrameRate = 30;
		Logger.Instance.Init();
		yield return AssetManager.Instance.Init();
	}
}
