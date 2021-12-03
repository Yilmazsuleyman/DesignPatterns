using System;

namespace Visitor
{
    public class ControlsVisitor : IVisitor {
        public void Visit(Control c)
        {
            if (c is DropDownList)
            {
                Console.WriteLine("Dropdown'da child eleman eklenemez");
            }
            if (c is Panel)
            {
                Console.WriteLine("Panel'de child eleman eklenemez");
            }
            if (c is Textbox)
            {
                Console.WriteLine("Textbox'da child eleman eklenemez");
            }
        }
    }
}
