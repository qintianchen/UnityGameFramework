using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LuaBehaviourInspector))]
public class LuaBehaviourInspector: Editor
{
    private Vector2 scrollPos;
    private LuaBindElement.BindType bindType = LuaBindElement.BindType.GameObject;
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        var behaviour = target as LuaBehaviour;
        
        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);
        EditorGUILayout.BeginVertical();
        EditorGUILayout.BeginHorizontal(GUILayout.MaxHeight(32));
        bindType = (LuaBindElement.BindType) EditorGUILayout.EnumPopup(bindType, GUILayout.MaxHeight(32)); 
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndScrollView();
    }
}