namespace Visitor
{
    public abstract class Control
    {
        public abstract void Accept(IVisitor v);

        protected string id, text;

        public string Text { get { return text; } set { text = value; } }
        public string ID { get { return id; } set { id = value; } }
    }
}
