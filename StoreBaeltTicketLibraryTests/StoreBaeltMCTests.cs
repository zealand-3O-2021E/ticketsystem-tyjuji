using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StoreBaeltMCTests
    {
        [TestMethod()]
        public void StoreBaeltMCTest()
        {
            StoreBaeltMC mc = new("ABCDEFG", DateTime.Now, false);

            Assert.IsInstanceOfType(mc, typeof(MC));
        }
    }
}