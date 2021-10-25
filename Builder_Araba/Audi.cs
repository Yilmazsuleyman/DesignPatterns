using System.Text;

namespace Builder_Araba
{
    class Audi : Araba
    {
        public string Model { get { return base.model; } set { base.model = value; } }
        public Audi() : base()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("AUDI {0} \n\r", model);

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
