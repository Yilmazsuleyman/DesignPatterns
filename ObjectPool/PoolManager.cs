using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    public class PoolManager
    {
        private const int POOL_SIZE = 10;
        protected static PoolManager pm;
        private Dictionary<string, List<ConnectionContext>> pools;

        protected PoolManager()
        {
            pools = new Dictionary<string, List<ConnectionContext>>(POOL_SIZE);
        }
        public static PoolManager createPool()
        {
            //PoolManager singleton
            if (pm==null)
            {
                pm = new PoolManager();

            }
            return pm;
        }
        public ConnectionContext TakeConnection(string key)
        {
            if (pools.ContainsKey(key))
            {
                List<ConnectionContext> objects = (List<ConnectionContext>)pools[key];
                foreach (ConnectionContext cu in objects)
                {
                    if (!cu.isActive)
                    {
                        return cu;
                    }
                }
            }
            else
            {
                List<ConnectionContext> newPool = new List<ConnectionContext>(POOL_SIZE);
                for (int i = 0; i < POOL_SIZE; i++)
                {
                    newPool.Add(new ConnectionContext());
                }
                pools.Add(key, newPool);

                ConnectionContext cu = newPool[0];
                cu.isActive = true;
                return cu;
            }
            return null;
        }

        public void ReleaseConnection(ConnectionContext connection)
        {
            connection.isActive = false;
        }
    }
}
