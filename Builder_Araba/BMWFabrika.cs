namespace Builder_Araba
{
    class BMWFabrika : Fabrika
    {
        private Bmw bmw = new Bmw();
        public override void ParcaEkle(string parca)
        {
            bmw.OpsiyonelParcalar.Add(parca);
        }

        public override Araba Uret(string model)
        {
            bmw.Model = model;
            return bmw;
        }
    }
}
