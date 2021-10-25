using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Araba
{
    class Bmw : Araba
    {
        public string Model { get { return base.model; } set { base.model = value; } }
        public Bmw() : base()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("BMW {0} \n\r", model);

            for (int i = 0; i < zorunlu_parcalar.Count; i++)
            {
                sb.AppendLine(zorunlu_parcalar[i] + "\n\r");
            }
            for (int i = 0; i < OpsiyonelParcalar.Count; i++)
            {
                sb.AppendLine(OpsiyonelParcalar[i] + "\n\r");
            }
            return sb.ToString();
        }
    }
}
