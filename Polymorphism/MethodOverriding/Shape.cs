using System;

namespace MethodOverriding
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Draw mehod");
        }

    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Circle");

            // if we also need the base method thn

            //base.Draw();
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
