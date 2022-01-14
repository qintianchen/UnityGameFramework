﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIEventListenerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIEventListener), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("OnPointerClick", OnPointerClick);
		L.RegFunction("OnPointerDown", OnPointerDown);
		L.RegFunction("OnPointerUp", OnPointerUp);
		L.RegFunction("OnBeginDrag", OnBeginDrag);
		L.RegFunction("OnDrag", OnDrag);
		L.RegFunction("OnEndDrag", OnEndDrag);
		L.RegFunction("OnSelect", OnSelect);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("onClick", get_onClick, set_onClick);
		L.RegVar("onPointerDown", get_onPointerDown, set_onPointerDown);
		L.RegVar("onPointerUp", get_onPointerUp, set_onPointerUp);
		L.RegVar("onBeginDrag", get_onBeginDrag, set_onBeginDrag);
		L.RegVar("onDrag", get_onDrag, set_onDrag);
		L.RegVar("onEndDrag", get_onEndDrag, set_onEndDrag);
		L.RegVar("onSelect", get_onSelect, set_onSelect);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject<UIEventListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerClick(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject<UIEventListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerDown(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject<UIEventListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerUp(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBeginDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject<UIEventListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnBeginDrag(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject<UIEventListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnDrag(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEndDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject<UIEventListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnEndDrag(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSelect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UIEventListener obj = (UIEventListener)ToLua.CheckObject<UIEventListener>(L, 1);
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject<UnityEngine.EventSystems.BaseEventData>(L, 2);
			obj.OnSelect(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> ret = obj.onClick;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPointerDown(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> ret = obj.onPointerDown;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onPointerDown on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPointerUp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> ret = obj.onPointerUp;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onPointerUp on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onBeginDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> ret = obj.onBeginDrag;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onBeginDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> ret = obj.onDrag;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onEndDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> ret = obj.onEndDrag;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEndDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onSelect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> ret = obj.onSelect;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onSelect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> arg0 = (System.Action<UnityEngine.EventSystems.PointerEventData>)ToLua.CheckDelegate<System.Action<UnityEngine.EventSystems.PointerEventData>>(L, 2);
			obj.onClick = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPointerDown(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> arg0 = (System.Action<UnityEngine.EventSystems.PointerEventData>)ToLua.CheckDelegate<System.Action<UnityEngine.EventSystems.PointerEventData>>(L, 2);
			obj.onPointerDown = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onPointerDown on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPointerUp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> arg0 = (System.Action<UnityEngine.EventSystems.PointerEventData>)ToLua.CheckDelegate<System.Action<UnityEngine.EventSystems.PointerEventData>>(L, 2);
			obj.onPointerUp = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onPointerUp on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onBeginDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> arg0 = (System.Action<UnityEngine.EventSystems.PointerEventData>)ToLua.CheckDelegate<System.Action<UnityEngine.EventSystems.PointerEventData>>(L, 2);
			obj.onBeginDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onBeginDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> arg0 = (System.Action<UnityEngine.EventSystems.PointerEventData>)ToLua.CheckDelegate<System.Action<UnityEngine.EventSystems.PointerEventData>>(L, 2);
			obj.onDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onEndDrag(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> arg0 = (System.Action<UnityEngine.EventSystems.PointerEventData>)ToLua.CheckDelegate<System.Action<UnityEngine.EventSystems.PointerEventData>>(L, 2);
			obj.onEndDrag = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEndDrag on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSelect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIEventListener obj = (UIEventListener)o;
			System.Action<UnityEngine.EventSystems.PointerEventData> arg0 = (System.Action<UnityEngine.EventSystems.PointerEventData>)ToLua.CheckDelegate<System.Action<UnityEngine.EventSystems.PointerEventData>>(L, 2);
			obj.onSelect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onSelect on a nil value");
		}
	}
}
