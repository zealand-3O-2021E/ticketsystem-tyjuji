using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundBronLibrary.Tests
{
    [TestClass()]
    public class OresundMCTests
    {
        [TestMethod()]
        public void OresundMCTest()
        {
            var mc = new OresundMC("ABCDEFG", DateTime.Now, false);

            Assert.IsInstanceOfType(mc, typeof(MC));
        }

        [TestMethod()]
        public void PriceWithoutBrobizzTest()
        {
            var mc = new OresundMC("ABCDEFG", DateTime.Now, false);

            var result = mc.Price();

            Assert.AreEqual(210, result);
        }

        [TestMethod()]
        public void PriceWithBrobizzTest()
        {
            var mc = new OresundMC("ABCDEFG", DateTime.Now, true);

            var result = mc.Price();

            Assert.AreEqual(73, result);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var mc = new OresundMC("ABCDEFG", DateTime.Now, true);

            var result = mc.VehicleType();

            Assert.AreEqual("Oresund MC", result);
        }
    }
}