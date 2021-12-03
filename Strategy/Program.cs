using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Brush brush1 = new SolidBrush();
            Brush brush2 = new LinearGradienBrush();
            Brush brush3 = new RadialGradienBrush();

            Rectangle r = new Rectangle(brush3);
            r.Draw();
        }
    }
}
