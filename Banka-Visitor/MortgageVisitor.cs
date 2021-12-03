using System;

namespace Banka_Visitor
{
    class MortgageVisitor : IVisitor
    {
        public void Visit(Musteri m)
        {
            if (m is BireyselMusteri)
            {
                Console.WriteLine("Bireysel Müşteri Mortgage yapabilir");
            }
            if (m is KurumsalMusteri)
            {
                Console.WriteLine("Kurumsal Müşteri Mortgage yapamaz");
            }
        }
    }
}