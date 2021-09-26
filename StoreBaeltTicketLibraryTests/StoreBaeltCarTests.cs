using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBaeltCarTests
    {
        [TestMethod()]
        public void StoreBaeltCarTest()
        {
            StoreBaeltCar car = new("ABCDEFG", DateTime.Now, false);

            Assert.IsInstanceOfType(car, typeof(Car));
        }

        [TestMethod]
        public void SaturdayWithBroBizzTest()
        {
            StoreBaeltCar car = new("ABCDEFG", DateTime.Parse("2021-09-25 12:00"), true);

            var result = car.Price();

            Assert.AreEqual(240 * 0.80 * 0.95, result);
        }

        [TestMethod]
        public void SundayWithoutBroBizzTest()
        {
            StoreBaeltCar car = new("ABCDEFG", DateTime.Parse("2021-09-26 12:00"), false);

            var result = car.Price();

            Assert.AreEqual(240 * 0.80, result);
        }

        [TestMethod]
        public void MondayWithoutBroBizzTest()
        {
            StoreBaeltCar car = new("ABCDEFG", DateTime.Parse("2021-09-27 12:00"), false);

            var result = car.Price();

            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void TuesdayWithBroBizzTest()
        {
            StoreBaeltCar car = new("ABCDEFG", DateTime.Parse("2021-09-28 12:00"), true);

            var result = car.Price();

            Assert.AreEqual(240 * 0.95, result);
        }
    }
}