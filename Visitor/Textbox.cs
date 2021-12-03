namespace Visitor
{
    public class Textbox : Control
    {
        public override void Accept(IVisitor v)
        {
            v.Visit(this);
        }
    }
}
