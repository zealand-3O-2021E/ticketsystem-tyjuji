using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Describes an automobile.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// A 7 character string identifying the vehicle.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Date and time of passing over the bridge.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Price for passing over the bridge in this vehicle.
        /// </summary>
        /// <returns>240. Price is fixed.</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns the type that defines the vehicle.
        /// </summary>
        /// <returns>"Car"</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
