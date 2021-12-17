using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TrueSync;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class GameMain_TrueSync : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;

    private void Start()
    {
        TestMultiplePerformance();
    }
    
    private void TestMultiplePerformance()
    {
        List<FP> fps = new List<FP>();
        List<float> fs = new List<float>();

        int count = 10000000;
        for (int i = 0; i < count; i++)
        {
            float val = Random.Range(1, 10000000);
            fps.Add(val);
            fs.Add(val);
        }

        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < count; i+=2)
        {
            fps[i] *= fps[i + 1];
        }

        sw.Stop();
        Debug.Log($"FP cost {(double)sw.ElapsedMilliseconds / 1000} s");
        
        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < count; i+=2)
        {
            fs[i] *= fs[i + 1];
        }

        sw.Stop();
        Debug.Log($"float cost {(double)sw.ElapsedMilliseconds / 1000} s");
        
        // 一千万次数下，float耗时 0.087 s, FP耗时 0.159 s，浮点求三角函数相差 1.827 倍
    }
    
    private void TestSinPerformance()
    {
        List<FP> fps = new List<FP>();
        List<float> fs = new List<float>();

        int count = 10000000;
        for (int i = 0; i < count; i++)
        {
            float val = Random.Range(1, 10000000);
            fps.Add(val);
            fs.Add(val);
        }

        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < count; i++)
        {
            fps[i] = FP.Sin(i);
        }

        sw.Stop();
        Debug.Log($"FP cost {(double)sw.ElapsedMilliseconds / 1000} s");
        
        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < count; i++)
        {
            fs[i] = Mathf.Sin(fs[i]);
        }

        sw.Stop();
        Debug.Log($"float cost {(double)sw.ElapsedMilliseconds / 1000} s");
        
        // 一千万次数下，float耗时 0.512 s, FP耗时 1.729 s，浮点求三角函数相差 3.37 倍
    }

    private void TestSqrtPerformance()
    {
        List<FP> fps = new List<FP>();
        List<float> fs = new List<float>();

        int count = 10000000;
        for (int i = 0; i < count; i++)
        {
            float val = Random.Range(1, 10000000);
            fps.Add(val);
            fs.Add(val);
        }

        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < count; i++)
        {
            fps[i] = FP.Sqrt(fps[i]);
        }

        sw.Stop();
        Debug.Log($"FP cost {(double)sw.ElapsedMilliseconds / 1000} s");
        
        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < count; i++)
        {
            fs[i] = Mathf.Sqrt(fs[i]);
        }

        sw.Stop();
        Debug.Log($"float cost {(double)sw.ElapsedMilliseconds / 1000} s");
        
        // 一千万次数下，float耗时 0.241 s, FP耗时 4.107 s，浮点求根号运算性能相差 17 倍
    }

    private void Do()
    {
        // go1.transform.GetComponent<Rigidbody>().AddForce();
    }
}