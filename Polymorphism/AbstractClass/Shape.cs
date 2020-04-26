using System;

namespace AbstractClass
{
    abstract class Shape
    {
        //if a property or the member is considered abstract , the class containg it should also be abstract
        // abstract are inherited virtual.
        //Abstract Class cann't  be Instantiated ,! var shape = new Shape(); 
        // it all force other deveolpr to follow the same patten.
        // it create some kindo f gurd , to that mehod are implement
        
        public abstract void Draw(); /// no implement, implementation is left to dependent clss

        public void Reset()
        {
            Console.WriteLine("Resetting Shape");
        }
    }

}
