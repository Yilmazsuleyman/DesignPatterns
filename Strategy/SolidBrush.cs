using System;

namespace Strategy
{
    class SolidBrush : Brush
    {
        public override void Print()
        {
            Console.WriteLine("Tek Renkli Boyama");
        }
    }
}
