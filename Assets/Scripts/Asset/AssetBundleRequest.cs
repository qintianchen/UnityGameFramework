using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace QTC
{
	public class AssetBundleWrap
	{
		public string assetBundleName;
		public string assetBundleFullName;
		public Action<AssetBundle> onLoaded;

		public List<AssetBundleWrap> deps; // 依赖的AB列表，加载时，这个列表需要都被先加载完成

		public List<AssetBundleWrap> abRefs; // 被该列表的AB依赖，与 deps 意思相反，在卸载时，这个列表要为空
		public List<Object> objRefs; // 被该列表的Object依赖，在卸载时，这个列表要为空

		public AssetBundleCreateRequest request;
		public bool isDone 
		{
			get
			{
				if (request == null || !request.isDone)
				{
					return false;
				}

				return deps.All(dep => dep.isDone);
			}	
		}

		public int refCount
		{
			get
			{
				abRefs.RemoveAll(abRef => abRef.refCount == 0);
				objRefs.RemoveAll(obj => obj == null);

				return abRefs.Count + objRefs.Count;
			}
		}

		public AssetBundleWrap(string assetBundleName, string assetBundleFullName, Action<AssetBundle> onLoaded)
		{
			this.assetBundleName = assetBundleName;
			this.assetBundleFullName = assetBundleFullName;
			this.onLoaded = onLoaded;

			deps = new List<AssetBundleWrap>();
		}
		
		public void Load()
		{
			if (request != null)
			{
				return;
			}

			request = AssetBundle.LoadFromFileAsync(assetBundleFullName);
		}

		public void UnLoad()
		{
			request.assetBundle.Unload(true);
		}
	}
	
	
	
	public class AssetBundleCreateRequestWrap
	{
		public Action<AssetBundle> onLoaded;
		public AssetBundleCreateRequest request;
		public List<AssetBundleCreateRequestWrap> dependencies;
		
		public bool isDone
		{
			get
			{
				return request.isDone && dependencies.All(requestWrap => requestWrap.isDone);
			}
		}
	
		public AssetBundleCreateRequestWrap(AssetBundleCreateRequest request)
		{
			this.request = request;
			dependencies = new List<AssetBundleCreateRequestWrap>();
		}
	}

	public class AssetBundleRequestWrap
	{
		public Action<Object> onLoaded;
		public AssetBundleRequest request;

		public AssetBundleRequestWrap(AssetBundleRequest request)
		{
			this.request = request;
		}
	}
}
