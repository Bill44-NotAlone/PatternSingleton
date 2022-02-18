using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingletonLib
{
    public class Singleton 
    {
        private static Singleton singleton;
        private Singleton() { }
        public static Singleton GetSingleton()
        {
            if (singleton == null) singleton = new Singleton();
            return singleton;
        }
    }
}
