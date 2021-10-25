using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static volatile Singleton smp;

        private static Object lock_obj = new Object();

        private Singleton()
        {

        }

        public static Singleton createObject()
        {
            lock (lock_obj)
            {
                if (smp == null)
                {
                    smp = new Singleton();
                }
            }
            return smp;
        }
    }
}
