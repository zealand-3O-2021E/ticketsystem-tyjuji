using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Describes a motorcycle.
    /// </summary>
    public class MC : Vehicle
    {
        private const double price = 125;

        /// <summary>
        /// Constructor for the MC class.
        /// </summary>
        /// <param name="licensePlate">7 character string.</param>
        /// <param name="date">Date and time for passing over the bridge.</param>
        /// <param name="broBizz">Whether or not the vehicle has a BroBizz.</param>
        public MC(string licensePlate, DateTime date, bool broBizz)
        {
            LicensePlate = licensePlate;
            Date = date;
            BroBizz = broBizz;
        }

        /// <summary>
        /// Price for passing over the bridge in this vehicle.
        /// </summary>
        /// <returns>Returns 125 with a 5% discount, when BroBizz is used.</returns>
        public override double Price()
        {
            if(BroBizz) return price * 0.95;
            return price;
        }

        /// <summary>
        /// Returns the type that defines the vehicle.
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
