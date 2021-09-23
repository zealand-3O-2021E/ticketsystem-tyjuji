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
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            Car car = new Car();

            var result = car.Price();

            Assert.AreEqual(240, result);
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Car car = new Car();

            var result = car.VehicleType();

            Assert.AreEqual("Car", result);
        }
    }
}