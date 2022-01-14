using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

[System.Serializable]
public class LuaBindElement
{
    public enum BindType
    {
        GameObject,
        Transform,
        RectTransform,
        Image,
        Text,
        Button,
        ScrollView
    }
    
    public BindType type;
    public Object obj;
    public string luaName;
}

public class LuaBehaviour : MonoBehaviour
{
    public string LuaFileName;
    [HideInInspector] public List<LuaBindElement> elements;
}