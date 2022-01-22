using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;

[ScriptedImporter(1, "lua")]
public class LuaImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        string luaTxt = File.ReadAllText(ctx.assetPath);
        TextAsset assetsText = new TextAsset(luaTxt);
        ctx.AddObjectToAsset("main obj", assetsText); 
        ctx.SetMainObject(assetsText);
    }
}