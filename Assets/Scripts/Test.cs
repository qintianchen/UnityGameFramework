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

	private void T1()
	{
		var a = 1.0 / Math.Cos(23);
		var b = 1.0 / Math.Cos(22);
		var a2 = Math.Pow(a, 2);
		var b2 = Math.Pow(b, 2);
		var c2 = a2 + b2 - Math.Cos(Math.PI / 4) * a * b;
		var res = b2 + c2 - 2 * b * Math.Sqrt(c2) * Math.Cos((68.0/180.0) * Math.PI);

		Debug.Log($"{res}, {a2}");

		Debug.Log($"{Math.Pow(2, 10)}, {2 * Math.Cos(Math.PI / 4)}");
	}
}
