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
        
    }
}
