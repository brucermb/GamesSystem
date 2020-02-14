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


    }

    
}
