using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Canvas
    {
        public void DrawShape(List<Shape> shapes)
        {
           foreach (var item in shapes)
           {
               item.Draw();
           }
        }
    }
}
