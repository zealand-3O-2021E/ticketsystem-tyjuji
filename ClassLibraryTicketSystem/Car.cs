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
    public class Car : Vehicle
    {
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
