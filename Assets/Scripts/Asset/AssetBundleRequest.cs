using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace QTC
{
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
