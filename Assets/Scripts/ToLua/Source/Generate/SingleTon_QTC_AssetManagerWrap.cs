﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SingleTon_QTC_AssetManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SingleTon<QTC.AssetManager>), typeof(System.Object), "SingleTon_QTC_AssetManager");
		L.RegFunction("New", _CreateSingleTon_QTC_AssetManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSingleTon_QTC_AssetManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SingleTon<QTC.AssetManager> obj = new SingleTon<QTC.AssetManager>();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SingleTon<QTC.AssetManager>.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, SingleTon<QTC.AssetManager>.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
