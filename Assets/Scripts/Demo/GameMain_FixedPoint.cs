using System;
using QTC.FixedPointScaleVersion;
using TrueSync;
using UnityEngine;

public class GameMain_FixedPoint : MonoBehaviour
{
    private void Start()
    {
        FixedPoint a = 15f;
        FixedPoint b = 2.3f;

        Debug.Log($"{a / b}");
    }
}
