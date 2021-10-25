namespace Builder_Araba
{
    class Acenta
    {
        private Fabrika fabrika;

        public Bmw BmwTalebi(string model, params string[] istekler)
        {
            fabrika = new BMWFabrika();

            foreach (string istek in istekler)
            {
                fabrika.ParcaEkle(istek);
            }
            return (Bmw)fabrika.Uret(model);
        }
        public Audi AudiTalebi(string model, params string[] istekler)
        {
            fabrika = new AudiFabrika();

            foreach (string istek in istekler)
            {
                fabrika.ParcaEkle(istek);
            }
            return (Audi)fabrika.Uret(model);
        }
    }
}
