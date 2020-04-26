using System;

namespace UpDownCasting
{
    class Circle : Shape
    {
        public string FontName { get; set; }
        public string FontSize { get; set; }
        public void DrawCircle()
        {
            Console.WriteLine("DrawCircle");
        }

    }
}
