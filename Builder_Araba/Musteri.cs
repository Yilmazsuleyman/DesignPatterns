using System;

namespace Builder_Araba
{
    class Musteri
    {
        public static void ArabaIstegi(Markalar marka, string model, params string[] istek_parcalar)
        {
            Acenta acenta = new Acenta();
            switch (marka)
            {
                case Markalar.BMW:
                    Bmw b = acenta.BmwTalebi(model, istek_parcalar);
                    Console.WriteLine(b.ToString());
                    break;
                case Markalar.AUDI:
                    Audi a = acenta.AudiTalebi(model, istek_parcalar);
                    Console.WriteLine(a.ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
