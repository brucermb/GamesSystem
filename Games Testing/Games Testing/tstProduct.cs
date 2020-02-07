using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //test to see that it exists
            Assert.IsNotNull(AProduct);
        }
        
        }
    }
