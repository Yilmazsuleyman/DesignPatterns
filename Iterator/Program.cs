using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            IKDepartmani ik = new IKDepartmani();
            Iterator itr = ik.GetIterator();

            while (itr.next())
            {
                Console.WriteLine(itr.getItem().ToString());
            }


            ADKDepartmani adk = new ADKDepartmani();
            itr = adk.GetIterator();

            while (itr.next())
            {
                Console.WriteLine(itr.getItem().ToString());
            }
        }


    }

}
