using System.Collections.Generic;

namespace Mediator
{
    abstract class Oda
    {
        protected List<Katilimci> katilimcilar;

        protected Oda()
        {
            katilimcilar = new List<Katilimci>();
        }

        public void KatilimciEkle(Katilimci k)
        {
            if (!katilimcilar.Contains(k))
            {
                katilimcilar.Add(k);
            }
        }

        public abstract void MesajGonder(Katilimci gonderen, Katilimci alan, string mesaj);
        public abstract void BroadcastMesajGonder(Katilimci gonderen, string mesaj);
    }

}
