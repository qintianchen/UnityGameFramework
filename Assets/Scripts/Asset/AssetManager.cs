using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using Formatting = Unity.Plastic.Newtonsoft.Json.Formatting;
using JsonConvert = Unity.Plastic.Newtonsoft.Json.JsonConvert;
using Object = UnityEngine.Object;

// 在这个管理器中，我们有以下命名约定：
// fileFullName =		"Assets/Content/Environment/Prefabs/prefab_cube.prefab"		是指带后缀的文件全路径
// fileName =			"prefab_cube.prefab"										是指带后缀的文件名
// filePath =			"Assets/Content/Environment/Prefabs"						是指文件所在的目录路径
// assetName =			"prefab_cube"												是指资源名，也同时是不带后缀的文件名
// assetFullName =		"Assets/Content/Environment/Prefabs/prefab_cube.prefab"		与fileFullName，带后缀的文件全路径
// assetBundleName =	"content_environment_prefabs"								AssetBundle名称，是经过转换的filePath
// assetBundleFullName =	"Assets/StreamingAssets/content_environment_prefabs"	AssetBundle全路径名称

namespace QTC
{
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
			"Assets/Content/Environment",
			"Assets/Content/Scenes",
			"Assets/Content/Shaders",
		};
		
		private string m_ASSETBUNDLE_DIR;
		public string ASSETBUNDLE_DIR
		{
			get
			{
				if (string.IsNullOrEmpty(m_ASSETBUNDLE_DIR))
					m_ASSETBUNDLE_DIR = Path.Combine(Application.streamingAssetsPath, "AssetBundles").Replace("\\", "/");
				return m_ASSETBUNDLE_DIR;
			}
		}
		private AssetMode assetModeInEditor = AssetMode.AssetBundle; // 指示编辑器使用AssetBundleMode，否则默认走AssetDataBase机制
		private Dictionary<string, string> assetName_assetFullName; // 资源名字和资源路径的对应关系
		private Dictionary<string, string> assetName_assetBundleFullName; // 资源名字和资源路径的对应关系
		private Dictionary<string, AssetBundleRequestWrap> assetName_loadingAsset; // 正在从AssetBundle中加载的AssetBundle
		private Dictionary<string, AssetBundleCreateRequestWrap> assetBundleFullName_loadingAssetBundle; // 正在加载的AssetBundle
		private Dictionary<string, AssetBundle> assetBundleFullName_loadedAssetBundle; // 已经加载了的AssetBundle
		private AssetBundleManifest assetBundleManifest; // 资源的依赖关系

		public bool isInited = false; // 指示资源管理器是否初始化过
		public Action onInit;

		#endregion
		
		public IEnumerator Init()
		{
			yield return InitAssetNameMap();
			assetBundleFullName_loadingAssetBundle = new Dictionary<string, AssetBundleCreateRequestWrap>();
			assetName_loadingAsset = new Dictionary<string, AssetBundleRequestWrap>();
			assetBundleFullName_loadedAssetBundle = new Dictionary<string, AssetBundle>();
			AssetTicker.Instance.onUpdate += Update;

			LoadAssetAsync<AssetBundleManifest>("AssetBundleManifest", manifest =>
			{
				assetBundleManifest = manifest;
				isInited = true;
				onInit?.Invoke();

				// Debug.Log($"manifest = {JsonConvert.SerializeObject(manifest.GetAllDependencies("content_environment_prefabs"), Formatting.Indented)}");
				// Debug.Log($"manifest = {JsonConvert.SerializeObject(manifest.GetDirectDependencies("content_environment_prefabs"), Formatting.Indented)}");
			});
			
		}
		
		public void LoadAssetAsync<T>(string assetName, Action<T> onLoaded) where T : Object
		{
#if UNITY_EDITOR
			if (assetModeInEditor == AssetMode.AssetDataBase)
			{
				if (!assetName_assetFullName.TryGetValue(assetName, out var assetPath))
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
				LoadAssetAsyncInAssetBundleMode(assetName, onLoaded);
			}
#else
		LoadAssetAsyncInAssetBundleMode(assetName, onLoaded);
#endif
		}

		public void UnLoadAssetBundle(string assetBundleName)
		{
			var assetBundleFullName = Path.Combine(ASSETBUNDLE_DIR, assetBundleName).Replace("\\", "/");
			if (assetBundleFullName_loadedAssetBundle.TryGetValue(assetBundleFullName, out var assetBundle))
			{
				assetBundleFullName_loadedAssetBundle.Remove(assetBundleFullName);
				assetBundle.Unload(true);
			}
		}

		#region private

		private IEnumerator InitAssetNameMap()
		{
			assetName_assetFullName = new Dictionary<string, string>();
			assetName_assetBundleFullName = new Dictionary<string, string>();
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
		yield return InitAssetNameMapInAssetBundleMode();
#endif

			Debug.Log($"assetName_assetFullName = {JsonConvert.SerializeObject(assetName_assetFullName, Formatting.Indented)}");
			Debug.Log($"assetName_assetBundleFullName = {JsonConvert.SerializeObject(assetName_assetBundleFullName, Formatting.Indented)}");
		}

		private IEnumerator InitAssetNameMapInAssetBundleMode()
		{
			using var request = UnityWebRequest.Get(Path.Combine(ASSETBUNDLE_DIR, "fileName_dirName.csv"));
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
						var assetName = Path.GetFileNameWithoutExtension(cells[0]);
						assetName_assetFullName[assetName] = Path.Combine(cells[1], cells[0]).Replace("\\", "/");
						assetName_assetBundleFullName[assetName] = Path.Combine(ASSETBUNDLE_DIR, AssetHelper.DirectoryPathToAssetBundleName(cells[1])).Replace("\\", "/");
					}
				}
			}
			
			var dirs = ASSETBUNDLE_DIR.Split('/');
			var manifestAssetBundleName = dirs[dirs.Length - 1];
			assetName_assetFullName["AssetBundleManifest"] = "AssetBundleManifest";
			assetName_assetBundleFullName["AssetBundleManifest"] = Path.Combine(ASSETBUNDLE_DIR, manifestAssetBundleName);
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

					assetName_assetFullName[fileNameWithoutExtension] = file.Replace("\\", "/");
				}
			}
		}

		private void Update()
		{
			List<string> keysToRemove = new List<string>();

			// 先遍历正在加载中的 AssetBundle
			foreach (var keyValuePair in assetBundleFullName_loadingAssetBundle)
			{
				if (keyValuePair.Value.isDone)
				{
					Debug.Log($"完成加载AssetBundle: {keyValuePair.Key}");
					keysToRemove.Add(keyValuePair.Key);
					keyValuePair.Value.onLoaded?.Invoke(keyValuePair.Value.request.assetBundle);
					assetBundleFullName_loadedAssetBundle[keyValuePair.Key] = keyValuePair.Value.request.assetBundle;
				}
			}

			foreach (var key in keysToRemove)
			{
				assetBundleFullName_loadingAssetBundle.Remove(key);
			}

			keysToRemove.Clear();

			// 再遍历正在加载中的 Asset
			foreach (var keyValuePair in assetName_loadingAsset)
			{
				if (keyValuePair.Value.request.isDone)
				{
					keysToRemove.Add(keyValuePair.Key);
					keyValuePair.Value?.onLoaded(keyValuePair.Value.request.asset);
				}
			}

			foreach (var key in keysToRemove)
			{
				assetName_loadingAsset.Remove(key);
			}

			keysToRemove.Clear();
		}

		private void LoadAssetAsyncInAssetBundleMode<T>(string assetName, Action<T> onLoaded) where T : Object
		{
			if (!assetName_assetBundleFullName.TryGetValue(assetName, out var assetBundleFullName))
			{
				Debug.LogError($"Fail to find asset, assetName = {assetName}");
				return;
			}

			if (assetBundleFullName_loadedAssetBundle.TryGetValue(assetBundleFullName, out var assetBundle))
			{
				LoadAssetFromAssetBundle(assetName, assetBundle, onLoaded);
			}
			else if(assetBundleFullName_loadingAssetBundle.TryGetValue(assetBundleFullName, out var createRequestWrap))
			{
				createRequestWrap.onLoaded += assetBundle2 =>
				{
					LoadAssetFromAssetBundle(assetName, assetBundle2, onLoaded);
				};
			}
			else
			{
				LoadAssetBundleAsync(assetBundleFullName, assetBundle2 =>
				{
					LoadAssetFromAssetBundle(assetName, assetBundle2, onLoaded);
				});
			}
		}

		private void LoadAssetFromAssetBundle<T>(string assetName, AssetBundle assetBundle, Action<T> onLoaded) where T : Object
		{
			if (!assetName_assetFullName.TryGetValue(assetName, out var assetFullName))
			{
				Debug.LogError($"Fail to find asset, assetName = {assetName}");
				return;
			}

			if (assetName_loadingAsset.TryGetValue(assetName, out var requestWrap))
			{
				requestWrap.onLoaded += asset =>
				{
					var obj = asset as T;
					onLoaded?.Invoke(obj);
				};
				return;
			}
			
			var request = assetBundle.LoadAssetAsync<T>(assetFullName);
			if (request.isDone)
			{
				var obj = request.asset as T;
				onLoaded?.Invoke(obj);
			}
			else
			{
				requestWrap = new AssetBundleRequestWrap(request);
				requestWrap.onLoaded += asset =>
				{
					var obj = asset as T;
					onLoaded?.Invoke(obj);
				};
				assetName_loadingAsset[assetName] = requestWrap;
			}
		}

		private List<AssetBundleCreateRequestWrap> LoadAssetBundleAsync(string assetBundleFullName, Action<AssetBundle> onLoaded)
		{
			if (assetBundleFullName_loadedAssetBundle.TryGetValue(assetBundleFullName, out var assetBundle))
			{
				onLoaded?.Invoke(assetBundle);
				return null;
			}
			
			var request = AssetBundle.LoadFromFileAsync(assetBundleFullName);
			if (request.isDone)
			{
				assetBundleFullName_loadedAssetBundle[assetBundleFullName] = request.assetBundle;
				onLoaded?.Invoke(request.assetBundle);
			}
			else
			{
				var requestWrap = new AssetBundleCreateRequestWrap(request);
				requestWrap.onLoaded += onLoaded;
				assetBundleFullName_loadingAssetBundle[assetBundleFullName] = requestWrap;
				
				if (assetBundleManifest != null)
				{
					string[] assetBundleNames = assetBundleManifest.GetAllDependencies(assetBundleFullName);
					Debug.Log($"获取依赖：{assetBundleFullName} =>\n{JsonConvert.SerializeObject(assetBundleNames, Formatting.Indented)}");
					List<AssetBundleCreateRequestWrap> unLoadedDeps = new List<AssetBundleCreateRequestWrap>();
					foreach (var assetBundleName in assetBundleNames)
					{
						List<AssetBundleCreateRequestWrap> requestWraps = LoadAssetBundleAsync(Path.Combine(ASSETBUNDLE_DIR, assetBundleName).Replace("\\", "/"), null);
						if (requestWraps != null)
						{
							unLoadedDeps.AddRange(requestWraps);
						}
					}
					requestWrap.dependencies = unLoadedDeps;
					return unLoadedDeps;
				}
			}

			return null;
		}

		#endregion
		
	}
}