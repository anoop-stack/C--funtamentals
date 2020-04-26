using System;

namespace UpDownCasting
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public void DrawShape()
        {
            Console.WriteLine("DrawShape");
        }
    }
}
