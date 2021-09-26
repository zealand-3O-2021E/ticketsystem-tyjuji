using ClassLibraryTicketSystem;
using System;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        private const double price = 240;

        public StoreBaeltCar(string licensePlate, DateTime date, bool broBizz) : base(licensePlate, date, broBizz)
        {
        }

        public override double Price()
        {
            if(Date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
            {
                if (BroBizz)
                {
                    // Slight code duplication, but since we're using a DLL, I consider base.Price() to be closed.
                    // Would be neater to add a parameter to the base.Price() method for conditional BroBizz handling.
                    return price * 0.80 * 0.95; 
                }
                return price * 0.80;
            }
            return base.Price();
        }
    }
}
