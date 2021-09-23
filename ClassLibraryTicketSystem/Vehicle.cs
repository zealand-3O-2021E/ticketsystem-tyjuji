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
        private string licensePlate;

        /// <summary>
        /// A 7 character string identifying the vehicle.
        /// </summary>
        public string LicensePlate
        {
            get { return licensePlate; }
            set { 
                if(value.Length > 7){
                    throw new ArgumentException("License plate exceeds 7 characters.", licensePlate);
                }
                licensePlate = value;
            }
        }


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
