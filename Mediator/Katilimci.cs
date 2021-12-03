namespace Mediator
{
    abstract class Katilimci
    {
        private string nick;

        public string Nick { get { return nick; } set { nick = value; } }

        protected Katilimci(string nick)
        {
            this.nick = nick;
        }
        public abstract void MesajAl(Katilimci gonderen, string mesaj);
    }
}
