using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

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
            // Instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //Some test data to assign to the property
            Boolean testData = true;
            //Assign data 
            anCustomer.CustomerActive = testData;
            //test  the two values are the same;
            Assert.AreEqual(anCustomer.CustomerActive, testData);
        }

        [TestMethod]
        public void CustomerDateAddedOK()
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
        public void CustomerTownOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "London";
            anCustomer.CustomerTown = TestData;
            Assert.AreEqual(anCustomer.CustomerTown, TestData);
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
            if (anCustomer.CustomerDateAdded != Convert.ToDateTime("01/10/2018"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateOfBirthPropertyOk()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            ACustomer.DOB = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.DOB, TestData);
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

             [TestMethod]
        public void UsernamePropertyOk()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // create some test data to assign to the property
            string TestData = "MrRana";
            // assign the data to the property
            ACustomer.Username = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.Username, TestData);

        }

        [TestMethod]
        public void CustomerAdminPermissionPropertyOk()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // create some test data to assign to the property
            Boolean TestData = true;
            // assign the data to the property
            ACustomer.CustomerAdmin = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.CustomerAdmin, TestData);



        [TestMethod]
        public void PasswordPropertyOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            // create some test data to assign to the property
            string TestData = "password";
            // assign the data to the property
            ACustomer.Password = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(ACustomer.Password, TestData);
        }

{
        [TestClass]

        public class tstAddress
        {
            //good test data
            //create some test data to pass to the method
            string CustomerAddress = "10 Downing Street";
            string CustomerEmail = "tejrana@hotmail.com";
            String Customertown = "London";
            string CustomerDateAdded = "01/10/2018";
            string CutsomerPostcode = "SW1A 2AA";
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to creatre
            clsCustomerAddress AnCustomerAddress = new clsCustomerAddress();
            //boolean variable to store the results of the validation
            Boolean found = false;
            //create some test data to use with the method
            Int32 CustomerAdressNo = 1;
            //invoke the method
            found = CustomerAddress.Find(CustomerAddressOK);
            //test to see that the result is correct
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void CustomerAddressNoFound()
        {
            //create an instance of the class we want to creatre
            clsCustomerAddress AnCustomerAddress = new clsCustomerAddress();
            //boolean variable to store the results of the validation
            Boolean found = false;
            //create some test data to use with the method
            Int32 CustomerAddressNo = 21;
            //invoke the method
            found = CustomerAddress.Find(CustomerAddressOK);
            //check the Customers Address No
            if (AnCustomerAddress.CustomerAddressNo != 22)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void
            public void addMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerAddressCollection AllCustomerAddress = new clsCustomerAddressCollection();
            //create the item of test data
            clsCustomerAddress TestItem = new clsCustomerAddress();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1
                TestItem.CustomerAddressNo = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.HouseNo = "10 Dowing Street"
            TestItem.Postcode = "SW1A 2AA";
            TestItem.Town = "London";
            //set CustomerAddress to the test data
            AllCustomerAddress.CustomerAddress = TestItem
                //add the record
                PrimaryKey = CustomerAddress.add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomerAddress.CustomerAddress.Find(PrimaryKey);
            //delete the record
            AllCustomerAddress.delete();
            //now find the record
            Boolean Found = AllCustomerAddress.CustomerAddress.Fidn(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllCustomerAddress.ThisCustomerAddress, TestItem);

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerAddressCollection AllCustomerAddress = new clsCustomerAddressCollection();
            //create the item of test data
            clsCustomerAddress TestItem = new clsCustomerAddress();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1
                TestItem.CustomerAddressNo = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.HouseNo = "10 Dowing Street"
            TestItem.Postcode = "SW1A 2AA";
            TestItem.Town = "London";
            //set CustomerAddress to the test data
            AllCustomerAddress.CustomerAddress = TestItem
                //add the record
           int PrimaryKey = CustomerAddress.add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomerAddress.CustomerAddress.Find(PrimaryKey);
            //delete the record
            AllCustomerAddress.delete();
            //now find the record
            Boolean Found = AllCustomerAddress.CustomerAddress.Fidn(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerAddressCollection AllCustomerAddress = new clsCustomerAddressCollection();
            //create an instance of the filtered data
            clsCustomerAddressCollection FilteredCustomerAddresses = new clsCustomerAddressCollection();
            //apply a blank string (should return all records);
            FilteredCustomerAddresses.ReportByPostCose("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomerAddress.count, FilteredCustomerAddresses.count);
        } }

        }
          
                
         