using System;
/*
 classes are the building bloack of and applaiction , combination of classes will provide the expected behavior
 of the applaiction.  

 Object are the instances of classes.  

 object and class are some time inter changable.  

*/
namespace Classes
{
    class Program
    {
        /*
        we use static members to represent concepts that are singletons. (so that we have only one instance)
        only once the memory is allocated.  
        */
        static void Main(string[] args)
        {
            //to create a instance of a class.. we user "NEW" key opertor , it help to allocate memory
            Books books = new Books();
            var book = Books.SetBookName("Ramayan");
            Console.ForegroundColor = ConsoleColor.Green; // it change the color of the console
            books.GetBookName();
            ;
        }
    }
}
