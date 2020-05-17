using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        string OrderNo = "2";
        string OrderFirstName = "George";
        string OrderLastName = "Kozis";
        string OrderAddress = "Grange Lane 21";
        string OrderPostcode = "Le3 5gh";
        string OrderCity = "Leicester";
        string OrderPhoneNumber = "+440320301239";
        string OrderEmail = "random123@gmail.com";
        string OrderDateAdded = DateTime.Now.Date.ToString();

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
            anOrder.OrderNo = TestData;
            Assert.AreEqual(anOrder.OrderNo, TestData);
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
        public void OrderPhoneNumberOK()
        {
            clsOrder anOrder = new clsOrder();
            String TestData = "+44 457302049";
            anOrder.OrderPhoneNumber = TestData;
            Assert.AreEqual(anOrder.OrderPhoneNumber, TestData);
        }

        [TestMethod]
        public void OrderEmailOK()
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
            Int32 OrderNo = 2;
            Found = anOrder.Find(OrderNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 2;
            Found = anOrder.Find(OrderNo);
            if (anOrder.OrderNo != 2)
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
            Int32 OrderNo = 2;
            Found = anOrder.Find(OrderNo);
            if (anOrder.OrderDateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderActiveFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNo = 2;
            Found = anOrder.Find(OrderNo);
            if (anOrder.OrderActive != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderFirstName = ""; //fail expected
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderFirstName = "g"; //should pass
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNamePlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderFirstName = "Jo"; //should pass
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderFirstName = "JoadrefsaxJoadrefsaxdfas"; //Total characters 24. Max is 25 so it should pass
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderFirstName = "JoadrefsaxJoadrefsaxdfasd"; //Total characters 25. Max is 25 so it should pass.
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderFirstName = "JoadrefsaxJoadrefsaxdfasda"; //Total characters 26. Max is 25 so it should fail.
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderFirstName = "Joadrefsaxasd"; //Total characters 13. Max is 25 so it should pass.
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderFirstName = "";
            OrderFirstName = OrderFirstName.PadRight(500, 'a'); //should fail
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMinMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderLastName = ""; //fail expected
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderLastName = "g"; //should pass
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNamePlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderLastName = "Jo"; //should pass
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderLastName = "JoadrefsaxJoadrefsaxdfas"; //Total characters 24. Max is 25 so it should pass
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderFirstName = "JoadrefsaxJoadrefsaxdfasd"; //Total characters 25. Max is 25 so it should pass.
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderLastName = "JoadrefsaxJoadrefsaxdfasda"; //Total characters 26. Max is 25 so it should fail.
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderLastName = "Joadrefsaxasd"; //Total characters 13. Max is 25 so it should pass.
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            string OrderLastName = "";
            OrderFirstName = OrderFirstName.PadRight(500, 'a'); //should fail
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDateAdded = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDateAdded = TestDate.ToString();
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDateAdded = TestDate.ToString();
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDateAdded = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDateAdded = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "4";
            string OrderFirstName = "ddsa";
            string OrderLastName = "Kewqew";
            string OrderAddress = "Grange Lane 21";
            string OrderPostcode = "Le3 5gh";
            string OrderCity = "Leicester";
            string OrderPhoneNumber = "+440320301239";
            string OrderEmail = "random123@gmail.com";
            //set the DateAdded to a non date value
            string OrderDateAdded = "this is not a date!";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderPostcode = "";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderPostcode = "a";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderPostcode = "aa";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderPostcode = "aaaaaaaa";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderPostcode = "aaaaaaaaa";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderPostcode = "aaaaaaaaaa";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderPostcode = "aaaa";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderAddress = "";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddresstMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderAddress = "a";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderAddress = "aa";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderAddress = "";
            OrderAddress = OrderAddress.PadRight(49, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderAddress = "";
            OrderAddress = OrderAddress.PadRight(50, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderAddress = "";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderAddress = "";
            OrderAddress = OrderAddress.PadRight(25, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void CityMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderCity = "";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderCity = "a";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderCity = "aa";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderCity = "";
            OrderCity = OrderCity.PadRight(49, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderCity = "";
            OrderCity = OrderCity.PadRight(50, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string OrderCity = "";
            OrderCity = OrderCity.PadRight(51, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMid()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderCity = "";
            OrderCity = OrderCity.PadRight(25, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderEmail = "";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderEmail = "a";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderEmail = "aa";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderEmail = "";
            OrderEmail = OrderEmail.PadRight(49, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderEmail = "";
            OrderEmail = OrderEmail.PadRight(50, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string OrderEmail = "";
            OrderEmail = OrderEmail.PadRight(51, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderEmail = "";
            OrderEmail = OrderEmail.PadRight(25, 'a');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderPhoneNumber = "";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderPhoneNumber = "1";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderPhoneNumber = "12";
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderPhoneNumber = "";
            OrderPhoneNumber = OrderPhoneNumber.PadRight(24, '1');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderPhoneNumber = "";
            OrderPhoneNumber = OrderPhoneNumber.PadRight(25, '1');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string OrderPhoneNumber = "";
            OrderPhoneNumber = OrderPhoneNumber.PadRight(26, '1');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderPhoneNumber = "";
            OrderPhoneNumber = OrderPhoneNumber.PadRight(13, '1');
            //invoke the method
            Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}