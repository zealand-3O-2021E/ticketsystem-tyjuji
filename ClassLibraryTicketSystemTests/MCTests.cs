using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
[TestMethod()]
        public void PriceTest()
        {
            MC mc = new MC();

            var result = mc.Price();

            Assert.AreEqual(125, result);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            MC mc = new MC();

            var result = mc.VehicleType();

            Assert.AreEqual("MC", result);
        }
    }
}