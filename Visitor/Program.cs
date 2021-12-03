using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Panel pnl = new Panel();
            DropDownList cbo = new DropDownList();
            Textbox txt = new Textbox();
            ControlsVisitor cv = new ControlsVisitor();

            cv.Visit(cbo);
            cv.Visit(txt);
            cv.Visit(pnl);

            StatefullVisitor sv = new StatefullVisitor();
            sv.Visit(cbo);
            sv.Visit(txt);
            sv.Visit(pnl);
        }
    }

}
