using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

public class AssetManager : SingleTon<AssetManager>
{
	public enum AssetMode
	{
		AssetBundle,
		AssetDataBase
	}
	
	/// 定义哪些是合法的资源加载目录
	public List<string> assetDirs = new List<string>
	{
		"Assets/Content/Environment/Prefabs"
	};
	
	/// 指示编辑器使用AssetBundleMode，否则默认走AssetDataBase机制
	public AssetMode assetModeInEditor = AssetMode.AssetDataBase;

	public Dictionary<string, string> assetName_assetPath;

	public void Init()
	{
		InitAssetNameMap();
		AssetTicker.Instance.onUpdate += Update;
	}

	public void InitAssetNameMap()
	{
		assetName_assetPath = new Dictionary<string, string>();
#if UNITY_EDITOR
		if (assetModeInEditor == AssetMode.AssetBundle)
		{
			InitAssetNameMapInAssetBundleMode();
		}
		else
		{
			InitAssetNameMapInAssetDataBaseMode();
		}
#else
		InitAssetNameMapInAssetBundle();
#endif
		foreach (var keyValuePair in assetName_assetPath)
		{
			Debug.Log($"{keyValuePair.Key}:{keyValuePair.Value}");
		}
	}

	private void InitAssetNameMapInAssetBundleMode()
	{
		// 
	}

	private void InitAssetNameMapInAssetDataBaseMode()
	{
		foreach (var assetDir in assetDirs)
		{
			var files = Directory.GetFiles(assetDir);
			foreach (var file in files)
			{
				var ext = Path.GetExtension(file);
				var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
				if (ext.Equals(".meta"))
				{
					continue;
				}

				assetName_assetPath[fileNameWithoutExtension] = file.Replace("\\", "/");
			}
		}
	}

	private void Update()
	{
		
	}

	public void LoadAssetAsync<T>(string assetName, Action<T> onLoaded) where T : Object
	{
#if UNITY_EDITOR
		if (assetModeInEditor == AssetMode.AssetDataBase)
		{
			if (!assetName_assetPath.TryGetValue(assetName, out var assetPath))
			{
				Debug.LogError($"无法找到资源:{assetName}");
				return;
			}

			T asset = AssetDatabase.LoadAssetAtPath<T>(assetPath);
			if (asset == null)
			{
				Debug.LogError($"无法正确加载资源：assetPath = {assetPath}, type = {typeof(T).Name}");
				return;
			}

			onLoaded(asset);
		}
		else
		{
			return;
		}
#else
		return null;
#endif
	}
}