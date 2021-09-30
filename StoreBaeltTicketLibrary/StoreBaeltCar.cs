using ClassLibraryTicketSystem;
using System;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Specialization of the standard Car class for StoreBaelt.
    /// </summary>
    public class StoreBaeltCar : Car
    {
        private const double price = 240;

        /// <summary>
        /// Constructor for the StoreBaeltCar class.
        /// </summary>
        /// <param name="licensePlate">7 character string.</param>
        /// <param name="date">Date and time for passing over the bridge.</param>
        /// <param name="broBizz">Whether or not the vehicle has a BroBizz.</param>
        public StoreBaeltCar(string licensePlate, DateTime date, bool broBizz) : base(licensePlate, date, broBizz)
        {
        }

        /// <summary>
        /// Returns the price for passing over the bridge.
        /// </summary>
        /// <returns>240, but with 5% discount for BroBizz and 20% for weekends. Discounts are combined.</returns>
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
