namespace Banka_Visitor
{
    abstract class Musteri
    {
        protected string _adi, _soyadi;
        protected Musteri(string ad, string soyad)
        {
            _adi = ad;
            _soyadi = soyad;
        }
        public abstract void Accept(IVisitor vst);
    }
}