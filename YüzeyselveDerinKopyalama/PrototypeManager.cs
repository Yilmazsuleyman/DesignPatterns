using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YüzeyselveDerinKopyalama
{
    [Serializable]
    public class PrototypeManager: PrototypeHelper<Hesap>
    {
        public Dictionary<string, Hesap> accounts = new Dictionary<string, Hesap> { {"1", new Hesap(1000, "Süleyman", "Yılmaz") }, { "2", new Hesap(1000, "Yılmaz", "Yılmaz") } };
    }
}
