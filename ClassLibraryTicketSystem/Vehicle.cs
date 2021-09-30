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
        public DateTime Date { get; set; }

        /// <summary>
        /// Whether or not the vehicle has a BroBizz.
        /// </summary>
        protected bool BroBizz { get; set; }

        /// <summary>
        /// Price for passing over the bridge in this vehicle.
        /// </summary>
        /// <returns>Price</returns>
        public abstract double Price();


        /// <summary>
        /// Returns the type that defines the vehicle.
        /// </summary>
        /// <returns>"Vehicle"</returns>
        public abstract string VehicleType();
    }
}
