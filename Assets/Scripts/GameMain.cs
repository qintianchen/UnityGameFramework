using System;
using System.Collections;
using LuaInterface;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMain : MonoBehaviour
{
	[HideInInspector] public bool isInited;
	
	private IEnumerator Start()
	{
		Application.targetFrameRate = 30;

		GameLogger.Instance.Init();
		yield return AssetManager.Instance.Init();
		
		LuaMain.Instance.Init(this);
		
		// LuaMain.Instance.lua.DoFile("Main");

		isInited = true;

		SceneManager.LoadScene("scene_test_timer");
	}
}
