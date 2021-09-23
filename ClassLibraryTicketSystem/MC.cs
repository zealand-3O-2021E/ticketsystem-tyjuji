using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Describes a motorcycle.
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Constructor for the MC class.
        /// </summary>
        /// <param name="licensePlate">7 character string.</param>
        /// <param name="date">Date and time for passing the bridge.</param>
        public MC(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// Price for passing over the bridge in this vehicle.
        /// </summary>
        /// <returns>125. Price is fixed.</returns>
        public override double Price()
        {
            return 125;
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
