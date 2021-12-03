using System;

namespace Visitor
{
    public class StatefullVisitor : IVisitor
    {
        public void Visit(Control c)
        {
            if (c is DropDownList)
            {
                Console.WriteLine("Dropdown'da viewstate kullanılıyor");
            }
            if (c is Panel)
            {
                Console.WriteLine("Panel'de viewstate kullanılıyor");
            }
            if (c is Textbox)
            {
                Console.WriteLine("Textbox'da viewstate kullanılamaz");
            }
        }
    }
}
