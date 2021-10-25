using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj1 = Sample.CreateObject();
            Sample obj2 = Sample.CreateObject();

            obj1.SetData(50);

            Console.WriteLine(obj1.GetData());
            Console.WriteLine(obj2.GetData());
        }
    }
}
