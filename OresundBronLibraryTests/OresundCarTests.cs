using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OresundBronLibrary.Tests
{
    [TestClass()]
    public class OresundCarTests
    {
        [TestMethod()]
        public void OresundCarTest()
        {
            var car = new OresundCar("ABDEFG", DateTime.Now, false);

            Assert.IsInstanceOfType(car, typeof(Car));
        }

        [TestMethod()]
        public void PriceWithoutBroBizzTest()
        {
            var car = new OresundCar("ABCDEFG", DateTime.Now, false);

            var result = car.Price();

            Assert.AreEqual(410, result);
        }

        [TestMethod()]
        public void PriceWithBroBizzTest()
        {
            var car = new OresundCar("ABCDEFG", DateTime.Now, true);

            var result = car.Price();

            Assert.AreEqual(161, result);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var car = new OresundCar("ABCDEFG", DateTime.Now, false);

            var result = car.VehicleType();

            Assert.AreEqual("Oresund car", result);
        }
    }
}