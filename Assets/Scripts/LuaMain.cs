using LuaInterface;
using UnityEngine;

namespace QTC
{
    public class LuaMain: SingleTon<LuaMain>
    {
        public LuaState lua;

        private Behaviour behaviour;

        public void Init(Behaviour behaviour)
        {
            this.behaviour = behaviour;
            
            lua = new LuaState();
            lua.LuaSetTop(0);
            LuaBinder.Bind(lua);
            DelegateFactory.Init();
            LuaCoroutine.Register(lua, this.behaviour.GetComponent<MonoBehaviour>());
            lua.Start();
            
            lua.DoFile("Main");
        }
    }
}