using System;

namespace Banka_Visitor
{
    class LeasingVisitor : IVisitor
    {
        public void Visit(Musteri m)
        {
            if (m is BireyselMusteri)
            {
                Console.WriteLine("Bireysel Müşteri Leasing kullanamaz");
            }
            if (m is KurumsalMusteri)
            {
                Console.WriteLine("Kurumsal Müşteri Leasing kullanabilir");
            }
        }
    }
}