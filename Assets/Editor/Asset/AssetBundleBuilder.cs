using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;
using SerializationHelper;


[Serializable]
class DictionarySerializationWrap<T, K>
{
	private Dictionary<T, K> dict;
	public List<KeyValuePairWrap<T, K>> keyValuePairs;

	public K this[T t]
	{
		get
		{
			dict.TryGetValue(t, out K v);
			return v;
		}
	}

	public DictionarySerializationWrap(Dictionary<T, K> dict)
	{
		keyValuePairs = new List<KeyValuePairWrap<T, K>>();
		foreach (var keyValuePair in dict)
		{
			// this.dict[keyValuePair.Key] = keyValuePair.Value;
			var pair = new KeyValuePairWrap<T, K>();
			pair.key = keyValuePair.Key;
			pair.value = keyValuePair.Value;
			keyValuePairs.Add(pair);
		}
	}
}

public class AssetBundleBuilder : Editor
{
	[MenuItem("Build/Build AssetBundles")]
	private static void BuildAssetBundles()
	{
		// 构造 <目录，目录下所有的文件> 映射，<文件名, 目录名> 映射。前者用于打包，后者用于运行时查询。
		Dictionary<string, List<string>> dir_files = new Dictionary<string, List<string>>();
		Dictionary<string, string> fileName_dirName = new Dictionary<string, string>();
		Dictionary<string, string> fileName_assetBundleName = new Dictionary<string, string>();
		foreach (var assetDir in AssetManager.Instance.assetDirs)
		{
			var files = Directory.GetFiles(assetDir);
			var validFiles = new List<string>();
			foreach (var file in files)
			{
				var ext = Path.GetExtension(file);
				var fileName = Path.GetFileName(file);
				if (ext.Equals(".meta"))
				{
					continue;
				}

				fileName_dirName[fileName] = Path.GetDirectoryName(file).Replace("\\", "/");
				validFiles.Add(file.Replace("\\", "/"));
			}

			dir_files[assetDir] = validFiles;
		}

		// 通过上面映射构造 AssetBundleBuild 列表，其中每个目录对应一个AB，AB 里面包含目录下的所有文件
		List<AssetBundleBuild> builds = new List<AssetBundleBuild>();
		foreach (var keyValuePair in dir_files)
		{
			AssetBundleBuild build = new AssetBundleBuild();
			var assetBundleNames = new List<string>();
			foreach (var s in keyValuePair.Value)
			{
				assetBundleNames.Add(s);
			}
			
			build.assetNames = assetBundleNames.ToArray();
			string assetBundleName = keyValuePair.Key.Replace("/", "_").ToLower();
			build.assetBundleName = assetBundleName;
			
			foreach (var s in keyValuePair.Value)
			{
				var fileName = Path.GetFileName(s);
				fileName_assetBundleName[fileName] = assetBundleName;
			}
			
			Debug.Log($"{build.assetBundleName}: {PrintUtils.Print(build.assetNames)}");
			builds.Add(build);
		}

		// 开始构建 AB
		if (!Directory.Exists(Application.streamingAssetsPath))
		{
			Directory.CreateDirectory(Application.streamingAssetsPath);
		}
		BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath, builds.ToArray(), BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.Android);

		// 序列化 <文件名, 目录名>
		// ListSerializationWrap<KeyValuePairWrap<string, string>> wrap = new ListSerializationWrap<KeyValuePairWrap<string, string>>();
		// wrap.items = new List<KeyValuePairWrap<string, string>>();
		// foreach (var keyValuePair in fileName_dirName)
		// {
		// 	var pair = new KeyValuePairWrap<string, string>();
		// 	pair.key = keyValuePair.Key;
		// 	pair.value = keyValuePair.Value;
		// 	wrap.items.Add(pair);
		// }
		
		// Dictionary<string, ListSerializationWrap<string>> wrap = new Dictionary<string, ListSerializationWrap<string>>();
		// foreach (var keyValuePair in dir_files)
		// {
		// 	ListSerializationWrap<string> listWrap = new ListSerializationWrap<string>();
		// 	string[] values = new string[keyValuePair.Value.Count];
		// 	keyValuePair.Value.CopyTo(values);
		// 	listWrap.items = values.ToList();
		// 	wrap[keyValuePair.Key] = listWrap;
		// }

		StringBuilder sb = new StringBuilder();
		foreach (var keyValuePair in fileName_dirName)
		{
			sb.Append(keyValuePair.Key).Append(",").Append(keyValuePair.Value).Append("\n");
		}

		// File.WriteAllText(Application.streamingAssetsPath + "/fileName_dirName.json", JsonUtility.ToJson(wrap, true));
		File.WriteAllText(Application.streamingAssetsPath + "/fileName_dirName.csv", sb.ToString());
		
		sb = new StringBuilder();
		foreach (var keyValuePair in fileName_assetBundleName)
		{
			sb.Append(keyValuePair.Key).Append(",").Append(keyValuePair.Value).Append("\n");
		}

		// File.WriteAllText(Application.streamingAssetsPath + "/fileName_dirName.json", JsonUtility.ToJson(wrap, true));
		File.WriteAllText(Application.streamingAssetsPath + "/fileName_assetBundleName.csv", sb.ToString());
		
		AssetDatabase.Refresh();
	}
}