using System;

public static class EmmyLuaUtil
{
    public static string GetNameOfType(Type t)
    {
        if (t == null)
        {
            return "{}";
        }
        string name = t.FullName;
        if (name == null)
        {
            name = t.Name;
            if (name.Contains("Action"))
            {
                return "fun()";
            }
            
            return "nil";
        }

        name = name.Replace("+", ".");

        if (name == "System.Boolean")
        {
            name = "boolean";
        }
        else if (name == "float" || name == "double" || name == "System.Int32" || name == "System.Single" || name == "System.UInt64")
        {
            name = "number";
        }
        else if (name == "System.String")
        {
            name = "string";
        }

        name = name.Replace("UnityEngine.UI.", "");
        name = name.Replace("UnityEngine.", "");

        return name;
    }
}