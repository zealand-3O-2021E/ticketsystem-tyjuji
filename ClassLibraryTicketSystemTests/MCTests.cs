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
            MC mc = new("ABCDEFG", DateTime.Now, false);

            var result = mc.Price();

            Assert.AreEqual(125, result);
        }

        [TestMethod()]
        public void PriceWithBroBizzTest()
        {
            MC mc = new("ABCDEFG", DateTime.Now, true);

            var result = mc.Price();

            Assert.AreEqual(125 * 0.95, result, 0.000001);
        }

        [TestMethod()]
        public void DateTest()
        {
            MC mc = new("ABCDEFG", DateTime.Now, false);

            Assert.IsInstanceOfType(mc.Date, typeof(DateTime));
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            MC mc = new("ABCDEFG", DateTime.Now, false);

            var result = mc.VehicleType();

            Assert.AreEqual("MC", result);
        }

        [TestMethod]
        public void GoodLicensePlateTest()
        {
            _ = new MC("ABCDEFG", DateTime.Now, false);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BadLicensePlateTest()
        {
            _ = new MC("ABCDEFGH", DateTime.Now, false);
        } // End of function cannot be covered by tests, since the exception is thrown.
    }
}