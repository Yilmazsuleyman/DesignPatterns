using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontrol k1 = new Label();
            k1.Name = "txt1";

            Kontrol k2 = new Label();
            k2.Name = "txt2";

            Stok sb = new Stok();

            sb.Register(k1);
            sb.Register(k2);

            sb.Notify();
            Display(k1);
            Display(k2);

            sb.ElemanCek();
            sb.Notify();
            Display(k1);
            Display(k2);

            sb.ElemanCek();
            sb.Notify();
            Display(k1);
            Display(k2);
        }
        public static void Display(Kontrol k)
        {
            Console.WriteLine(k.Name + " : " + k.Text);
        }
    }
}
