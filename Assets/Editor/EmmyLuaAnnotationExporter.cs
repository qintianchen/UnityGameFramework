using System;
using System.IO;
using UnityEditor;

public static class EmmyLuaAnnotationExporter
{
    private static string SAVE_PATH = "Assets/EmmyLua";

    [MenuItem("Lua/导出EmmyLua注解")]
    public static void Run()
    {
        if (Directory.Exists(SAVE_PATH))
            Directory.Delete(SAVE_PATH, true);

        Directory.CreateDirectory(SAVE_PATH);

        foreach (var bindType in CustomSettings.customTypeList)
        {
            Type t = bindType.type;
            GenFileForType(t);
        }
    }

    static void GenFileForType(Type t)
    {
        var fileName = "EmmyLua_" + GetNameOfType(t).Replace(".", "_").Replace("+", "_");
        var filePath = SAVE_PATH + $"/{fileName}.lua";
        File.Create(filePath).Close();

        var typeInfo = "";
        typeInfo += $"---@class {GetNameOfType(t)}:{GetNameOfType(t.BaseType)}\n";

        var ps = t.GetProperties();
        foreach (var p in ps)
        {
            typeInfo += $"---@field {p.Name} {GetNameOfType(p.PropertyType)}\n";
        }

        var ms = t.GetMethods();
        foreach (var m in ms)
        {
            if (m.IsSpecialName || m.ReturnType.IsInterface) continue;

            var args = m.GetParameters();
            string argsInfo = "";
            bool isContainGenericParam = false;
            foreach (var arg in args)
            {
                if (arg.ParameterType.IsGenericType)
                {
                    isContainGenericParam = true;
                    break;
                }

                argsInfo += $"{arg.Name}:{GetNameOfType(arg.ParameterType)}, ";
            }

            if (isContainGenericParam) continue;
            argsInfo = argsInfo.TrimEnd(' ').TrimEnd(',');
            typeInfo += $"---@field {m.Name} fun({argsInfo})";
            var returnTypeName = GetNameOfType(m.ReturnType);
            if (returnTypeName == "System.Void")
            {
                typeInfo += "\n";
            }
            else
            {
                typeInfo += $":{returnTypeName}\n";
            }
        }

        typeInfo += GetNameOfType(t) + " = {}\n";
        File.WriteAllText(filePath, typeInfo);
    }

    static string GetNameOfType(Type t)
    {
        if (t.IsGenericType)
            return "any";

        string name = t.FullName;
        if (name == null)
        {
            // Debug.LogError($"没有办法获取到FullName {t.Name}");
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

        return name;
    }
}