using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {

        //Total charge formula is (Usage * Usage Rate) + Admin Fee
        // Charge = (Usage * 0.07) + 12


        /// <summary>
        /// Test method for 0 kwh Usage scenario
        /// </summary>

        [TestMethod()]
        public void CalculateChargeUsageZeroTest()
        {
            //arrange
            Customer cust = new Customer("TestFname", "TestLname", 0);
            decimal expectedCharge = (0 * 0.07m) + 12m;
            decimal actualCharge;

            //act
            actualCharge = cust.CalculateCharge();

            //asset

            Assert.AreEqual(expectedCharge, actualCharge);


        }

        /// <summary>
        /// Test method for 1 kwh Usage scenario
        /// </summary>
        [TestMethod()]
        public void CalculateChargeUsageOneTest()
        {
            //arrange
            Customer cust = new Customer("TestFname", "TestLname", 1m);
            decimal expectedCharge = (1m * 0.07m) + 12m;
            decimal actualCharge;

            //act
            actualCharge = cust.CalculateCharge();

            //asset

            Assert.AreEqual(expectedCharge, actualCharge);
        }


        /// <summary>
        /// Test method for 10 kwh Usage scenario
        /// </summary>
        [TestMethod()]
        public void CalculateChargeUsage10Test()
        {
            //arrange
            Customer cust = new Customer("TestFname", "TestLname", 10m);
            decimal expectedCharge = (10m * 0.07m) + 12m;
            decimal actualCharge;

            //act
            actualCharge = cust.CalculateCharge();

            //asset

            Assert.AreEqual(expectedCharge, actualCharge);
        }



    }
}