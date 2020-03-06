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
            anOrder.OrderActive = testData;
            //test to see that the two values are the same;
            Assert.AreEqual(anOrder.OrderActive, testData);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            clsOrder anOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            anOrder.OrderDateAdded = TestData;
            Assert.AreEqual(anOrder.OrderDateAdded, TestData);
        }

        [TestMethod]
        public void OrderNumberOK()
        {
            clsOrder anOrder = new clsOrder();
            int TestData = 1;
            anOrder.OrderNo= TestData;
            Assert.AreEqual(anOrder.OrderNo, TestData);
        }


        [TestMethod]
        public void OrderTotalOK()
        {
            clsOrder anOrder = new clsOrder();
            decimal TestData = 12.50M;
            anOrder.OrderTotal = TestData;
            Assert.AreEqual(anOrder.OrderTotal, TestData);
        }

        [TestMethod]
        public void OrderFirstNameOK()
        {
            clsOrder anOrder = new clsOrder();
            String TestData = "George";
            anOrder.OrderFirstName = TestData;
            Assert.AreEqual(anOrder.OrderFirstName, TestData);
        }

        [TestMethod]
        public void OrderLastNameOK()
        {
            clsOrder anOrder = new clsOrder();
            String TestData = "Kozis";
            anOrder.OrderLastName = TestData;
            Assert.AreEqual(anOrder.OrderLastName, TestData);
        }

        [TestMethod]
        public void OrderAddressOK()
        {
            clsOrder anOrder = new clsOrder();
            String TestData = "42D Western Road";
            anOrder.OrderAddress = TestData;
            Assert.AreEqual(anOrder.OrderAddress, TestData);
        }

        [TestMethod]
        public void OrderPostcodeOK()
        {
            clsOrder anOrder = new clsOrder();
            String TestData = "LE3 OBK";
            anOrder.OrderPostcode = TestData;
            Assert.AreEqual(anOrder.OrderPostcode, TestData);
        }

        [TestMethod]
        public void OrderCityOK()
        {
            clsOrder anOrder = new clsOrder();
            String TestData = "Leicester";
            anOrder.OrderCity = TestData;
            Assert.AreEqual(anOrder.OrderCity, TestData);
        }

        [TestMethod]
        public void OrderPhoneNumber()
        {
            clsOrder anOrder = new clsOrder();
            String TestData = "+44 457302049";
            anOrder.OrderPhoneNumber= TestData;
            Assert.AreEqual(anOrder.OrderPhoneNumber, TestData);
        }

        [TestMethod]
        public void OrderEmail()
        {
            clsOrder anOrder = new clsOrder();
            String TestData = "kozis-98@hotmail.com";
            anOrder.OrderEmail = TestData;
            Assert.AreEqual(anOrder.OrderEmail, TestData);
        }

        [TestMethod]
        public void FindOrderOK()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderNo = 1;
            Found = anOrder.Find(OrderNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = anOrder.Find(OrderNo);
            if (anOrder.OrderNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = anOrder.Find(OrderNo);
            if(anOrder.OrderDateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 21;
            Found = anOrder.Find(OrderNo);
            if (anOrder.OrderTotal != Convert.ToDecimal(12.5M))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


    }
}