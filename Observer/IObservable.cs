using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObservable
    {
        void Register(Kontrol k);
        void Unregister(Kontrol k);
        void Notify();

    }

}
