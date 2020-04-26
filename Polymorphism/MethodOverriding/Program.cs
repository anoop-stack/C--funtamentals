using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        /*
            mehod Overriding -> modifying the implementation of the inherited method
        */
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShape(shapes);
        }
    }
}
