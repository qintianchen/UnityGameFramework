using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

// 在这个管理器中，我们有以下命名约定：
// fileFullName =         "Assets/Content/Environment/Prefabs/prefab_cube.prefab"       是指带后缀的文件全路径
// fileName =             "prefab_cube.prefab"                                          是指带后缀的文件名
// filePath =             "Assets/Content/Environment/Prefabs"                          是指文件所在的目录路径
// assetName =            "prefab_cube"                                                 是指资源名，也同时是不带后缀的文件名
// assetFullName =	      "Assets/Content/Environment/Prefabs/prefab_cube.prefab"       与fileFullName，带后缀的文件全路径
// assetBundleName =	  "content_environment_prefabs"                                 AssetBundle名称，是经过转换的filePath
// assetBundleFullName =  "Assets/StreamingAssets/content_environment_prefabs"          AssetBundle全路径名称

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

		public string ASSETBUNDLE_DIR // AssetBundle的生成目录
		{
			get
			{
				if (string.IsNullOrEmpty(m_ASSETBUNDLE_DIR))
					m_ASSETBUNDLE_DIR = Path.Combine(Application.streamingAssetsPath, "AssetBundles").Replace("\\", "/");
				return m_ASSETBUNDLE_DIR;
			}
		}

		private AssetMode assetModeInEditor = AssetMode.AssetBundle; // 指示编辑器使用AssetBundleMode，否则默认走AssetDataBase机制
		public Dictionary<string, string> assetName_assetFullName;
		public Dictionary<string, string> assetName_assetBundleName;
		public Dictionary<string, string> assetBundleName_assetBundleFullName;

		private Queue<AssetBundleWrap> assetBundlesToLoad; // 准备被加载的AssetBundle队列
		private Dictionary<string, AssetBundleWrap> assetBundleName_loadingAssetBundle; // 正在加载的AssetBundle
		private Dictionary<string, AssetBundleWrap> assetBundleName_loadedAssetBundle; // 加载完成的AssetBundle
		private Dictionary<string, AssetBundleWrap> assetBundleName_assetBundleToRemove; // 准备卸载的AssetBundle

		private AssetBundleManifest assetBundleManifest; // 资源的依赖关系

		public int MAX_ASSETBUNDLE_LOAD_PER_FRAME = 32;

		public bool isInited = false; // 指示资源管理器是否初始化过
		public Action onInit;

		#endregion

		public IEnumerator Init()
		{
			yield return InitAssetNameMap();
			assetBundlesToLoad = new Queue<AssetBundleWrap>();
			assetBundleName_loadingAssetBundle = new Dictionary<string, AssetBundleWrap>();
			assetBundleName_loadedAssetBundle = new Dictionary<string, AssetBundleWrap>();
			assetBundleName_assetBundleToRemove = new Dictionary<string, AssetBundleWrap>();
			// assetBundleName_loadingAssetBundle = new Dictionary<string, AssetBundleCreateRequestWrap>();
			// assetBundleName_loadedAssetBundle = new Dictionary<string, AssetBundle>();
			AssetTicker.Instance.onUpdate += Update;

			var assetBundle = AssetBundle.LoadFromFile(assetBundleName_assetBundleFullName[assetName_assetBundleName["AssetBundleManifest"]]);
			assetBundleManifest = assetBundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
			
			LoadAssetBundleAsync("content_environment_prefabs", bundle =>
			{
				Debug.Log($"加载完成: {bundle.name}");
				Debug.Log($"info = {GetLoadedAssetBundlesInfo()}");
			});

			// LoadAssetAsync<AssetBundleManifest>("AssetBundleManifest", manifest =>
			// {
			// 	assetBundleManifest = manifest;
			// 	isInited = true;
			// 	onInit?.Invoke();
			// });
		}

		#region private

		private IEnumerator InitAssetNameMap()
		{
			assetName_assetFullName = new Dictionary<string, string>();
			assetName_assetBundleName = new Dictionary<string, string>();
			assetBundleName_assetBundleFullName = new Dictionary<string, string>();
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
			Debug.Log($"assetName_assetBundleFullName = {JsonConvert.SerializeObject(assetName_assetBundleName, Formatting.Indented)}");
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
						var assetBundleName = AssetHelper.DirectoryPathToAssetBundleName(cells[1]);
						assetName_assetFullName[assetName] = Path.Combine(cells[1], cells[0]).Replace("\\", "/");
						assetName_assetBundleName[assetName] = assetBundleName;
						assetBundleName_assetBundleFullName[assetBundleName] = Path.Combine(ASSETBUNDLE_DIR, assetBundleName).Replace("\\", "/");
					}
				}
			}

			var dirs = ASSETBUNDLE_DIR.Split('/');
			var manifestAssetBundleName = dirs[dirs.Length - 1];
			assetName_assetFullName["AssetBundleManifest"] = "AssetBundleManifest";
			assetName_assetBundleName["AssetBundleManifest"] = manifestAssetBundleName;
			assetBundleName_assetBundleFullName[manifestAssetBundleName] = Path.Combine(ASSETBUNDLE_DIR, manifestAssetBundleName).Replace("\\", "/");
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

		private AssetBundleWrap LoadAssetBundleAsync(string assetBundleName, Action<AssetBundle> onLoaded)
		{
			if (!assetBundleName_assetBundleFullName.TryGetValue(assetBundleName, out var assetBundleFullName))
			{
				Debug.LogError($"Fail to find assetBundle, assetBundleName ={assetBundleName}");
				return null;
			}

			if (assetBundleName_loadedAssetBundle.TryGetValue(assetBundleName, out var assetBundleWrap))
			{
				return assetBundleWrap;
			}
			
			if (assetBundleName_loadingAssetBundle.TryGetValue(assetBundleName, out var assetBundleWrap2))
			{
				return assetBundleWrap2;
			}
			
			// 生成AssetBundleWrap
			var wrap = new AssetBundleWrap(assetBundleName, assetBundleFullName, onLoaded);
			
			// 先添加依赖到队列
			string[] assetBundleNames = assetBundleManifest.GetDirectDependencies(wrap.assetBundleName);
			foreach (var assetBundleName2 in assetBundleNames)
			{
				var wrap2 = LoadAssetBundleAsync(assetBundleName2, null);
				wrap.deps.Add(wrap2);
				wrap2.abRefs.Add(wrap);
			}
			
			// 再把自己添加进队列
			assetBundlesToLoad.Enqueue(wrap);
			return wrap;
		}

		private void Update()
		{
			// 从预加载队列中取出指定数量的AssetBundle进行加载
			for (int i = 0; i < MAX_ASSETBUNDLE_LOAD_PER_FRAME; i++)
			{
				if (assetBundlesToLoad.Count == 0)
					break;
				
				AssetBundleWrap wrap = assetBundlesToLoad.Dequeue();
				StartLoadAssetBundleWrap(wrap);
			}
			
			// 遍历正在加载的列表
			List<string> keys = new List<string>();
			foreach (var keyValuePair in assetBundleName_loadingAssetBundle)
			{
				var wrap = keyValuePair.Value;
				if (wrap.isDone)
				{
					Debug.Log($"完成加载AB:{wrap.request.assetBundle.name}");
					assetBundleName_loadedAssetBundle[wrap.assetBundleName] = wrap;
					keys.Add(keyValuePair.Key);
					wrap.onLoaded?.Invoke(wrap.request.assetBundle);
				}
			}
			foreach (var key in keys)
			{
				assetBundleName_loadingAssetBundle.Remove(key);
			}
		}

		private void StartLoadAssetBundleWrap(AssetBundleWrap wrap)
		{
			if (wrap == null)
			{
				return;
			}
			
			if (wrap.isDone)
			{
				Debug.Log($"完成加载AB:{wrap.request.assetBundle.name}");
				wrap.onLoaded?.Invoke(wrap.request.assetBundle);
				assetBundleName_loadedAssetBundle[wrap.assetBundleName] = wrap;
			}
			else
			{
				wrap.Load();
				if (wrap.isDone)
				{
					Debug.Log($"完成加载AB:{wrap.request.assetBundle.name}");
					wrap.onLoaded?.Invoke(wrap.request.assetBundle);
					assetBundleName_loadedAssetBundle[wrap.assetBundleName] = wrap;
				}
				else
				{
					assetBundleName_loadingAssetBundle[wrap.assetBundleName] = wrap;
				}
			}
		}

		public void UnloadAllUnusedAssetBundle()
		{
			List<string> keys = new List<string>();
			foreach (var keyValuePair in assetBundleName_loadedAssetBundle)
			{
				var wrap = keyValuePair.Value;
				if (wrap.refCount == 0)
				{
					keys.Add(wrap.assetBundleName);
					assetBundleName_assetBundleToRemove[wrap.assetBundleName] = wrap;
				}
			}
			
			foreach (var key in keys)
			{
				assetBundleName_loadedAssetBundle.Remove(key);
			}
			
			// 总感觉以后要对ToRemoe做什么事情，现在就直接立即清空好了
			foreach (var keyValuePair in assetBundleName_assetBundleToRemove)
			{
				keyValuePair.Value.UnLoad();
			}
			
			assetBundleName_assetBundleToRemove.Clear();
		}

		public string GetLoadedAssetBundlesInfo()
		{
			List<AssetBundleWrapInfo> infos = new List<AssetBundleWrapInfo>();
			foreach (var keyValuePair in assetBundleName_loadedAssetBundle)
			{
				var wrap = keyValuePair.Value;
				var info = new AssetBundleWrapInfo();
				info.assetBundleName = wrap.assetBundleName;
				info.deps = new List<string>();
				info.abRefs = new List<string>();
				info.objRefs = new List<string>();
				
				foreach (var dep in wrap.deps)
				{
					info.deps.Add(dep.assetBundleName);
				}
				
				foreach (var abRef in wrap.abRefs)
				{
					info.abRefs.Add(abRef.assetBundleName);
				}
				
				foreach (var objRef in wrap.objRefs)
				{
					info.objRefs.Add(objRef.name);
				}
				
				infos.Add(info);
			}

			return JsonConvert.SerializeObject(infos, Formatting.Indented);
		}
		
		#endregion
	}
}