using System;

namespace Banka_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            BireyselMusteri bm = new BireyselMusteri("Süleyman", "Yılmaz");
            KurumsalMusteri km = new KurumsalMusteri("Hakan", "Alpaslan", "Odeon Yazılım");

            KrediKullanimi.Leasing(bm);
            KrediKullanimi.Mortgage(bm);
            KrediKullanimi.Leasing(km);
            KrediKullanimi.Mortgage(km);
        }
    }
}
