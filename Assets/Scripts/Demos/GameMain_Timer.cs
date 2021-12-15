﻿using System;
using System.Collections;
using QTC;
using QTC.Timer;
using UnityEngine;

public class GameMain_Timer : MonoBehaviour
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
        var timer = new Timer(5, () =>
        {
            var endTime = Time.unscaledTime;
            GameLogger.Info($"经历了 {endTime - startTime} s");
        }, t =>
        {
            GameLogger.Info($"更新 t = {t}");
        });
		
        timer.Start();

        yield return new WaitForSeconds(3);
        timer.Cancel();
    }
}
