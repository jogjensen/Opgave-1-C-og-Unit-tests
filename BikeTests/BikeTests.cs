using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bike;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bike.Tests
{
    [TestClass()]
    public class BikeTests
    {

        private Bike bike = new Bike(1,"Yellow",1000,17);

        [TestMethod()]
        public void BikeConstructorTest()
        {
            Bike cykel = new Bike(1,"Yellow",1000,17);

            Assert.AreEqual(1,bike.Id);
            Assert.AreEqual("Yellow",bike.Color);
            Assert.AreEqual(1000,bike.Price);
            Assert.AreEqual(17,bike.Gear);
        }

        [TestMethod]
        public void IdTest()
        {
            bike.Id = 1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestColor1Char()
        {
            bike.Color = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPriceOverMustBeOver0()
        {
            bike.Price = -1;
        }

        [TestMethod]
        public void TestPriceCanBe1()
        {
            bike.Price = 1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGearOutOfRange()
        {
            bike.Gear = 2;
        }

        [TestMethod]
        public void TestGearInRange()
        {
            bike.Gear = 3;
        }
    }
}