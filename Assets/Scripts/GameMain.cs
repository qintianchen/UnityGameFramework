using System.Collections;
using UnityEngine;

public class GameMain : MonoBehaviour
{
	private IEnumerator Start()
	{
		Application.targetFrameRate = 30;

		GameLogger.Instance.Init();
		yield return AssetManager.Instance.Init();
		
		LuaMain.Instance.Init(this);
	}
}
