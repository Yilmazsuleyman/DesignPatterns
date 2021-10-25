using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Sample
    {
        private static Sample mp_Smp;
        private int m_Data;

        protected Sample()
        {

        }
        //Singleton
     /*   public static Sample CreateObject()
        {
            if (mp_Smp == null)
            {
                mp_Smp = new Sample();
            }
            return mp_Smp;
        }*/
        public int GetData()
        {
            return m_Data;
        }
        public void SetData(int value)
        {
            m_Data = value;
        }

        private static Object lock_obj = new Object();

        //Multi Thread Singleton
        public static Sample CreateObject()
        {
            if (mp_Smp == null)
            {
                lock (lock_obj)
                {
                    if (mp_Smp == null)
                    {
                        mp_Smp = new Sample();
                    }
                } 
            }
            return mp_Smp;
        }
    }
}
