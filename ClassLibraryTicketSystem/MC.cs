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
    public class MC
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
        /// <returns>125. Price is fixed.</returns>
        public double Price()
        {
            return 125;
        }

        /// <summary>
        /// Returns the type that defines the vehicle.
        /// </summary>
        /// <returns>"MC"</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
