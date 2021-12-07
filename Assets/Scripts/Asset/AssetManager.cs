using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Object = UnityEngine.Object;

public class AssetManager : SingleTon<AssetManager>
{
	public enum AssetMode
	{
		AssetBundle,
		AssetDataBase
	}

	public AssetMode assetModeInEditor = AssetMode.AssetDataBase;
	public Dictionary<string, string> assetName_assetPath;
	
	public void Init()
	{
		InitAssetNameMap();
		AssetTicker.Instance.onUpdate += Update;
	}

	private void InitAssetNameMap()
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
		
	}

	private void InitAssetNameMapInAssetDataBaseMode()
	{
		foreach (var assetDir in AssetBundleBuilder.assetDirs)
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
		// Debug.Log($"FrameCount = {Time.frameCount}");
	}

	public T LoadAssetAsync<T>(string assetName, Action<T> onLoaded) where T : Object
	{
		return null;
	}
}