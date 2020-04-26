using System;

namespace AbstractClass
{
    class Program
    {
        /*
            abstract modifer -> indicate that class or member is missing implementation,

            Sealse modifer -> prrevent derivation of class and override of methhod. // on derived class like the circle
        */
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();
            circle.Reset();
        }
    }

   
}
