using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Katilimci k1 = new NormalKatilimci("aykut");
            Katilimci k2 = new NormalKatilimci("suleyman");
            Katilimci k3 = new NormalKatilimci("yılmaz");
            Katilimci k4 = new Moderator("janset");

            YazilimOdasi oda1 = new YazilimOdasi();

            oda1.KatilimciEkle(k1);
            oda1.KatilimciEkle(k2);
            oda1.KatilimciEkle(k3);
            oda1.KatilimciEkle(k4);

            oda1.BroadcastMesajGonder(k4, "Herkese merhaba");

            oda1.MesajGonder(k1, k3, "Kurs ne zaman başlıyor?");
            oda1.MesajGonder(k3, k1, "Ekimde");
        }
    }
}
