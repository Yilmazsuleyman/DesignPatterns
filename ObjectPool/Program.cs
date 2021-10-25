using System;

namespace ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Conneciton cnn = new Conneciton("k1");
            cnn.Open();
            cnn.Execute("Select1");
            cnn.Close();
            Console.WriteLine("-------------------");

            Conneciton cnn2 = new Conneciton("k2");
            cnn2.Open();
            cnn2.Execute("Select2");
            cnn2.Close();
            Console.WriteLine("-------------------");

            Conneciton cnn3 = new Conneciton("k3");
            cnn3.Open();
            cnn3.Execute("Select3");
            cnn3.Close();
            Console.WriteLine("-------------------");
        }
    }
}
