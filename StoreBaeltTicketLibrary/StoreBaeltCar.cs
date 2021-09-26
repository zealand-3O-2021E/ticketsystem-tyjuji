using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        private const double price = 240;

        public StoreBaeltCar(string licensePlate, DateTime date, bool broBizz) : base(licensePlate, date, broBizz)
        {
            LicensePlate = licensePlate;
            Date = date;
            BroBizz = broBizz;
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
