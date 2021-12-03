using System.Collections.Generic;

namespace Observer
{
    public class Stok : IObservable
    {
        private int m_Adet;
        private List<Kontrol> kontroller;

        public Stok()
        {
            kontroller = new List<Kontrol>();
            m_Adet = 10;
        }
        public void ElemanCek()
        {
            --m_Adet;
        }
        public void Register(Kontrol k)
        {
            kontroller.Add(k);
        }
        public void Unregister(Kontrol k)
        {
            kontroller.Remove(k);
        }
        public void Notify()
        {
            for (int i = 0; i < kontroller.Count; i++)
            {
                kontroller[i].onAction(m_Adet.ToString());
            }
        }
    }
}
