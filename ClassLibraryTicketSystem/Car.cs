using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Describes an automobile.
    /// </summary>
    public class Car : Vehicle
    {
        private const double _price = 240;

        /// <summary>
        /// Constructor for the Car class.
        /// </summary>
        /// <param name="licensePlate">7 character string.</param>
        /// <param name="date">Date and time for passing over the bridge.</param>
        /// <param name="broBizz">Whether or not the vehicle has a BroBizz.</param>
        public Car(string licensePlate, DateTime date, bool broBizz)
        {
            LicensePlate = licensePlate;
            Date = date;
            BroBizz = broBizz;
        }

        /// <summary>
        /// Price for passing over the bridge in this vehicle.
        /// </summary>
        /// <returns>Returns 240 with a 5% discount, when BroBizz is used.</returns>
        public override double Price()
        {
            if(BroBizz) return _price * 0.95;
            return _price;
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
