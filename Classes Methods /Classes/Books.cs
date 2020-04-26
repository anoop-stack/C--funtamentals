using System;

namespace Classes
{
    /*here how we create a class , Fields and methods..
    */

    public class Books
    {
        public string Title;

        public void GetBookName()
        {
            Console.WriteLine($"name of the book is {Title}");
        }

        public static string SetBookName(string str)
        {
            return str;
        }
    }
}
