﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using DG.Tweening;
using LuaInterface;

public class UnityEngine_UI_CanvasScalerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.CanvasScaler), typeof(UnityEngine.EventSystems.UIBehaviour));
		L.RegFunction("DOTogglePause", DOTogglePause);
		L.RegFunction("DOSmoothRewind", DOSmoothRewind);
		L.RegFunction("DORewind", DORewind);
		L.RegFunction("DORestart", DORestart);
		L.RegFunction("DOPlayForward", DOPlayForward);
		L.RegFunction("DOPlayBackwards", DOPlayBackwards);
		L.RegFunction("DOPlay", DOPlay);
		L.RegFunction("DOPause", DOPause);
		L.RegFunction("DOGoto", DOGoto);
		L.RegFunction("DOFlip", DOFlip);
		L.RegFunction("DOKill", DOKill);
		L.RegFunction("DOComplete", DOComplete);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("uiScaleMode", get_uiScaleMode, set_uiScaleMode);
		L.RegVar("referencePixelsPerUnit", get_referencePixelsPerUnit, set_referencePixelsPerUnit);
		L.RegVar("scaleFactor", get_scaleFactor, set_scaleFactor);
		L.RegVar("referenceResolution", get_referenceResolution, set_referenceResolution);
		L.RegVar("screenMatchMode", get_screenMatchMode, set_screenMatchMode);
		L.RegVar("matchWidthOrHeight", get_matchWidthOrHeight, set_matchWidthOrHeight);
		L.RegVar("physicalUnit", get_physicalUnit, set_physicalUnit);
		L.RegVar("fallbackScreenDPI", get_fallbackScreenDPI, set_fallbackScreenDPI);
		L.RegVar("defaultSpriteDPI", get_defaultSpriteDPI, set_defaultSpriteDPI);
		L.RegVar("dynamicPixelsPerUnit", get_dynamicPixelsPerUnit, set_dynamicPixelsPerUnit);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOTogglePause(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
			int o = obj.DOTogglePause();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOSmoothRewind(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
			int o = obj.DOSmoothRewind();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DORewind(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
				int o = obj.DORewind();
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				int o = obj.DORewind(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.UI.CanvasScaler.DORewind");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DORestart(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
				int o = obj.DORestart();
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				int o = obj.DORestart(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.UI.CanvasScaler.DORestart");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOPlayForward(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
			int o = obj.DOPlayForward();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOPlayBackwards(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
			int o = obj.DOPlayBackwards();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOPlay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
			int o = obj.DOPlay();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOPause(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
			int o = obj.DOPause();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOGoto(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				int o = obj.DOGoto(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				int o = obj.DOGoto(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.UI.CanvasScaler.DOGoto");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOFlip(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
			int o = obj.DOFlip();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOKill(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
				int o = obj.DOKill();
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				int o = obj.DOKill(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.UI.CanvasScaler.DOKill");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DOComplete(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
				int o = obj.DOComplete();
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)ToLua.CheckObject<UnityEngine.UI.CanvasScaler>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				int o = obj.DOComplete(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.UI.CanvasScaler.DOComplete");
			}
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
	static int get_uiScaleMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			UnityEngine.UI.CanvasScaler.ScaleMode ret = obj.uiScaleMode;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uiScaleMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_referencePixelsPerUnit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float ret = obj.referencePixelsPerUnit;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index referencePixelsPerUnit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scaleFactor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float ret = obj.scaleFactor;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scaleFactor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_referenceResolution(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			UnityEngine.Vector2 ret = obj.referenceResolution;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index referenceResolution on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_screenMatchMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			UnityEngine.UI.CanvasScaler.ScreenMatchMode ret = obj.screenMatchMode;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index screenMatchMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_matchWidthOrHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float ret = obj.matchWidthOrHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index matchWidthOrHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_physicalUnit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			UnityEngine.UI.CanvasScaler.Unit ret = obj.physicalUnit;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index physicalUnit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fallbackScreenDPI(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float ret = obj.fallbackScreenDPI;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fallbackScreenDPI on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultSpriteDPI(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float ret = obj.defaultSpriteDPI;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index defaultSpriteDPI on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dynamicPixelsPerUnit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float ret = obj.dynamicPixelsPerUnit;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dynamicPixelsPerUnit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_uiScaleMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			UnityEngine.UI.CanvasScaler.ScaleMode arg0 = (UnityEngine.UI.CanvasScaler.ScaleMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.CanvasScaler.ScaleMode));
			obj.uiScaleMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index uiScaleMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_referencePixelsPerUnit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.referencePixelsPerUnit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index referencePixelsPerUnit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scaleFactor(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.scaleFactor = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scaleFactor on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_referenceResolution(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.referenceResolution = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index referenceResolution on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_screenMatchMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			UnityEngine.UI.CanvasScaler.ScreenMatchMode arg0 = (UnityEngine.UI.CanvasScaler.ScreenMatchMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode));
			obj.screenMatchMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index screenMatchMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_matchWidthOrHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.matchWidthOrHeight = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index matchWidthOrHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_physicalUnit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			UnityEngine.UI.CanvasScaler.Unit arg0 = (UnityEngine.UI.CanvasScaler.Unit)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.CanvasScaler.Unit));
			obj.physicalUnit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index physicalUnit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fallbackScreenDPI(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.fallbackScreenDPI = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fallbackScreenDPI on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultSpriteDPI(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.defaultSpriteDPI = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index defaultSpriteDPI on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dynamicPixelsPerUnit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.CanvasScaler obj = (UnityEngine.UI.CanvasScaler)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.dynamicPixelsPerUnit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dynamicPixelsPerUnit on a nil value");
		}
	}
}
