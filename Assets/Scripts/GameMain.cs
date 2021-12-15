using System;
using System.Collections;
using QTC;
using QTC.Timer;
using UnityEngine;

public class GameMain : MonoBehaviour
{
	private IEnumerator Start()
	{
		// 设置帧率
		Application.targetFrameRate = 30;
		
		// 日志模块初始化
		GameLogger.Instance.Init();
		
		// 资源管理器初始化
		yield return AssetManager.Instance.Init();

		yield return new WaitForSeconds(3);
		
		// 定时器测试
		var startTime = Time.unscaledTime;
		var count = 0;
		var timer = new Timer(10, () =>
		{
			var endTime = Time.unscaledTime;
			GameLogger.Info($"经历了 {endTime - startTime} s");
		}, t =>
		{
			count++;
			GameLogger.Info($"更新, count = {count}, {t}");
		});
		
		timer.Start();
	}
}
