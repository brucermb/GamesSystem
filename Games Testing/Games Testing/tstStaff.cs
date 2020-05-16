using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // check that the instance exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            //  create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            Boolean TestData = true;
            // assign the data to the property
            AStaff.Active = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }
        [TestMethod]
        public void AccountIdPropertyOk()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            int TestData = 1;
            // assign the data to the property
            AStaff.AccountId = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AStaff.AccountId, TestData);
        }

        [TestMethod]
        public void HireDatePropertyOk()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property 
            AStaff.DateHired = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AStaff.DateHired, TestData);
        }
        [TestMethod]
        public void NamePropertyOk()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Troy Baker";
            // assign the data to the property
            AStaff.Name = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AStaff.Name, TestData);
        }
        [TestMethod]
        public void DateOfBirthPropertyOk()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            AStaff.DOB = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AStaff.DOB, TestData);
        }
        [TestMethod]
        public void UsernamePropertyOk()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "GavinoFree";
            // assign the data to the property
            AStaff.Username = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AStaff.Username, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOk()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "password";
            // assign the data to the property
            AStaff.Password = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AStaff.Password, TestData);
        }
        [TestMethod]
        public void StaffAdminPermissionPropertyOk()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            Boolean TestData = true;
            // assign the data to the property
            AStaff.StaffAdmin = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AStaff.StaffAdmin, TestData);
        }


    }

    
}
