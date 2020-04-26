using System;

namespace AccessModifiers.Repository
{
    public class Customers
    {
        public string Name { get; set; }
        public int Id { get; set; }

        internal void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("PROMTED");
            }
        }

        // CalculateRating cann' t be acces form any where..  
        private int CalculateRating()
        {
            return 0;
        }
    }
}
