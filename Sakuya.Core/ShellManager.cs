using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakuya.Core
{
    public abstract class ShellManager<T, S>
        where S : Shell<T>
    {
        public delegate void ShellOpenedEventHandler(object sender, Shell<T> shell);
        public delegate void ShellClosedEventHandler(object sender, T id);

        private Dictionary<T, S> shells;

        public ShellManager()
        {
            shells = new Dictionary<T, S>();
        }

        public S this[T id]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public S OpenShell(T id)
        {
            throw new NotImplementedException();
        }

        protected abstract S CreateShell(T id);

        public void CloseShell(T id)
        {
            throw new NotImplementedException();
        }

        public event ShellOpenedEventHandler ShellOpened = (_, __) => { };
        public event ShellClosedEventHandler ShellClosed = (_, __) => { };
    }
}
