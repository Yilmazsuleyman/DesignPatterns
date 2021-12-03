using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class CallCenter
    {
        private List<Operator> acentalar = new List<Operator>();

        public CallCenter()
        {
            Operator o1 = new Operator("Aykut");
            Operator o2 = new Operator("Süleyman");
            Operator o3 = new Operator("Yılmaz");

            o1.Durum = false;
            o2.Durum = false;
            o3.Durum = true;

            o1.Sonraki = o2;
            o2.Sonraki = o3;
            o3.Sonraki = null;

            Operator[] elemanlar = { o2, o1, o3};

            acentalar.AddRange(elemanlar);
        }

        public void CagriAl()
        {
            acentalar[0].CagriCevapla();
        }
    }
}
