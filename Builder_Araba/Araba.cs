using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Araba
{
    abstract class Araba
    {
        protected List<string> zorunlu_parcalar;
        protected List<string> opsiyonel_parcalar;
        protected string model;

        public List<string> OpsiyonelParcalar { get { return opsiyonel_parcalar; } set { opsiyonel_parcalar = value; } }

        public Araba()
        {
            zorunlu_parcalar = new List<string>();
            zorunlu_parcalar.AddRange(new string[] { "Rotil", "Salıncak", "Egzantirik Mili", "Krank Mili", "Yağ Pompası", "Radyatör", "Buji", "Tekerlek", "Egzost"});
            opsiyonel_parcalar = new List<string>();
        }
    }
}
