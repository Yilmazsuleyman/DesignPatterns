using System;

namespace YüzeyselveDerinKopyalama
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeManager pm = new PrototypeManager();

            Console.WriteLine("Yüzeysel Klonlama \n");

            Hesap a = pm.accounts["1"].Clone();
            PrototypeClient.Display(pm.accounts["1"], a);

            a.Balance = 300;
            PrototypeClient.Display(pm.accounts["1"], a);

            a.Customer.Surname = "Yılmaz";
            PrototypeClient.Display(pm.accounts["1"], a);

            Console.WriteLine("Derin Klonlama \n");

            Hesap b = pm.accounts["2"].DeepCopy();

            PrototypeClient.Display(pm.accounts["3"], b);

            b.Balance = 250;
            PrototypeClient.Display(pm.accounts["3"], b);

            b.Customer.Surname = "Çelik";
            PrototypeClient.Display(pm.accounts["3"], b);
        }
    }
}
