using System.Collections;
using UnityEngine;

public class GameMain : MonoBehaviour
{
	private IEnumerator Start()
	{
		Application.targetFrameRate = 30;
		
		// 日志系统初始化
		GameLogger.Instance.Init();
		
		// 资产管理器初始化
		yield return AssetManager.Instance.Init();
		
		// ToLua 初始化
		LuaMain.Instance.Init(this);

		// 执行主逻辑
		LuaMain.Instance.lua.DoFile("Main");
	}
}
