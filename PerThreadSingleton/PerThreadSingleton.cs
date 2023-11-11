using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ? one threadInstance per thread literally
namespace PerThreadSingleton
{
    public sealed class PerThreadSingleton
    {
        private static ThreadLocal<PerThreadSingleton> threadInstance =
            new ThreadLocal<PerThreadSingleton>(() => new PerThreadSingleton());

        public int Id;

        private PerThreadSingleton() 
        {
            Id = Thread.CurrentThread.ManagedThreadId;
        }

        public static PerThreadSingleton Instance { get {  return threadInstance.Value; } }
    }
}
