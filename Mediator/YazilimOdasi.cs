namespace Mediator
{
    sealed class YazilimOdasi : Oda
    {
        public YazilimOdasi() : base()
        {

        }
        public override void BroadcastMesajGonder(Katilimci gonderen, string mesaj)
        {
            foreach (Katilimci k in this.katilimcilar)
            {
                k.MesajAl(gonderen, mesaj);
            }
        }

        public override void MesajGonder(Katilimci gonderen, Katilimci alan, string mesaj)
        {
            alan.MesajAl(gonderen, mesaj);
        }
    }
}
