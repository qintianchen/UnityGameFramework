using LuaInterface;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public static class LuaUtil
{
    public static bool IsStringNullOrEmpty(string str)
    {
        return string.IsNullOrEmpty(str);
    }
    
    public static Transform TransformFind(GameObject go, string name)
    {
        if (go == null || string.IsNullOrEmpty(name))
        {
            return null;
        }

        return go.transform.Find(name);
    }

    public static Transform TransformFind(Component comp, string name)
    {
        return comp == null ? null : TransformFind(comp.gameObject, name);
    }

    public static void SetButton(GameObject go, LuaFunction onClick)
    {
        if (go == null)
        {
            return;
        }

        var btn = go.GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(() => { onClick?.Call<PointerEventData>(null); });
        }
    }

    public static void SetButton(Component comp, LuaFunction onClick)
    {
        if (comp != null)
        {
            SetButton(comp.gameObject, onClick);
        }
    }

    public static void SetText(GameObject go, string content)
    {
        if (go == null)
        {
            return;
        }

        var txt = go.GetComponent<Text>();
        if (txt != null)
        {
            txt.text = content;
        }
    }

    public static void SetText(Component comp, string content)
    {
        if (comp != null)
        {
            SetText(comp.gameObject, content);
        }
    }

    public static void SetActive(GameObject go, bool isActive)
    {
        if (go == null)
        {
            return;
        }
        
        go.SetActive(isActive);
    }
    
    public static void SetActive(Component go, bool isActive)
    {
        if (go == null)
        {
            return;
        }
        
        SetActive(go.gameObject, isActive);
    }
}