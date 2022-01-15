using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LuaBehaviour))]
public class LuaBehaviourInspector : Editor
{
    private Vector2 scrollPos;
    private Vector2 scrollPos2;
    private string[] typeNames;
    private int[] typeIndexes;

    public override void OnInspectorGUI()
    {
        var behaviour = target as LuaBehaviour;

        base.OnInspectorGUI();

        serializedObject.Update();

        if (typeNames == null)
        {
            typeNames = new string[LuaBindElement.availableTypes.Length];
            typeIndexes = new int[LuaBindElement.availableTypes.Length];
            for (int i = 0; i < typeNames.Length; i++)
            {
                typeNames[i] = LuaBindElement.availableTypes[i].Name;
                typeIndexes[i] = i;
            }
        }

        SerializedProperty elements = serializedObject.FindProperty("elements");
        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
        scrollPos2 = EditorGUILayout.BeginScrollView(scrollPos2, GUILayout.MaxHeight(Mathf.Min(200, elements.arraySize * 22)));
        var indexToDelete = -1;
        for (int i = 0; i < elements.arraySize; i++)
        {
            var e = elements.GetArrayElementAtIndex(i);
            var e2 = behaviour.elements[i];

            EditorGUILayout.BeginHorizontal();

            var selectedIndexProperty = e.FindPropertyRelative("selectedIndex");
            var objProperty = e.FindPropertyRelative("obj");
            var luaNameProperty = e.FindPropertyRelative("luaName");
            var isLuaNameCustomProperty = e.FindPropertyRelative("isLuaNameCustom");
            var relativePath = e.FindPropertyRelative("relativePath");
            
            var old_obj = objProperty.objectReferenceValue;
            var old_luaName = luaNameProperty.stringValue;
            
            selectedIndexProperty.intValue = EditorGUILayout.IntPopup(selectedIndexProperty.intValue, typeNames, typeIndexes, GUILayout.MaxWidth(120));
            var new_obj = EditorGUILayout.ObjectField(objProperty.objectReferenceValue, e2.type);
            var new_luaName = EditorGUILayout.TextField(luaNameProperty.stringValue);
            var clickDelete= GUILayout.Button("-");
            var clickMoveUp= GUILayout.Button("↑");
            var clickMoveDown= GUILayout.Button("↓");
            EditorGUILayout.EndHorizontal();

            new_luaName = new_luaName.Replace(" ", "_");
            if (old_luaName != new_luaName)
            {
                luaNameProperty.stringValue = new_luaName;
                isLuaNameCustomProperty.boolValue = true;
            }
            
            if (old_obj != new_obj)
            {
                if (TryGetRelativePath(new_obj, behaviour.transform, out string path))
                {
                    objProperty.objectReferenceValue = new_obj;
                    relativePath.stringValue = path;
                    if(!isLuaNameCustomProperty.boolValue)
                    {
                        luaNameProperty.stringValue = objProperty.objectReferenceValue.name;
                    }
                }
                else
                {
                    relativePath.stringValue = null;
                    Debug.LogError($"当前Object不属于Prefab的一部分，或不是当前LuaBehaviour的子物体: {new_obj}");
                }
            }
            
            if (clickDelete)
            {
                indexToDelete = i;
            }

            if (clickMoveUp && i > 0)
            {
                elements.MoveArrayElement(i, i - 1);
            }

            if (clickMoveDown && i < elements.arraySize - 1)
            {
                elements.MoveArrayElement(i, i + 1);
            }
        }
        EditorGUILayout.EndScrollView();
        if(indexToDelete >= 0)
            elements.DeleteArrayElementAtIndex(indexToDelete);

        EditorGUILayout.BeginHorizontal();
        if (Selection.gameObjects.Length > 0)
        {
            var clickAddRange = GUILayout.Button("->", GUILayout.MaxWidth(100), GUILayout.Height(32));
            if (clickAddRange)
            {
                List<GameObject> gos = new List<GameObject>();
                List<string> paths = new List<string>();
                foreach (var go in Selection.gameObjects)
                {
                    if (TryGetRelativePath(go, behaviour.transform, out string path))
                    {
                        gos.Add(go);
                        paths.Add(path);
                    }
                    else
                    {
                        Debug.LogError($"当前Object不属于Prefab的一部分，或不是当前LuaBehaviour的子物体: {go}");
                    }
                }
                
                for (int i = 0; i < gos.Count; i++)
                {
                    var go = gos[i];
                    elements.InsertArrayElementAtIndex(elements.arraySize);
                    var e = elements.GetArrayElementAtIndex(elements.arraySize - 1);
                    e.FindPropertyRelative("selectedIndex").intValue = 0;
                    e.FindPropertyRelative("obj").objectReferenceValue = go;
                    e.FindPropertyRelative("luaName").stringValue = go.name;
                    e.FindPropertyRelative("relativePath").stringValue = paths[i];

                    Debug.Log($"添加控件 : {paths[i]}");
                }
            }
        }
        
        var clickAdd = GUILayout.Button("+", GUILayout.MaxWidth(100),GUILayout.Height(32));
        if (!string.IsNullOrEmpty(behaviour.LuaFileName))
        {
            var clickExport = GUILayout.Button("export", GUILayout.MaxWidth(100),GUILayout.Height(32));
            if (clickExport)
            {
                Export();
            }
        }
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndScrollView();

        if (clickAdd)
        {
            elements.InsertArrayElementAtIndex(elements.arraySize);
            var e = elements.GetArrayElementAtIndex(elements.arraySize - 1);
            e.FindPropertyRelative("selectedIndex").intValue = 0;
            e.FindPropertyRelative("obj").objectReferenceValue = null;
            e.FindPropertyRelative("luaName").stringValue = string.Empty;
            e.FindPropertyRelative("relativePath").stringValue = null;
        }

        serializedObject.ApplyModifiedProperties();
    }

    private string startLine = "----------LuaBind Start----------";
    private string endLine = "----------LuaBind End----------";

    private void Export()
    {
        var behaviour = target as LuaBehaviour;

        string filePath = LuaBehaviour.LuaFileRoot + "/" + behaviour.LuaFileName.TrimStart('/') + ".lua";
        var luaObjectName = behaviour.GetLuaObjectName();
        
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }

        var lines = File.ReadAllLines(filePath);
        var body = "";
        var isInLuaBindPart = false;
        foreach (var line in lines)
        {
            if (line.Contains(startLine))
            {
                isInLuaBindPart = true;
            }

            if (!isInLuaBindPart)
            {
                body += line + "\n";
            }
            
            if (line.Contains(endLine))
            {
                isInLuaBindPart = false;
            }
        }

        var header = startLine + "\n";
        header += $"---@class {luaObjectName}\n";
        foreach (var element in behaviour.elements)
        {
            header += $"---@field {element.luaName} {EmmyLuaUtil.GetNameOfType(element.type)}\n";
        }

        header += endLine + "\n";
        File.WriteAllText(filePath, header + body);
        
        AssetDatabase.Refresh();
    }

    private bool TryGetRelativePath(Object obj, Transform parent, out string path)
    {
        GameObject go = obj as GameObject;
        Component comp = obj as Behaviour;
        if (go == null && comp == null)
        {
            path = null;
            return false;
        }
        
        if (go == null)
        {
            go = comp.gameObject;
        }

        var trans = go.transform;

        if (trans == parent)
        {
            path = "";
            return true;
        }

        path = go.name;
        while (true)
        {
            var p = trans.parent;

            if (p == null)
            {
                path = null;
                return false;
            }

            if (p == parent)
            {
                return true;
            }

            path = p.name + "/" + path;
            trans = p;
        }
    }
}