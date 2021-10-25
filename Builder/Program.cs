using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] part_List1 = {"a", "b", "c"};
            string[] part_List2 = { "d", "e", "f" };

            Builder b = new ConcreteBuilder1();
            Director.Construct(b, part_List1);
            Product p1 = b.GetProduct();
            Console.WriteLine(p1.ToString());

            b = new ConcreteBuilder2();
            Director.Construct(b, part_List2);
            Product p2 = b.GetProduct();
            Console.WriteLine(p2.ToString());

        }
    }
}
