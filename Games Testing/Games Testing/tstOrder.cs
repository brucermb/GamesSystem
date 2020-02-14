using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing
{
    [TestClass]
    public class tstOrder
    {
      /*  //test data
        //data to pass to methods
        bool isActive = true;
        int orderNumber = 1;
        string orderDate = DateTime.Now.Date.ToString();
        float orderTotal = 52.95f;
        string orderCustomerFirstName = "George";
        string orderCustomerLastName = "Kozis";
        string orderCustomerAddress = "Western Road 42D";
        string orderCustomerPostcode = "LE3 1GH";
        string orderCustomerCity = "Leicester";
        string orderCustomerPhoneNumber = "+4407802680483";
    */


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
        public void orderDateOK()
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

        [TestMethod]
        public void orderNumberOK()
        {
            clsOrder anOrder = new clsOrder();
            int TestData = 1;
            anOrder.orderNum = TestData;
            Assert.AreEqual(anOrder.orderNum, TestData);
        }

      




    }
}