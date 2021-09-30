using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronLibrary
{
    /// <summary>
    /// Specialization of the standard MC class for Oresund.
    /// </summary>
    public class OresundMC : MC
    {
        /// <summary>
        /// Constructor for the OresundMC class.
        /// </summary>
        /// <param name="licensePlate">7 character string.</param>
        /// <param name="date">Date and time for passing over the bridge.</param>
        /// <param name="broBizz">Whether or not the vehicle has a BroBizz.</param>
        public OresundMC(string licensePlate, DateTime date, bool broBizz) : base(licensePlate, date, broBizz)
        {
        }

        /// <summary>
        /// Price for passing Oresund.
        /// </summary>
        /// <returns>73 with BroBizz, 210 without.</returns>
        public override double Price()
        {
            if (BroBizz)
            {
                return 73;
            }
            return 210;
        }

        /// <summary>
        /// Returns the type that defines the vehicle.
        /// </summary>
        /// <returns>"Oresund MC"</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
