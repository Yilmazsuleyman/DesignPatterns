using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Database : ICloneable
    {
        private string name;
        private ArrayList m_Tables = null;

        public string Name { get { return name; } set { name = value; } }

        public Database()
        {
            name = "Model";
            string[] sys_tbls = { "sysusers", "sysindexes", "sysfiles"};
            m_Tables = new ArrayList();
            m_Tables.AddRange(sys_tbls);
        }
        public void AddTable(string name)
        {
            m_Tables.Add(name);
        }

        public void TableList()
        {
            for (int i = 0; i < m_Tables.Count; i++)
            {
                Console.WriteLine(m_Tables[i]);
            }
        }
        public object Clone()
        {
            return new Database();
        }
    }
}
