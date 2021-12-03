using System;

namespace Strategy
{
    class LinearGradienBrush : Brush
    {
        public override void Print()
        {
            Console.WriteLine("2 Renkli Çizgisel Geçişli Boyama");
        }
    }
}
