using System;

namespace Composition
{
    public class Logger
    {
        /*
                logger class is common b/w migrationDb class and installer class , s o it has a relationship       
                
        */
       public void Log(string message)
       {
           Console.WriteLine($"log message => {message}");
       }
    }
}
