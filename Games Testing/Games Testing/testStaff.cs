using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing {

    [TestClass]
    public class testStaff { 
    
        [TestMethod]
        public void InstanceOk() {
            // creates a new instance of class staff
            clsStaff  AnStaff = new clsStaff();
            // test to see if it exists
            Assert.IsNotNull(AnStaff);

        }
    }
}
