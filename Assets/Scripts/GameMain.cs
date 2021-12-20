using System;
using System.Collections;
using Newtonsoft.Json;
using QTC;
using UnityEngine;

public class GameMain : MonoBehaviour
{
	private Rect rect;

	private void Start()
	{
		Application.targetFrameRate = 30;
	}

	private void Update()
	{
		Debug.Log($"{rect}");

		rect.width = 30;

		Debug.Log($"after {rect}");
	}
}
