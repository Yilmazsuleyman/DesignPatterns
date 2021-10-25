using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Para
    {
        private int m_NominalDeger;

        protected Para(int NominalDeger)
        {
            m_NominalDeger = NominalDeger;
        }
        public string NominalDegeri { get { return m_NominalDeger.ToString() + " TL"; } }
    }

    public class Lira: Para
    {
        internal Lira(int Nominal_Deger): base(Nominal_Deger)
        {
            
        }
    }

    public abstract class DarpHane
    {
        public abstract Para ParaBas(int NominalDeger);
    }
    public class TCDarphane: DarpHane
    {
        public override Para ParaBas(int NominalDeger)
        {
            return new Lira(NominalDeger);
        }
    }

}
