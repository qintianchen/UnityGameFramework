using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

public class AssetBundleBuilder: Editor
{
	[MenuItem("Build/Build AssetBundles")]
	private static void BuildAssetBundles()
	{
		var assetDirs = AssetManager.Instance.assetDirs;
		AssetManager.Instance.InitAssetNameMap();
		foreach (var keyValuePair in AssetManager.Instance.assetName_assetPath)
		{
			var assetName = keyValuePair.Key;
			var assetPath = keyValuePair.Value;
			var dirs = assetPath.Split('/');
			var assetBundleNameTemp = new StringBuilder();
			for (var i = 0; i < dirs.Length - 1; i++)
			{
				var dir = dirs[i];
				assetBundleNameTemp.Append(dir);
				if (i < dirs.Length - 2)
				{
					assetBundleNameTemp.Append("_");
				}
			}

			var assetBundleName = assetBundleNameTemp.ToString();
			
			Debug.Log($"assetPath = {assetPath}, assetBundleName = {assetBundleName.ToLower()}");
		}
		// foreach (var assetDir in assetDirs)
		// {
		// 	var files = Directory.GetFiles(assetDir);
		// 	foreach (var file in files)
		// 	{
		// 		var ext = Path.GetExtension(file);
		// 		var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
		// 		if (ext.Equals(".meta"))
		// 		{
		// 			continue;
		// 		}
		// 		
		// 	}
		// }
	}
}