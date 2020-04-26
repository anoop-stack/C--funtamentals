using System;

namespace ConstructorT
{

    public class Person
    {
        public string Name;
        public bool isMarried;
        public char Last;
        public int Number;
        public float salary;

        public void getPersonDetails()
        {
            Console.WriteLine($"Name:{Name}, isMarried:{isMarried}, Last:{Last}, Number:{Number}, salary:{salary}");
            //Name: null , isMarried:False, Last: null, Number:0, salary:0
        }
    }

}
