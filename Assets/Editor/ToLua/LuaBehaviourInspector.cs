using System.Collections.Generic;
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
        base.OnInspectorGUI();

        serializedObject.Update();

        var behaviour = target as LuaBehaviour;
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
        GUILayout.Button($"拖曳至此", GUILayout.Height(50));
        
        
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
            
            var old_obj = objProperty.objectReferenceValue;
            var old_luaName = luaNameProperty.stringValue;
            
            selectedIndexProperty.intValue = EditorGUILayout.IntPopup(selectedIndexProperty.intValue, typeNames, typeIndexes, GUILayout.MaxWidth(120));
            var new_objValue = EditorGUILayout.ObjectField(objProperty.objectReferenceValue, e2.type);
            luaNameProperty.stringValue = EditorGUILayout.TextField(luaNameProperty.stringValue);
            var clickDelete= GUILayout.Button("-");
            var clickMoveUp= GUILayout.Button("↑");
            var clickMoveDown= GUILayout.Button("↓");
            EditorGUILayout.EndHorizontal();

            if (old_luaName != luaNameProperty.stringValue)
            {
                isLuaNameCustomProperty.boolValue = true;
            }
            
            if (old_obj != new_objValue)
            {
                if (CheckObjectParent(new_objValue, behaviour.transform))
                {
                    objProperty.objectReferenceValue = new_objValue;
                    if(!isLuaNameCustomProperty.boolValue)
                    {
                        luaNameProperty.stringValue = objProperty.objectReferenceValue.name;
                    }
                }
                else
                {
                    Debug.LogError("无法赋值Prefab之外的Object");
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
        var clickAdd = GUILayout.Button("+", GUILayout.MaxWidth(100),GUILayout.Height(32));
        var clickExport = GUILayout.Button("export", GUILayout.MaxWidth(100),GUILayout.Height(32));
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndScrollView();

        if (clickAdd)
        {
            elements.InsertArrayElementAtIndex(elements.arraySize);
            var e = elements.GetArrayElementAtIndex(elements.arraySize - 1);
            e.FindPropertyRelative("selectedIndex").intValue = 0;
            e.FindPropertyRelative("obj").objectReferenceValue = null;
            e.FindPropertyRelative("luaName").stringValue = string.Empty;
        }

        if (clickExport)
        {
            
        }

        serializedObject.ApplyModifiedProperties();
    }

    private bool CheckObjectParent(Object obj, Transform parent)
    {
        GameObject go = obj as GameObject;
        Component comp = obj as Behaviour;
        if (go == null && comp == null)
        {
            return false;
        }
        
        if (go == null)
        {
            go = comp.gameObject;
        }

        var trans = go.transform;

        if (trans == parent) 
            return true;
        
        while (true)
        {
            if (trans.parent == null)
            {
                return false;
            }

            if (trans.parent == parent) return true;

            trans = trans.parent;
        }
    }
}