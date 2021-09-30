using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronLibrary
{
    /// <summary>
    /// Specialization of the standard Car for Oresund.
    /// </summary>
    public class OresundCar : Car
    {
        /// <summary>
        /// Constructor for the OresundCar class.
        /// </summary>
        /// <param name="licensePlate">7 character string.</param>
        /// <param name="date">Date and time for passing over the bridge.</param>
        /// <param name="broBizz">Whether or not the vehicle has a BroBizz.</param>
        public OresundCar(string licensePlate, DateTime date, bool broBizz) : base(licensePlate, date, broBizz)
        {
        }

        /// <summary>
        /// Price for passing Oresund.
        /// </summary>
        /// <returns>161 with BroBizz, 410 without.</returns>
        public override double Price()
        {
            if (BroBizz)
            {
                return 161;
            }
            return 410;
        }

        /// <summary>
        /// Returns the type that defines the vehicle.
        /// </summary>
        /// <returns>"Oresund car"</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
