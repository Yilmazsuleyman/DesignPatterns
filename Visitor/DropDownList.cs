namespace Visitor
{
    public class DropDownList : Control
    {
        public override void Accept(IVisitor v)
        {
            v.Visit(this);
        }
    }
}
