using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder order = new clsOrder();
            Assert.IsNotNull(order);
        }
    }
}
