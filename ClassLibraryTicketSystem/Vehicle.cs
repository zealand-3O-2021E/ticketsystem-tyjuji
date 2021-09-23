using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Describes a vehicle.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// A 7 character string identifying the vehicle.
        /// </summary>
        protected string Licenseplate { get; set; }

        /// <summary>
        /// Date and time of passing over the bridge.
        /// </summary>
        protected DateTime Date { get; set; }

        /// <summary>
        /// Price for passing over the bridge in this vehicle.
        /// </summary>
        /// <returns>0</returns>
        public virtual double Price()
        {
            return 0;
        }

        /// <summary>
        /// Returns the type that defines the vehicle.
        /// </summary>
        /// <returns>"Vehicle"</returns>
        public virtual string VehicleType()
        {
            return "Vehicle";
        }
    }
}
