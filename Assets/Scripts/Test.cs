using System;
using System.Collections;
using System.Collections.Generic;
using QTC;
using UnityEngine;

public class Test : MonoBehaviour
{
	private void Start()
	{
		Application.targetFrameRate = 30;
		StartCoroutine(AssetManager.Instance.Init());
	}
}
