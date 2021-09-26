using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    // MC added for completeness.
    public class StoreBaeltMC : MC
    {
        public StoreBaeltMC(string licensePlate, DateTime date, bool broBizz) : base(licensePlate, date, broBizz)
        {
            LicensePlate = licensePlate;
            Date = date;
            BroBizz = broBizz;
        }
    }
}
