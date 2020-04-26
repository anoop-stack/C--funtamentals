using System;

namespace AbstractClass
{
    class Circle : Shape
    {
        //must implement all the abstract memeber of the base class in the derived class
        public override void Draw()
        {
            Console.WriteLine("Drawing");
        }
    }

}
