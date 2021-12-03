using System;

namespace Strategy
{
    class Rectangle
    {
        private Brush brush;
        public Rectangle()
        {

        }
        public Rectangle(Brush brush)
        {
            this.brush = brush;
        }
        public void Draw()
        {
            brush.Print();
            Console.WriteLine("Dikdörtgen");
        }
    }
}
