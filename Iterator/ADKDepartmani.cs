using System.Collections.Generic;

namespace Iterator
{
    public class ADKDepartmani : Iterable
    {
        private List<Calisan> calisanlar;
        public ADKDepartmani()
        {
            calisanlar = new List<Calisan>();
            calisanlar.Add( new Calisan("Süleyman Yılmaz", "Müdür"));
            calisanlar.Add(new Calisan("Ali Veli", "Uzman"));
        }

        public List<Calisan> GetCalisanlar()
        {
            return calisanlar;
        }

        public Iterator GetIterator()
        {
            return new ListIterator();
        }
    }
}
