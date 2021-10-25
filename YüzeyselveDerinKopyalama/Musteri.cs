using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YüzeyselveDerinKopyalama
{
    [Serializable]
    public class Musteri
    {
        private string m_Name;
        private string m_Surname;

        public string Name { get { return m_Name; } set { m_Name = value; } }
        public string Surname { get { return m_Surname; } set { m_Surname = value; } }

        public Musteri(string name, string surname)
        {
            m_Name = name;
            m_Surname = surname;
        }

        public override string ToString()
        {
            return m_Name+ "" + m_Surname;
        }
    }
}
