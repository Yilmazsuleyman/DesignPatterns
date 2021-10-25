using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            TCDarphane darphane = new TCDarphane();
            Lira tl = (Lira)darphane.ParaBas(200);
            Console.WriteLine(tl.NominalDegeri);
        }
    }
}
