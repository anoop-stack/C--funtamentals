using System.Collections.Generic;
using System;

namespace FeildFun
{
    public class Consumer
    {

        /*A readonly field cannot be re-assigned to (except in a constructor of the class in which the field is defined or a variable initializer))
        */
        private readonly List<int> list = new List<int>();
        //initaliztion of the list , and readonly help to prevent it form reassign
        public readonly string name = "anoop";

        public Consumer(string name)// name = ravi;
        {
            this.name = name;
            // in constr we can re-assign the value of name.     
        }

        public void Name()
        {
            Console.WriteLine("Consumer " + name); // ravi
        }


    }
}
