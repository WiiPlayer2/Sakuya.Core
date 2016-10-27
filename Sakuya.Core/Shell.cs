using SharpLua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakuya.Core
{
    public class Shell<T> : IDisposable
    {
        public Shell(T id)
        {
            ID = id;

            Lua = new LuaInterface();

            RemoveVars("new", "SharpLua", "Lua", "System", "clr", "luanet");
        }

        public LuaInterface Lua { get; private set; }

        public T ID { get; protected set; }

        private void RemoveVars(params string[] names)
        {
            foreach (var n in names)
            {
                Lua.DoString(string.Format("{0} = nil", n));
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
