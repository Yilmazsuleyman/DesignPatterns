using System;

namespace ChainOfResponsibility
{
    public class Operator
    {
        private bool durum;
        private string isim;
        private Operator sonraki_operator;

        public Operator Sonraki { get { return sonraki_operator; } set { sonraki_operator = value; } }

        public Operator(string isim)
        {
            this.isim = isim;
        }
        public string Isim{ get { return isim; } set { isim = value; } }
        public bool Durum{ get { return durum; } set { durum = value; } }

        public void CagriCevapla()
        {
            if (durum)
            {
                Console.WriteLine(isim + " çağrıyı cevapladı.");
            }
            else if (sonraki_operator != null)
            {
                sonraki_operator.CagriCevapla();
            }
            else
            {
                Console.WriteLine("Çağrı beklemede.");
            }
        }

    }
}
