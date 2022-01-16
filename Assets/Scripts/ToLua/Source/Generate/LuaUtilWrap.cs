﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaUtilWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("LuaUtil");
		L.RegFunction("TransformFind", TransformFind);
		L.RegFunction("SetButton", SetButton);
		L.RegFunction("SetText", SetText);
		L.RegFunction("SetActive", SetActive);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransformFind(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.GameObject, string>(L, 1))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				UnityEngine.Transform o = LuaUtil.TransformFind(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Component, string>(L, 1))
			{
				UnityEngine.Component arg0 = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				UnityEngine.Transform o = LuaUtil.TransformFind(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaUtil.TransformFind");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetButton(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.GameObject, LuaInterface.LuaFunction>(L, 1))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				LuaFunction arg1 = ToLua.ToLuaFunction(L, 2);
				LuaUtil.SetButton(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Component, LuaInterface.LuaFunction>(L, 1))
			{
				UnityEngine.Component arg0 = (UnityEngine.Component)ToLua.ToObject(L, 1);
				LuaFunction arg1 = ToLua.ToLuaFunction(L, 2);
				LuaUtil.SetButton(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaUtil.SetButton");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetText(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.GameObject, string>(L, 1))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				LuaUtil.SetText(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Component, string>(L, 1))
			{
				UnityEngine.Component arg0 = (UnityEngine.Component)ToLua.ToObject(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				LuaUtil.SetText(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaUtil.SetText");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetActive(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.GameObject, bool>(L, 1))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				LuaUtil.SetActive(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Component, bool>(L, 1))
			{
				UnityEngine.Component arg0 = (UnityEngine.Component)ToLua.ToObject(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				LuaUtil.SetActive(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: LuaUtil.SetActive");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

