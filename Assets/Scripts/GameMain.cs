using System;
using System.Collections;
using LuaInterface;
using UnityEngine;

public class GameMain : MonoBehaviour
{
	[HideInInspector] public bool isInited;
	
	private IEnumerator Start()
	{
		Application.targetFrameRate = 30;

		GameLogger.Instance.Init();
		yield return AssetManager.Instance.Init();
		
		LuaMain.Instance.Init(this);

		isInited = true;
	}

	private void Update()
	{
		if(isInited)
			LuaMain.Instance.lua.Call("UIManagerUpdate", false);
	}
}
