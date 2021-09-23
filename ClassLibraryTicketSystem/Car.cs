using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Describes an automobile.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Constructor for the Car class.
        /// </summary>
        /// <param name="licensePlate">7 character string.</param>
        /// <param name="date">Date and time for passing the bridge.</param>
        public Car(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// Price for passing over the bridge in this vehicle.
        /// </summary>
        /// <returns>240. Price is fixed.</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns the type that defines the vehicle.
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
