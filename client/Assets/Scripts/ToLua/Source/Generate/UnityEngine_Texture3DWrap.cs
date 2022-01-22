﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Texture3DWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Texture3D), typeof(UnityEngine.Texture));
		L.RegFunction("UpdateExternalTexture", UpdateExternalTexture);
		L.RegFunction("GetPixels", GetPixels);
		L.RegFunction("GetPixels32", GetPixels32);
		L.RegFunction("SetPixels", SetPixels);
		L.RegFunction("SetPixels32", SetPixels32);
		L.RegFunction("CreateExternalTexture", CreateExternalTexture);
		L.RegFunction("Apply", Apply);
		L.RegFunction("SetPixel", SetPixel);
		L.RegFunction("GetPixel", GetPixel);
		L.RegFunction("GetPixelBilinear", GetPixelBilinear);
		L.RegFunction("New", _CreateUnityEngine_Texture3D);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("depth", get_depth, null);
		L.RegVar("format", get_format, null);
		L.RegVar("isReadable", get_isReadable, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Texture3D(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5 && TypeChecker.CheckTypes<UnityEngine.TextureFormat, int>(L, 4))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.TextureFormat arg3 = (UnityEngine.TextureFormat)ToLua.ToObject(L, 4);
				int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
				UnityEngine.Texture3D obj = new UnityEngine.Texture3D(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 5 && TypeChecker.CheckTypes<UnityEngine.TextureFormat, bool>(L, 4))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.TextureFormat arg3 = (UnityEngine.TextureFormat)ToLua.ToObject(L, 4);
				bool arg4 = LuaDLL.lua_toboolean(L, 5);
				UnityEngine.Texture3D obj = new UnityEngine.Texture3D(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 5 && TypeChecker.CheckTypes<UnityEngine.Experimental.Rendering.DefaultFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 4))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Experimental.Rendering.DefaultFormat arg3 = (UnityEngine.Experimental.Rendering.DefaultFormat)ToLua.ToObject(L, 4);
				UnityEngine.Experimental.Rendering.TextureCreationFlags arg4 = (UnityEngine.Experimental.Rendering.TextureCreationFlags)ToLua.ToObject(L, 5);
				UnityEngine.Texture3D obj = new UnityEngine.Texture3D(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 5 && TypeChecker.CheckTypes<UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 4))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Experimental.Rendering.GraphicsFormat arg3 = (UnityEngine.Experimental.Rendering.GraphicsFormat)ToLua.ToObject(L, 4);
				UnityEngine.Experimental.Rendering.TextureCreationFlags arg4 = (UnityEngine.Experimental.Rendering.TextureCreationFlags)ToLua.ToObject(L, 5);
				UnityEngine.Texture3D obj = new UnityEngine.Texture3D(arg0, arg1, arg2, arg3, arg4);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 6 && TypeChecker.CheckTypes<UnityEngine.TextureFormat, int, System.IntPtr>(L, 4))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.TextureFormat arg3 = (UnityEngine.TextureFormat)ToLua.ToObject(L, 4);
				int arg4 = (int)LuaDLL.lua_tonumber(L, 5);
				System.IntPtr arg5 = ToLua.CheckIntPtr(L, 6);
				UnityEngine.Texture3D obj = new UnityEngine.Texture3D(arg0, arg1, arg2, arg3, arg4, arg5);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 6 && TypeChecker.CheckTypes<UnityEngine.TextureFormat, bool, System.IntPtr>(L, 4))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.TextureFormat arg3 = (UnityEngine.TextureFormat)ToLua.ToObject(L, 4);
				bool arg4 = LuaDLL.lua_toboolean(L, 5);
				System.IntPtr arg5 = ToLua.CheckIntPtr(L, 6);
				UnityEngine.Texture3D obj = new UnityEngine.Texture3D(arg0, arg1, arg2, arg3, arg4, arg5);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 6 && TypeChecker.CheckTypes<UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags, int>(L, 4))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Experimental.Rendering.GraphicsFormat arg3 = (UnityEngine.Experimental.Rendering.GraphicsFormat)ToLua.ToObject(L, 4);
				UnityEngine.Experimental.Rendering.TextureCreationFlags arg4 = (UnityEngine.Experimental.Rendering.TextureCreationFlags)ToLua.ToObject(L, 5);
				int arg5 = (int)LuaDLL.lua_tonumber(L, 6);
				UnityEngine.Texture3D obj = new UnityEngine.Texture3D(arg0, arg1, arg2, arg3, arg4, arg5);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Texture3D.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateExternalTexture(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
			System.IntPtr arg0 = ToLua.CheckIntPtr(L, 2);
			obj.UpdateExternalTexture(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixels(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				UnityEngine.Color[] o = obj.GetPixels();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.Color[] o = obj.GetPixels(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture3D.GetPixels");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixels32(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				UnityEngine.Color32[] o = obj.GetPixels32();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.Color32[] o = obj.GetPixels32(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture3D.GetPixels32");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPixels(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				UnityEngine.Color[] arg0 = ToLua.CheckStructArray<UnityEngine.Color>(L, 2);
				obj.SetPixels(arg0);
				return 0;
			}
			else if (count == 3)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				UnityEngine.Color[] arg0 = ToLua.CheckStructArray<UnityEngine.Color>(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				obj.SetPixels(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture3D.SetPixels");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPixels32(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				UnityEngine.Color32[] arg0 = ToLua.CheckStructArray<UnityEngine.Color32>(L, 2);
				obj.SetPixels32(arg0);
				return 0;
			}
			else if (count == 3)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				UnityEngine.Color32[] arg0 = ToLua.CheckStructArray<UnityEngine.Color32>(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				obj.SetPixels32(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture3D.SetPixels32");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateExternalTexture(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
			UnityEngine.TextureFormat arg3 = (UnityEngine.TextureFormat)ToLua.CheckObject(L, 4, typeof(UnityEngine.TextureFormat));
			bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
			System.IntPtr arg5 = ToLua.CheckIntPtr(L, 6);
			UnityEngine.Texture3D o = UnityEngine.Texture3D.CreateExternalTexture(arg0, arg1, arg2, arg3, arg4, arg5);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Apply(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				obj.Apply();
				return 0;
			}
			else if (count == 2)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.Apply(arg0);
				return 0;
			}
			else if (count == 3)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.Apply(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture3D.Apply");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPixel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 5)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Color arg3 = ToLua.ToColor(L, 5);
				obj.SetPixel(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 6)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Color arg3 = ToLua.ToColor(L, 5);
				int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
				obj.SetPixel(arg0, arg1, arg2, arg3, arg4);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture3D.SetPixel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Color o = obj.GetPixel(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 5)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
				UnityEngine.Color o = obj.GetPixel(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture3D.GetPixel");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixelBilinear(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				UnityEngine.Color o = obj.GetPixelBilinear(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 5)
			{
				UnityEngine.Texture3D obj = (UnityEngine.Texture3D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture3D));
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
				UnityEngine.Color o = obj.GetPixelBilinear(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture3D.GetPixelBilinear");
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
	static int get_depth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture3D obj = (UnityEngine.Texture3D)o;
			int ret = obj.depth;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index depth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_format(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture3D obj = (UnityEngine.Texture3D)o;
			UnityEngine.TextureFormat ret = obj.format;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index format on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isReadable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture3D obj = (UnityEngine.Texture3D)o;
			bool ret = obj.isReadable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isReadable on a nil value");
		}
	}
}
