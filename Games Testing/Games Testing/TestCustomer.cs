using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing
{
    [TestClass]
    public class TestCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the clss we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ActiveCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property
            anCustomer.CustomerActive = testData;
            //test to see that the two values are the same;
            Assert.AreEqual(anCustomer.CustomerActive, testData);
        }

        [TestMethod]
        public void CustomerDateOK()
        {
            clsCustomer.anCustomer = new clsCustomer();
                DateTime TestData = DateTime.Now.Date;
                 anCustomer.CustomerDateAdded = TestData;
                     Assert.AreEqual(anCustomer.CustomerDateAdded, TestData);
        }

        [TestMethod]
        public void CustomerNumberOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            int TestData = 1;
            anCustomer.CustomerNo = TestData;
            Assert.AreEqual(anCustomer.CustomerNo, TestData);
        }


        [TestMethod]
        public void CustomerTotalOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            decimal TestData = 000001;
            anCustomer.CustomerTotal = TestData;
            Assert.AreEqual(anCustomer.CustomerTotal, TestData);
        }

        [TestMethod]
        public void CustomerLastNameOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "Rana";
            anCustomer.CustomerLastName = TestData;
            Assert.AreEqual(anCustomer.CustomerLastName, TestData);
        }

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "Tejus";
            anCustomer.CustomerFirstName = TestData;
            Assert.AreEqual(anCustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerAddressOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "10 downing street";
            anCustomer.CustomerAddress = TestData;
            Assert.AreEqual(anCustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerPostcodeOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "SW1A 2AA";
            anCustomer.CustomerPostcode = TestData;
            Assert.AreEqual(anCustomer.CustomerPostcode, TestData);
        }

        [TestMethod]
        public void CustomerCityOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "London";
            anCustomer.CustomerCity = TestData;
            Assert.AreEqual(anCustomer.CustomerCity, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNumber()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "+44 123456789";
            anCustomer.CustomerPhoneNumber = TestData;
            Assert.AreEqual(anCustomer.CustomerPhoneNumber, TestData);
        }

        [TestMethod]
        public void CustomerEmail()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "tejrana@hotmail.com";
            anCustomer.CustomerEmail = TestData;
            Assert.AreEqual(anCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void FindCustomerOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerNo = 1;
            Found = anCustomer.Find(CustomerNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsCustomer anCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = anCustomer.Find(CustomerNo);
            if (anCustomer.CustomerNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer anCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = anCustomer.Find(CustomerNo);
            if (anCustomer.CustomerDateAdded != Convert.ToDateTime("1/10/2018"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerTotalFound()
        {
            clsCustomer anCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = anCustomer.Find(CustomerNo);
            if (anCustomer.CustomerTotal != Convert.ToDecimal(20M))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerActiveFound()
        {
            clsCustomer anCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = anCustomer.Find(CustomerNo);
            if (anCustomer.CustomerActive != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}   