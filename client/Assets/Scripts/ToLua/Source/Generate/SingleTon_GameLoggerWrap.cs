//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SingleTon_GameLoggerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SingleTon<GameLogger>), typeof(System.Object), "SingleTon_GameLogger");
		L.RegFunction("New", _CreateSingleTon_GameLogger);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSingleTon_GameLogger(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SingleTon<GameLogger> obj = new SingleTon<GameLogger>();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SingleTon<GameLogger>.New");
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
			ToLua.PushObject(L, SingleTon<GameLogger>.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

