using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YüzeyselveDerinKopyalama
{
    public class Hesap : PrototypeHelper<Hesap>
    {
        private decimal m_Balance;
        private Musteri m_Customer;

        public decimal Balance { get { return m_Balance; } set { m_Balance = value; } }
        public Musteri Customer { get { return m_Customer; } set { m_Customer = value; } }

        public Hesap(decimal balance, string customerName, string customerSurname)
        {
            m_Balance = balance;
            m_Customer = new Musteri(customerName, customerSurname);
        }

        public override string ToString()
        {
            return m_Customer.ToString() + "\t" + m_Balance;
        }
    }
}
