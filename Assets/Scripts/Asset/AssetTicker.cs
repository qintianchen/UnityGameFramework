using System;

public class AssetTicker : SingletonBehaviour<AssetTicker>
{
	private void Start()
	{
		DontDestroyOnLoad(this);
	}

	public Action onUpdate;
	
	private void Update()
	{
		onUpdate?.Invoke();
	}
}
