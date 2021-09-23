using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            MC mc = new MC("ABCDEFG", DateTime.Now);

            var result = mc.Price();

            Assert.AreEqual(125, result);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            MC mc = new MC("ABCDEFG", DateTime.Now);

            var result = mc.VehicleType();

            Assert.AreEqual("MC", result);
        }

        [TestMethod]
        public void GoodLicensePlateTest()
        {
            _ = new MC("ABCDEFG", DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BadLicensePlateTest()
        {
            _ = new MC("ABCDEFGH", DateTime.Now);
        }
    }
}