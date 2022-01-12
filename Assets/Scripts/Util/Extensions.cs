using UnityEngine;

public static class Extensions
{
    public static T GetOrAddComponent<T>(this GameObject go) where T: Behaviour
    {
        if (go == null)
        {
            return null;
        }

        var t = go.GetComponent<T>();
        if (t == null)
        {
            return go.AddComponent<T>();
        }

        return t;
    }
    
    public static T GetOrAddComponent<T>(this Component comp) where T: Behaviour
    {
        return comp == null ? null : comp.gameObject.GetOrAddComponent<T>();
    }
}