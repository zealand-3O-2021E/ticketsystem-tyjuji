﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronLibrary
{
    public class OresundCar : Car
    {
        public OresundCar(string licensePlate, DateTime date, bool broBizz) : base(licensePlate, date, broBizz)
        {
        }
    }
}