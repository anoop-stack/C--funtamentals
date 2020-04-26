using System;

namespace InterfacesTestability
{
    class Program
    {
        /*
            interface is language construct that is similar to a class(In terms of syntax) but different in functionality

            intrfcae are simply decleration and dont contain any implementation 

            interface member don't contain any access modifiers

            it is used to build loosly coupled application
        */
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }

}
