using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronLibrary
{
    public class OresundMC : MC
    {
        public OresundMC(string licensePlate, DateTime date, bool broBizz) : base(licensePlate, date, broBizz)
        {
        }

        public override double Price()
        {
            if (BroBizz)
            {
                return 73;
            }
            return 210;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
