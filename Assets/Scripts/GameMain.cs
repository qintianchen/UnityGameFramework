using System;
using System.Collections;
using DG.Tweening;
using Newtonsoft.Json;
using QTC;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour
{
	private Rect rect;
	public Text text;

	private void Start()
	{
		Application.targetFrameRate = 30;

		text.DOText("123456789sdfghjklzxcvbnmqwertyuiop", 2);
	}
}
