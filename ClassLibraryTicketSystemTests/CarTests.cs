using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            Car car = new("ABCDEFG", DateTime.Now, false);

            var result = car.Price();

            Assert.AreEqual(240, result);
        }

        [TestMethod()]
        public void PriceWithBroBizzTest()
        {
            Car car = new("ABCDEFG", DateTime.Now, true);

            var result = car.Price();

            Assert.AreEqual(240 * 0.95, result, 0.000001);
        }

        [TestMethod()]
        public void DateTest()
        {
            Car car = new("ABCDEFG", DateTime.Now, false);

            Assert.IsInstanceOfType(car.Date, typeof(DateTime));
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Car car = new("ABCDEFG", DateTime.Now, false);

            var result = car.VehicleType();

            Assert.AreEqual("Car", result);
        }

        [TestMethod]
        public void GoodLicensePlateTest()
        {
            var car = new Car("ABCDEFG", DateTime.Now, false);

            var result = car.LicensePlate;

            Assert.AreEqual("ABCDEFG", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BadLicensePlateTest()
        {
            _ = new Car("ABCDEFGH", DateTime.Now, false);
        } // Cannot be covered by tests, since the exception is thrown.
    }
}