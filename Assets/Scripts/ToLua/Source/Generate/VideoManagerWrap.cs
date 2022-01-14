﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class VideoManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(VideoManager), typeof(SingleTon<VideoManager>));
		L.RegFunction("Init", Init);
		L.RegFunction("Play", Play);
		L.RegFunction("Pause", Pause);
		L.RegFunction("New", _CreateVideoManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("videoPlayer", get_videoPlayer, set_videoPlayer);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateVideoManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				VideoManager obj = new VideoManager();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: VideoManager.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			VideoManager obj = (VideoManager)ToLua.CheckObject<VideoManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.GameObject arg1 = (UnityEngine.GameObject)ToLua.CheckObject(L, 3, typeof(UnityEngine.GameObject));
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			obj.Init(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			VideoManager obj = (VideoManager)ToLua.CheckObject<VideoManager>(L, 1);
			obj.Play();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Pause(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			VideoManager obj = (VideoManager)ToLua.CheckObject<VideoManager>(L, 1);
			obj.Pause();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_videoPlayer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			VideoManager obj = (VideoManager)o;
			UnityEngine.Video.VideoPlayer ret = obj.videoPlayer;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index videoPlayer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_videoPlayer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			VideoManager obj = (VideoManager)o;
			UnityEngine.Video.VideoPlayer arg0 = (UnityEngine.Video.VideoPlayer)ToLua.CheckObject(L, 2, typeof(UnityEngine.Video.VideoPlayer));
			obj.videoPlayer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index videoPlayer on a nil value");
		}
	}
}
