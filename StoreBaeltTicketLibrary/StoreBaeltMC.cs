using ClassLibraryTicketSystem;
using System;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Specialization of the standard MC class for StoreBaelt.
    /// It has no special functionality and is merely included for completeness.
    /// </summary>
    public class StoreBaeltMC : MC
    {
        /// <summary>
        /// Constructor for the StoreBaeltMC class.
        /// </summary>
        /// <param name="licensePlate">7 character string.</param>
        /// <param name="date">Date and time for passing over the bridge.</param>
        /// <param name="broBizz">Whether or not the vehicle has a BroBizz.</param>
        public StoreBaeltMC(string licensePlate, DateTime date, bool broBizz) : base(licensePlate, date, broBizz)
        {
        }
    }
}
