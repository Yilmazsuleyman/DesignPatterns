using System;

namespace Builder_Araba
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri.ArabaIstegi(Markalar.BMW, "1.6", "ESP", "Digital Klima", "Mat Boya");
            Musteri.ArabaIstegi(Markalar.AUDI, "1.6", "Digital Klima", "Çelik Jant", "Sunroof");
        }
    }
}
