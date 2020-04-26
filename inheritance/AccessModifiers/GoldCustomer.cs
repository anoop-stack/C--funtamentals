

using AccessModifiers.Repository;

namespace AccessModifiers
{

    // derived form the customers
    public class GoldCustomer : Customers
    {
        // through this we cna acces the prarent public or protected values

        public void OfferVoucher()
        {
            this.Promote();
        }
    }
}
