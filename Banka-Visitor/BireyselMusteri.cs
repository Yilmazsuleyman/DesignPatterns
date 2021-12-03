namespace Banka_Visitor
{
    class BireyselMusteri : Musteri
    {
        public BireyselMusteri(string ad, string soyad) : base(ad, soyad)
        {

        }
        public override void Accept(IVisitor vst)
        {
            vst.Visit(this);
        }
    }
}