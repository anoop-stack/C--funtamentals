using System;
using System.Collections;

namespace BoxingUnBoxing
{
    // object class is the base class for all  classes in .Net
    class Program
    {
        /*
            value type -> r stored in stack(all primitive and struct)
            refernce type -> r stored in heap which has large memory and store (obj , clas, etc all refernce type)
        */
        static void Main(string[] args)
        {
            //boxing : process of converting a value type to refernce type
            int num = 10;
            Object obj = num;
            // it is stored in the heap , instead of stack.

            //unboxing
            int num2 = (int) obj;

            var arrayList = new ArrayList();
            // arrayList has type safty
            arrayList.Add(1);// boxing happen
            arrayList.Add("12131");// string is refernce type , no boxing

            // it have performance plenty
        }
    }
}
