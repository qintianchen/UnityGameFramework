using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using Object = UnityEngine.Object;
using SerializationHelper;

public class AssetManager : SingleTon<AssetManager>
{
	#region 属性
	public enum AssetMode
	{
		AssetBundle,
		AssetDataBase
	}
	public List<string> assetDirs = new List<string> // 定义哪些是合法的资源加载目录
	{
		"Assets/Content/Environment/Prefabs",
		"Assets/Content/Scenes",
	};
	
	public AssetMode assetModeInEditor = AssetMode.AssetBundle; // 指示编辑器使用AssetBundleMode，否则默认走AssetDataBase机制
	public Dictionary<string, string> assetName_assetPath; // 资源名字和资源路径的对应关系
	public Dictionary<string, string> assetName_assetBundleName; // 资源名字和资源路径的对应关系
	public Dictionary<string, AssetBundleCreateRequestWrap> assetBundleName_loadingAssetBundle; // 正在加载的AssetBundle
	public Dictionary<string, AssetBundleRequestWrap> assetName_loadingAsset; // 正在从AssetBundle中加载的AssetBundle
	public Dictionary<string, AssetBundle> assetBundleName_loadedAssetBundle; // 已经加载了的AssetBundle

	public bool isInited = false; // 指示资源管理器是否初始化过
	public Action onInit;
	#endregion
	
	public IEnumerator Init()
	{
		yield return InitAssetNameMap();
		assetBundleName_loadingAssetBundle = new Dictionary<string, AssetBundleCreateRequestWrap>();
		assetName_loadingAsset = new Dictionary<string, AssetBundleRequestWrap>();
		assetBundleName_loadedAssetBundle = new Dictionary<string, AssetBundle>();
		AssetTicker.Instance.onUpdate += Update;
		isInited = true;
		onInit?.Invoke();
		
		foreach (var keyValuePair in assetName_assetPath)
		{
			Debug.Log($"{keyValuePair.Key}:{keyValuePair.Value}");
		}

		Debug.Log($"**************");
		foreach (var keyValuePair in assetName_assetBundleName)
		{
			Debug.Log($"{keyValuePair.Key}:{keyValuePair.Value}");
		}
	}

	public IEnumerator InitAssetNameMap()
	{
		assetName_assetPath = new Dictionary<string, string>();
		assetName_assetBundleName = new Dictionary<string, string>();
#if UNITY_EDITOR
		if (assetModeInEditor == AssetMode.AssetBundle)
		{
			yield return InitAssetNameMapInAssetBundleMode();
		}
		else
		{
			InitAssetNameMapInAssetDataBaseMode();
		}
#else
		InitAssetNameMapInAssetBundleMode();
#endif
	}

	private IEnumerator InitAssetNameMapInAssetBundleMode()
	{
		using var request = UnityWebRequest.Get(Path.Combine(Application.streamingAssetsPath, "fileName_dirName.csv"));
		yield return request.SendWebRequest();
		if (request.result == UnityWebRequest.Result.Success)
		{
			var text = request.downloadHandler.text;
			var lines = text.Split('\n');
			foreach (var line in lines)
			{
				var newLine = line.Trim();
				var cells = newLine.Split(',');
				if (cells.Length == 2 && !string.IsNullOrEmpty(cells[0]) && !string.IsNullOrEmpty(cells[1]))
				{
					assetName_assetPath[cells[0]] = cells[1];
				}
			}
		}
		
		using var request2 = UnityWebRequest.Get(Path.Combine(Application.streamingAssetsPath, "fileName_assetBundleName.csv"));
		yield return request2.SendWebRequest();
		if (request2.result == UnityWebRequest.Result.Success)
		{
			var text = request2.downloadHandler.text;
			var lines = text.Split('\n');
			foreach (var line in lines)
			{
				var newLine = line.Trim();
				var cells = newLine.Split(',');
				if (cells.Length == 2 && !string.IsNullOrEmpty(cells[0]) && !string.IsNullOrEmpty(cells[1]))
				{
					assetName_assetBundleName[cells[0]] = cells[1];
				}
			}
		}
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
		List<string> keysToRemove = new List<string>();
		
		// 先遍历正在加载中的 AssetBundle
		foreach (var keyValuePair in assetBundleName_loadingAssetBundle)
		{
			if (keyValuePair.Value.request.isDone)
			{
				keysToRemove.Add(keyValuePair.Key);
				if (keyValuePair.Value == null)
				{
					Debug.LogError($"这里怎么会报错");
				}
				keyValuePair.Value?.onLoaded();
			}
		}

		foreach (var key in keysToRemove)
		{
			assetBundleName_loadingAssetBundle.Remove(key);
		}
		keysToRemove.Clear();

		// 再遍历正在加载中的 Asset
		foreach (var keyValuePair in assetName_loadingAsset)
		{
			if (keyValuePair.Value.request.isDone)
			{
				keysToRemove.Add(keyValuePair.Key);
				keyValuePair.Value?.onLoaded();
			}
		}
		
		foreach (var key in keysToRemove)
		{
			assetName_loadingAsset.Remove(key);
		}
		keysToRemove.Clear();
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
			LoadAssetAsyncFromAssetBundle<T>(assetName, onLoaded);
		}
#else
		LoadAssetAsyncInAssetBundleMode<T>(assetName, onLoaded);
#endif
	}

	private void LoadAssetAsyncFromAssetBundle<T>(string assetName, Action<T> onLoaded) where T : Object
	{
		if (!assetName_assetPath.TryGetValue(assetName, out var assetPath) || !assetName_assetBundleName.TryGetValue(assetName, out var assetBundleName))
		{
			return;
		}

		if (assetName_loadingAsset.TryGetValue(assetName, out var assetRequestWrap))
		{
			return;
		}
			
		if (!assetBundleName_loadedAssetBundle.TryGetValue(assetBundleName, out var assetBundle))
		{
			AssetBundleCreateRequest request = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, assetBundleName));
			if (request.isDone)
			{
				assetBundle = request.assetBundle;
				assetBundleName_loadedAssetBundle[assetBundleName] = assetBundle;
				var assetRequest = assetBundle.LoadAssetAsync<T>(assetPath);
				if (assetRequest.isDone)
				{
					T obj = assetRequest.asset as T;
					if (obj != null)
					{
						onLoaded(obj);
					}
				}
				else
				{
					var assetBundleRequestWrap = new AssetBundleRequestWrap(assetRequest);
					assetBundleRequestWrap.onLoaded += () =>
					{
						T obj = assetRequest.asset as T;
						if (obj != null)
						{
							onLoaded(obj);
						}
					};
					assetName_loadingAsset[assetName] = assetBundleRequestWrap;
				}
			}
			else
			{
				var assetBundleCreateRequestWrap = new AssetBundleCreateRequestWrap(request);
				assetBundleCreateRequestWrap.onLoaded += () =>
				{
					assetBundle = assetBundleCreateRequestWrap.request.assetBundle;
					LoadAssetAsyncFromAssetBundle(assetName, assetBundle, onLoaded);
				};
				assetBundleName_loadingAssetBundle[assetBundleName] = assetBundleCreateRequestWrap;
			}
		}
		else
		{
			LoadAssetAsyncFromAssetBundle(assetName, assetBundle, onLoaded);
		}
	}

	private void LoadAssetAsyncFromAssetBundle<T>(string assetName, AssetBundle assetBundle, Action<T> onLoaded) where T : Object
	{
		if (!assetName_assetPath.TryGetValue(assetName, out var assetPath) || !assetName_assetBundleName.TryGetValue(assetName, out var assetBundleName))
		{
			return;
		}

		var assetFullName = Path.Combine(assetPath, assetName);
		
		var assetRequest = assetBundle.LoadAssetAsync<T>(assetFullName);
		if (assetRequest.isDone)
		{
			T obj = assetRequest.asset as T;
			if (obj == null)
			{
				Debug.LogError($"资源加载失败: assetName = {assetFullName},assetPath = {assetPath}");
				return;
			}
			
			onLoaded(assetRequest.asset as T);
		}
		else
		{
			var assetBundleRequestWrap = new AssetBundleRequestWrap(assetRequest);
			assetBundleRequestWrap.onLoaded += () =>
			{
				T obj = assetRequest.asset as T;
				if (obj == null)
				{
					Debug.LogError($"资源加载失败: assetName = {assetFullName},assetPath = {assetPath}");
					return;
				}
				
				onLoaded(assetRequest.asset as T);
			};
			assetName_loadingAsset[assetName] = assetBundleRequestWrap;
		}
	}
}