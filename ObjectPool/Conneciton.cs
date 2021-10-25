using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    public class Conneciton
    {
        private string connectionString;
        private PoolManager poolManager;
        private ConnectionContext con;

        public string ConnectionString { get { return connectionString; } set { connectionString = value; } }
        public Conneciton(string ConnectionString)
        {
            this.connectionString = ConnectionString;
        }

        public void Open()
        {
            poolManager = PoolManager.createPool();
            con = poolManager.TakeConnection(this.connectionString);

            if (con != null)
            {
                con.Open();
            }
            else
            {
                Console.WriteLine("Havuzda hiç uygun nesne yok.");
            }
        }
        public void Close()
        {
            poolManager.ReleaseConnection(con);
            con.Close();
        }
        public void Execute(string query)
        {
            con.Execute(query);
        }

    }
}
