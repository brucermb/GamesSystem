using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void OrderInstanceOK()
        {
            clsOrder order = new clsOrder();
            Assert.IsNotNull(order);
        }

        [TestMethod]
        public void ActiveOrderOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property
            anOrder.Active = testData;
            //test to see that the two values are the same;
            Assert.AreEqual(anOrder.Active, testData);

        }

        [TestMethod]
        public void DateAddedOrderOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create some test data to assign to this property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            anOrder.dateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anOrder.dateAdded, TestData);
        }


    }
}