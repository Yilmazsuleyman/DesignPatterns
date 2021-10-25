namespace Builder_Araba
{
    class AudiFabrika : Fabrika
    {
        private Audi audi = new Audi();
        public override void ParcaEkle(string parca)
        {
            audi.OpsiyonelParcalar.Add(parca);
        }

        public override Araba Uret(string model)
        {
            audi.Model = model;
            return audi;
        }
    }
}
