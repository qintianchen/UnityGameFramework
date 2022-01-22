using System;
using System.Collections.Generic;
using LuaInterface;
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
    public string relativePath;
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
    public static string LuaFileRoot = "Assets/Lua/UI";
    
    public string LuaFileName;
    [HideInInspector] public List<LuaBindElement> elements;

    public LuaTable luaObj;
    
    public LuaTable GetLuaObject()
    {
        if (luaObj != null)
        {
            return luaObj;
        }

        var luaObjectName = GetLuaObjectName();
        LuaMain.Instance.lua.DoString($"require(\"{luaObjectName}\")");
        var luaParentObj = LuaMain.Instance.lua.GetTable(luaObjectName);
        luaObj = LuaMain.Instance.lua.Invoke<LuaTable, LuaTable>("NewObjectFrom", luaParentObj, false);
        
        luaObj.RawSet("gameObject", gameObject);
        luaObj.RawSet("transform", transform);
        
        foreach (var e in elements)
        {
            var go = e.obj as GameObject;
            Component comp = e.obj as Behaviour;
            if (go == null && comp == null)
            {
                GameLogger.Error($"绑定组件失败：obj={e.obj},relativePath={e.relativePath}");
                continue;
            }
            
            if (go == null)
            {
                go = comp.gameObject;
            }

            if (e.relativePath == string.Empty)
            {
                luaObj.RawSet(e.luaName, go);
            }
            else
            {
                var obj = transform.Find(e.relativePath);
                luaObj.RawSet(e.luaName, obj);
            }
        }
        
        return luaObj;
    }

    public string GetLuaObjectName()
    {
        var tmpName = LuaFileName.Replace("\\", "/");
        var tmpNames = tmpName.Split('/');
        return tmpNames[tmpNames.Length - 1];
    }
}