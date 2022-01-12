using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour
{
	private Rect rect;
	public Text text;

	private void Start()
	{
		Application.targetFrameRate = 30;

		text.DOText("1111111111111", 2);
	}
}
