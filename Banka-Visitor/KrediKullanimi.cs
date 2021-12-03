namespace Banka_Visitor
{
    class KrediKullanimi
    {
        public static void Mortgage(Musteri m)
        {
            m.Accept(new MortgageVisitor());
        }
        public static void Leasing(Musteri m)
        {
            m.Accept(new LeasingVisitor());
        }
    }
}