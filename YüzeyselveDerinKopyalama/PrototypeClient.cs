using System;

namespace YüzeyselveDerinKopyalama
{
    [Serializable]
    public class PrototypeClient: PrototypeHelper<Hesap>
    {
        public static void Display(Hesap h1, Hesap h2)
        {
            Console.WriteLine("Prototipi" + h1 + "\n Klon: " + h2 + "\n");
        }
    }
}
