using System;

namespace AccessModifiers
{
    class Program
    {
        /*
            public => excesses from every where
            private => excesses within the class
            protected => excesses within and to the derived class
            interal => exceeable from the same assembly /// very rare it is used
            protected internal => accessiable form the same assembly or an derived class

        */
        static void Main(string[] args)
        {
           //public 
           var customer = new GoldCustomer();
           customer.OfferVoucher();
           
        }
    }
}
