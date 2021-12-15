using System;
using System.Collections;
using Newtonsoft.Json;
using QTC;
using UnityEngine;

public class GameMain : MonoBehaviour
{
	private Action ac;

	private IEnumerator Start()
	{
		// 设置帧率
		Application.targetFrameRate = 30;
		
		// 日志模块初始化
		GameLogger.Instance.Init();
		
		// 资源管理器初始化
		yield return AssetManager.Instance.Init();
	}
}
