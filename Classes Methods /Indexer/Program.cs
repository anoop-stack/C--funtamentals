using System;
using System.Collections.Generic;

namespace Indexer
{
    class Program
    {
        /*
        indexer => a way to access element in a class that represents a list of items
                    array
                    lsit
                    dictionary
        */
        static void Main(string[] args)
        {
            var cookie = new HttpCookies();
            cookie["name"] ="anoop";
            cookie["lastName"]="kumar";
            Console.WriteLine($"full Name {cookie["name"]} {cookie["lastName"]}");


            // cookie.Set_itme("name","ravi");
            // cookie.Set_itme("lastName","kumar");
            // Console.WriteLine($"full Name {cookie.Get_itme("name")} {cookie.Get_itme("lastName")}");

        }
    }
}
