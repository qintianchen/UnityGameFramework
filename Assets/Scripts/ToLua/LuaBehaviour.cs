using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;
using Object = UnityEngine.Object;

[Serializable]
public class LuaBindElement
{
    public static Type[] availableTypes = {
        typeof(GameObject),
        typeof(Transform),
        typeof(RectTransform),
        typeof(Image),
        typeof(Text),
        typeof(Button),
        typeof(ScrollView),
    };

    public int selectedIndex;
    public Type type => availableTypes[selectedIndex];
    public Object obj;
    public string luaName;
    public bool isLuaNameCustom = false;

    public LuaBindElement()
    {
        selectedIndex = 0;
        obj = null;
        luaName = string.Empty;
        isLuaNameCustom = false;
    }
}

public class LuaBehaviour : MonoBehaviour
{
    public string LuaFileName;
    [HideInInspector] public List<LuaBindElement> elements;
}