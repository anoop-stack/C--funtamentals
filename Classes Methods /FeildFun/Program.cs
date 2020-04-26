using System;

namespace FeildFun
{
    class Program
    {
        static void Main(string[] args)
        {
           var c = new Consumer("ravi");
          c.Name();// ravi and not anoop.

        }
    }
}
