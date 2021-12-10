using System;
using System.Collections;
using UnityEngine;

public abstract class Request: IDisposable
{
	protected enum RequestState
	{
		None,
		Success,
		Requesting,
	}

	protected RequestState state = RequestState.None;

	public abstract void Dispose();
}

public class AssetBundleCreateRequestWrap
{
	public Action onLoaded;
	public AssetBundleCreateRequest request;
	
	public AssetBundleCreateRequestWrap(AssetBundleCreateRequest request)
	{
		this.request = request;
	}
}

public class AssetBundleRequestWrap
{
	public Action onLoaded;
	public AssetBundleRequest request;

	public AssetBundleRequestWrap(AssetBundleRequest request)
	{
		this.request = request;
	}
}

// public class AssetBundleRequest: Request
// {
// 	public AssetBundle assetBundle;
// 	public Action onLoaded;
//
// 	public void Send(string assetBundleName)
// 	{
// 		state = RequestState.Requesting;
// 		AssetTicker.Instance.StartCoroutine(CoLoadAssetBundle(assetBundleName));
// 	}
//
// 	IEnumerator CoLoadAssetBundle(string assetBundleName)
// 	{
// 		var request = AssetBundle.LoadFromFileAsync(assetBundleName);
// 		yield return request;
// 		assetBundle = request.assetBundle;
// 		state = RequestState.Success;
// 	}
//
// 	public override void Dispose()
// 	{
// 	}
// }
//
// public class AssetRequest : Request
// {
// 	public AssetBundle assetBundle;
// 	
// 	public override void Dispose()
// 	{
// 		
// 	}
// }