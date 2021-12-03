using System;

namespace Strategy
{
    class RadialGradienBrush : Brush
    {
        public override void Print()
        {
            Console.WriteLine("2 Renkli Yuvarlak Geçişli Boyama");
        }
    }
}
