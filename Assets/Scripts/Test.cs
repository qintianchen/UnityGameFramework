using System;
using UnityEngine;

public class Test : MonoBehaviour
{
	private void Start()
	{
		Application.targetFrameRate = 30;
		AssetManager.Instance.Init();
	}

	private void Update()
	{
	}
}
