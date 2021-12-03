namespace Banka_Visitor
{
    class KurumsalMusteri : Musteri
    {
        protected string _firma;
        public KurumsalMusteri(string ad, string soyad, string firma) : base(ad, soyad )
        {
            _firma = firma;
        }
        public override void Accept(IVisitor vst)
        {
            vst.Visit(this);
        }

    }
}