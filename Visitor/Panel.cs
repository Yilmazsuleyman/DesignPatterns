namespace Visitor
{
    public class Panel: Control
    {
        public override void Accept(IVisitor v)
        {
            v.Visit(this);
        }
    }
}
