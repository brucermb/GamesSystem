using System;
using GamesClasses;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing
{
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection allOrders = new clsOrderCollection();
            //test to see that it exists 
            Assert.IsNotNull(allOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection allOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestOrder = new clsOrder();
            //set its properties
            TestOrder.OrderActive = true;
            TestOrder.OrderNo = 1;
            TestOrder.OrderFirstName = "John";
            TestOrder.OrderLastName = "Smith";
            TestOrder.OrderAddress = "Western Rd 12";
            TestOrder.OrderPostcode = "Le5 4da";
            TestOrder.OrderCity = "Leicester";
            TestOrder.OrderPhoneNumber = "+440320301239";
            TestOrder.OrderEmail = "random123@gmail.com";
            TestOrder.OrderDateAdded = DateTime.Now.Date;
            //add the order to the test list
            TestList.Add(TestOrder);
            //assign the data to the property
            allOrders.orderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allOrders.orderList, TestList);
        }

        [TestMethod] 
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection allOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderActive = true;
            TestOrder.OrderNo = 5;
            TestOrder.OrderFirstName = "John";
            TestOrder.OrderLastName = "White";
            TestOrder.OrderAddress = "Western Rd 15";
            TestOrder.OrderPostcode = "Le5 2da";
            TestOrder.OrderCity = "Leicester";
            TestOrder.OrderPhoneNumber = "+440320301239";
            TestOrder.OrderEmail = "randodam123@gmail.com";
            TestOrder.OrderDateAdded = DateTime.Now.Date;
            //assign the date to the property
            allOrders.ThisOrder = TestOrder;
            Assert.AreEqual(allOrders.ThisOrder, TestOrder);
        }

        [TestMethod] 
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection allOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestOrder = new clsOrder();
            //set its properties
            TestOrder.OrderActive = true;
            TestOrder.OrderNo = 1;
            TestOrder.OrderFirstName = "John";
            TestOrder.OrderLastName = "Smith";
            TestOrder.OrderAddress = "Western Rd 12";
            TestOrder.OrderPostcode = "Le5 4da";
            TestOrder.OrderCity = "Leicester";
            TestOrder.OrderPhoneNumber = "+440320301239";
            TestOrder.OrderEmail = "random123@gmail.com";
            TestOrder.OrderDateAdded = DateTime.Now.Date;
            //add the order to the test list
            TestList.Add(TestOrder);
            //assign the data to the property
            allOrders.orderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allOrders.orderList, TestList);
        }
    }
}
