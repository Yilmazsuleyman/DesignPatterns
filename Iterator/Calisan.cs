using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Calisan
    {
        private string kimlik;
        private string Unvan;

        public Calisan(string kimlik, string Unvan)
        {
            this.kimlik = kimlik;
            this.Unvan = Unvan;
        }
        public override string ToString()
        {
            return kimlik + " " + Unvan;
        }
    }
}
