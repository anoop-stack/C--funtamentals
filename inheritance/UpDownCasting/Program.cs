using System.Collections;
using System.IO;
using System;

namespace UpDownCasting
{
    /*
        Consversion from a derived class to a base class(upCasting);
        Consversion from a base class to a Derived class(DownCasting);
    */
    class Program
    {
        static void Main(string[] args)
        {
            // streamreader is the base class for the stream reader obj , like MemoryStream , FileStream etc.
            //it dont required casting , this is upcasting
            StreamReader sr = new StreamReader(new MemoryStream());

            var list = new ArrayList();
            // WE CAN ADD ANY DATA TYPE IN ARRAYLIST , i.e not use this use List or Generic list, as it as cnstrain
            list.Add(1);
            list.Add("any srring");
            list.Add(new Circle());

            // DownCasting


        }
        /*
        in .Net we have Stream Reader, which reads data of any kind
        */
    }
}
