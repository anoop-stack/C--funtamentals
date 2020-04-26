using System;

namespace AccessModifers
{
    class Program
    {
        /*
        there are 5 access modifiers => public ,private, protected , interal, protected interal

        it is way contorl the access the member of case

        Encapluation = >
                    1) define member access modifier as private
                    2)make getter/setter method public
        */

        static void Main(string[] args)
        {
            var myBirth = new Person();
            myBirth.Birthday = new DateTime(1970, 1, 2);

            myBirth.Set_name("anoop");
            myBirth.Number = 23245522;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{myBirth.Get_name()} birthday is on {myBirth.Birthday}, and th number is {myBirth.Number}");
        }
    }
}
