using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    public class ConnectionContext
    {
        private bool is_Active;
        //Nesne kullanılıyor mu?

        public bool isActive { get { return is_Active; } set { is_Active = value; } }

        public ConnectionContext()
        {
            is_Active = false;
            Console.WriteLine("ConnectionContext yaratıldı.");
        }

        public void Open()
        {
            Console.WriteLine("Connection açıldı.");
        }
        public void Close()
        {
            Console.WriteLine("Connection kapandı.");
        }
        public void Execute(string query)
        {
            Console.WriteLine(query + " çalıştı" );
        }
    }
}
