namespace Observer
{
    public abstract class Kontrol
    {
        protected string m_Text;
        protected string m_Name;

        public abstract void onAction(string val);

        public abstract void Add(IObservable o);
        public abstract void Remove(IObservable o);

        public string Name { get { return m_Name; } set { m_Name = value; } }
        public string Text { get { return m_Text; } set { m_Text = value; } }

    }
}
