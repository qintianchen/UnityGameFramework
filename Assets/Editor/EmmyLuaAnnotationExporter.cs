using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEngine;

// ToLua导出到C#的类导出EmmyLua注解
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
            GenFileForType(t, bindType.extendList);
        }
    }

    [MenuItem("Lua/测试")]
    public static void Run2()
    {
    }
    
    static void GenFileForType(Type t, List<Type> extendTypes)
    {
        Debug.Log($"开始导出类型 {GetNameOfType(t)}");
        var fileName = "EmmyLua_" + GetNameOfType(t).Replace(".", "_").Replace("+", "_");
        var filePath = SAVE_PATH + $"/{fileName}.lua";
        File.Create(filePath).Close();

        var typeInfo = "";
        typeInfo += $"---@class {GetNameOfType(t)}:{GetNameOfType(t.BaseType)}\n";

        if (t.IsEnum)
        {
            var fs = t.GetFields();
            foreach (var f in fs)
            {
                typeInfo += $"---@field {f.Name} {GetNameOfType(f.FieldType)}\n";
            }
        }
        else
        {
            // 属性部分
            PropertyInfo[] ps = t.GetProperties();
            foreach (var p in ps)
            {
                typeInfo += $"---@field {p.Name} {GetNameOfType(p.PropertyType)}\n";
            }

            // 方法部分
            MethodInfo[] ms = t.GetMethods();
            foreach (var m in ms)
            {
                var info = MethodInfo2EmmyLua(m);
                if (info != null)
                {
                    typeInfo += info;
                }
            }
            
            // 扩展方法部分
            foreach (var extendType in extendTypes)
            {
                ms = extendType.GetMethods();
                foreach (var m in ms)
                {
                    if(m.IsGenericMethod) continue;
                    
                    ParameterInfo[] paramList = m.GetParameters();
                    if (paramList.Length <= 0 || paramList[0].ParameterType != t) continue;
                    
                    var info = MethodInfo2EmmyLua(m);
                    if (info != null)
                    {
                        typeInfo += info;
                    }
                }
            }
        }

        typeInfo += GetNameOfType(t) + " = {}\n";
        File.WriteAllText(filePath, typeInfo);
    }

    static string MethodInfo2EmmyLua(MethodInfo m)
    {
        // 对于 get/set 方法，以及返回类型是接口类型的，不会导出
        if (m.IsSpecialName || m.ReturnType.IsInterface) return null;

        var info = "";

        var args = m.GetParameters();
        string argsInfo = "";
        if (!m.IsStatic)
        {
            argsInfo += $"self:{GetNameOfType(m.DeclaringType)}, ";
        }
        foreach (var arg in args)
        {
            argsInfo += $"{arg.Name}:{GetNameOfType(arg.ParameterType)}, ";
        }

        argsInfo = argsInfo.TrimEnd(' ').TrimEnd(',');
        info += $"---@field {m.Name} fun({argsInfo})";
            
        var returnTypeName = GetNameOfType(m.ReturnType);
        if (returnTypeName == "System.Void") // 没有返回值的方法
        {
            info += "\n";
        }
        else
        {
            info += $":{returnTypeName}\n";
        }

        return info;
    }

    static string GetNameOfType(Type t)
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