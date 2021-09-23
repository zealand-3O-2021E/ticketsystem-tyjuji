using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Describes a motorcycle.
    /// </summary>
    public class MC : Vehicle
    {
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
