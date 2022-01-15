using UnityEngine;
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEditor;
using BindType = ToLuaMenu.BindType;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.Video;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;
using Object = UnityEngine.Object;
using Slider = UnityEngine.UI.Slider;
using Toggle = UnityEngine.UI.Toggle;

public static class CustomSettings
{
    public static string saveDir = Application.dataPath + "/Scripts/ToLua/Source/Generate/";    
    public static string toluaBaseType = Application.dataPath + "/Scripts/ToLua/ToLua/BaseType/";
    public static string baseLuaDir = Application.dataPath + "/Scripts/ToLua/ToLua/Lua/";
    public static string injectionFilesPath = Application.dataPath + "/Scripts/ToLua/ToLua/Injection/";

    //导出时强制做为静态类的类型(注意customTypeList 还要添加这个类型才能导出)
    //unity 有些类作为sealed class, 其实完全等价于静态类
    public static List<Type> staticClassTypes = new List<Type>
    {        
        typeof(UnityEngine.Application),
        typeof(UnityEngine.Time),
        typeof(UnityEngine.Screen),
        typeof(UnityEngine.SleepTimeout),
        typeof(UnityEngine.Input),
        typeof(UnityEngine.Resources),
        typeof(UnityEngine.Physics),
        typeof(UnityEngine.RenderSettings),
        typeof(UnityEngine.QualitySettings),
        typeof(UnityEngine.GL),
        typeof(UnityEngine.Graphics),
    };

    //附加导出委托类型(在导出委托时, customTypeList 中牵扯的委托类型都会导出， 无需写在这里)

    public static DelegateType[] customDelegateList = 
    {        
        _DT(typeof(Action)),                
        _DT(typeof(UnityEngine.Events.UnityAction)),
        _DT(typeof(System.Predicate<int>)),
        _DT(typeof(System.Action<int>)),
        _DT(typeof(System.Comparison<int>)),
        _DT(typeof(System.Func<int, int>)),
    };


    //在这里添加你要导出注册到lua的类型列表
    public static BindType[] customTypeList =
    {
        // Default
        _GT(typeof(InjectType)),
        
        // System
        _GT(typeof(System.Object)),
        
        // DOTween
        _GT(typeof(DG.Tweening.DOTween)),
        _GT(typeof(DG.Tweening.Tween)).SetBaseType(typeof(System.Object)).AddExtendType(typeof(DG.Tweening.TweenExtensions)),
        _GT(typeof(DG.Tweening.Sequence)).AddExtendType(typeof(DG.Tweening.TweenSettingsExtensions)),
        _GT(typeof(DG.Tweening.Tweener)).AddExtendType(typeof(DG.Tweening.TweenSettingsExtensions)),
        _GT(typeof(DG.Tweening.LoopType)),
        _GT(typeof(DG.Tweening.PathMode)),
        _GT(typeof(DG.Tweening.PathType)),
        _GT(typeof(DG.Tweening.RotateMode)),
        _GT(typeof(DG.Tweening.Ease)),

        // UnityEngine
        _GT(typeof(Object)),
        _GT(typeof(GameObject)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)).AddExtendType(typeof(Extensions)),
        _GT(typeof(Component)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)).AddExtendType(typeof(Extensions)),
        _GT(typeof(Transform)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Canvas)),
        _GT(typeof(Light)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(LineRenderer)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(TrailRenderer)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Material)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Camera)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Rigidbody)),
        _GT(typeof(AudioSource)),
        _GT(typeof(Texture)),
        _GT(typeof(Texture2D)),
        _GT(typeof(Texture3D)),
        _GT(typeof(TextureFormat)),
        _GT(typeof(RenderTexture)),
        _GT(typeof(RenderTextureFormat)),
        _GT(typeof(Sprite)),
        _GT(typeof(VideoPlayer)),
        _GT(typeof(VideoClip)),
        _GT(typeof(TextAsset)),
        _GT(typeof(Rect)),
        _GT(typeof(Matrix4x4)),
        _GT(typeof(Animator)),
        _GT(typeof(Animation)),
        _GT(typeof(AnimationClip)),
        _GT(typeof(AnimationEvent)),
        _GT(typeof(AnimationCurve)),
        _GT(typeof(AnimationState)),
        _GT(typeof(AnimatorStateInfo)),
        _GT(typeof(RuntimeAnimatorController)),
        _GT(typeof(Time)),
        _GT(typeof(GraphicRaycaster)),

        // UnityEngine.UI
        _GT(typeof(RectTransform)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(RectTransformUtility)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(CanvasScaler)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Image)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Text)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Button)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Toggle)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Slider)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(RawImage)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(CanvasGroup)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Shadow)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Outline)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(ScrollView)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        _GT(typeof(Scrollbar)).AddExtendType(typeof(DG.Tweening.ShortcutExtensions)),
        
        // Core.Script
        _GT(typeof(GameLogger)),
        _GT(typeof(VideoManager)),
        _GT(typeof(AssetManager)),
        _GT(typeof(AssetType)),
        _GT(typeof(UnityTimer)),
        _GT(typeof(Empty4Raycast)),
        _GT(typeof(UIEventListener)),
        _GT(typeof(DontDestroyOnLoad)),
        _GT(typeof(LuaBehaviour)),
        _GT(typeof(LuaUtil)),
    };


    public static List<Type> dynamicList = new List<Type>()
    {
        typeof(MeshRenderer),
        typeof(BoxCollider),
        typeof(MeshCollider),
        typeof(SphereCollider),
        typeof(CharacterController),
        typeof(CapsuleCollider),
        typeof(Animation),
        typeof(AnimationClip),
        typeof(AnimationState),
        typeof(SkinWeights),
        typeof(RenderTexture),
        typeof(Rigidbody),
    };

    //重载函数，相同参数个数，相同位置out参数匹配出问题时, 需要强制匹配解决
    //使用方法参见例子14
    public static List<Type> outList = new List<Type>()
    {
    };
        
    //ngui优化，下面的类没有派生类，可以作为sealed class
    public static List<Type> sealedList = new List<Type>()
    {
    };

    public static BindType _GT(Type t)
    {
        return new BindType(t);
    }

    public static DelegateType _DT(Type t)
    {
        return new DelegateType(t);
    }    
    
    [MenuItem("Lua/Attach Profiler", false, 151)]
    static void AttachProfiler()
    {
        if (!Application.isPlaying)
        {
            EditorUtility.DisplayDialog("警告", "请在运行时执行此功能", "确定");
            return;
        }

        LuaClient.Instance.AttachProfiler();
    }

    [MenuItem("Lua/Detach Profiler", false, 152)]
    static void DetachProfiler()
    {
        if (!Application.isPlaying)
        {            
            return;
        }

        LuaClient.Instance.DetachProfiler();
    }
}
