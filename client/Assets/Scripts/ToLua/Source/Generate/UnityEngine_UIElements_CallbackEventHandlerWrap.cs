﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UIElements_CallbackEventHandlerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UIElements.CallbackEventHandler), typeof(System.Object));
		L.RegFunction("SendEvent", SendEvent);
		L.RegFunction("HandleEvent", HandleEvent);
		L.RegFunction("HasTrickleDownHandlers", HasTrickleDownHandlers);
		L.RegFunction("HasBubbleUpHandlers", HasBubbleUpHandlers);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UIElements.CallbackEventHandler obj = (UnityEngine.UIElements.CallbackEventHandler)ToLua.CheckObject<UnityEngine.UIElements.CallbackEventHandler>(L, 1);
			UnityEngine.UIElements.EventBase arg0 = (UnityEngine.UIElements.EventBase)ToLua.CheckObject<UnityEngine.UIElements.EventBase>(L, 2);
			obj.SendEvent(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HandleEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UIElements.CallbackEventHandler obj = (UnityEngine.UIElements.CallbackEventHandler)ToLua.CheckObject<UnityEngine.UIElements.CallbackEventHandler>(L, 1);
			UnityEngine.UIElements.EventBase arg0 = (UnityEngine.UIElements.EventBase)ToLua.CheckObject<UnityEngine.UIElements.EventBase>(L, 2);
			obj.HandleEvent(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasTrickleDownHandlers(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UIElements.CallbackEventHandler obj = (UnityEngine.UIElements.CallbackEventHandler)ToLua.CheckObject<UnityEngine.UIElements.CallbackEventHandler>(L, 1);
			bool o = obj.HasTrickleDownHandlers();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasBubbleUpHandlers(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UIElements.CallbackEventHandler obj = (UnityEngine.UIElements.CallbackEventHandler)ToLua.CheckObject<UnityEngine.UIElements.CallbackEventHandler>(L, 1);
			bool o = obj.HasBubbleUpHandlers();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
