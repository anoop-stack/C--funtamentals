using System;

namespace Inheritance
{
    class Program
    {
        /*
            coupling- > a measure of how interconnet classes & subclasses are.
            tightly coupled : more interconnet
            loosly coupled: less interconnet or dependent classes
                achive : 
                    1) encapsulation
                    2)the relationship b/w the class
                    3)interface

            we have 2 type of relationship..        
             1) inheritance
             2) composition
        */

        /*
            inheritance -> relationship that help one class to inherit method or field form other class.   
            relationShip =  IS A ,like car is a vehicle
        */
        static void Main(string[] args)
        {
            /*--------- */
            //parent class 

            var presentObj = new PresentationObject();
            presentObj.Height = 100;
            presentObj.Duplicate();
            Console.WriteLine($"height : {presentObj.Height} px");

            //child class
            var text = new Text();
             Console.ForegroundColor = ConsoleColor.Green;
            text.Height = 300;
            text.Copy();
            text.Hyperlink("www.google.com");
           
            Console.WriteLine($"height : { text.Height} px");

        }
    }
}
