namespace Iterator
{
    public class IKDepartmani : Iterable
    {
        private Calisan[] calisanlar;

        public IKDepartmani()
        {
            calisanlar = new Calisan[2];
            calisanlar[0] = new Calisan("Süleyman Yılmaz", "Müdür");
            calisanlar[1] = new Calisan("Ali Veli", "Uzman");
        }

        public Calisan[] GetCalisanlar()
        {
            return calisanlar;
        }

        public Iterator GetIterator()
        {
            return new ArrayIterator();
        }
    }
}
