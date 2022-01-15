using UnityEngine;

public static class LuaUtil
{
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
}