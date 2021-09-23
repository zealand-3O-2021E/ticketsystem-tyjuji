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
            Car car = new("ABCDEFG", DateTime.Now);

            var result = car.Price();

            Assert.AreEqual(240, result);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Car car = new("ABCDEFG", DateTime.Now);

            var result = car.VehicleType();

            Assert.AreEqual("Car", result);
        }

        [TestMethod]
        public void GoodLicensePlateTest()
        {
            _ = new Car("ABCDEFG", DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BadLicensePlateTest()
        {
            _ = new Car("ABCDEFGH", DateTime.Now);
        }
    }
}