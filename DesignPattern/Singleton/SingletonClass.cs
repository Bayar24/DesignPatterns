using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    //Not Tread safe and bad implementation
    public sealed class BadSingletonClass
    {
        private static BadSingletonClass badSingletonClass = null;
        private BadSingletonClass()
        {

        }
        public static BadSingletonClass GetInstane()
        {
            if (badSingletonClass == null)
                badSingletonClass = new BadSingletonClass();
            return badSingletonClass;
        }
    }
    //Thread safe but has many downsides
    public sealed class ThreadSafeSingletonClass
    {
        private static ThreadSafeSingletonClass threadSafeSingletonClass = null;
        private static readonly object padlock = new object();
        private ThreadSafeSingletonClass()
        {

        }
        public static ThreadSafeSingletonClass GetInstane()
        {
            lock (padlock)
            {
                if (threadSafeSingletonClass == null)
                    threadSafeSingletonClass = new ThreadSafeSingletonClass();
                return threadSafeSingletonClass;
            }
        }
    }
    //Can be best version but not lazy loaded
    public sealed class NoLockSingletonClass
    {
        private static readonly NoLockSingletonClass noLockSingletonClass = new NoLockSingletonClass();
        private NoLockSingletonClass()
        {

        }
        public static NoLockSingletonClass GetInstane()
        {
            return noLockSingletonClass;
        }
    }
    public sealed class LazySingletonClass
    {
        private static readonly Lazy<LazySingletonClass> lazySingletonClass = new Lazy<LazySingletonClass>(() => new LazySingletonClass());
        private LazySingletonClass()
        {

        }
        public static LazySingletonClass GetInstane()
        {
            return lazySingletonClass.Value;
        }
    }
}
