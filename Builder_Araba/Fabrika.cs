namespace Builder_Araba
{
    abstract class Fabrika
    {
        public abstract void ParcaEkle(string parca);
        public abstract Araba Uret(string model);
    }
}
