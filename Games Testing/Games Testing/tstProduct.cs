using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing
{
    [TestClass]
    public class TstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            ClsProduct Product = new ClsProduct();
            //test to see that it exists
            Assert.IsNotNull(Product);
        }

        [TestMethod]
        public void ProductIDOK()
        {
            //create an instance of the class we want to create
            ClsProduct product = new ClsProduct();
            //create some test data to assign to the property
            String TestData = "000001";
            product.ProductID = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(product.ProductID, TestData);
        }
        [TestMethod]
        public void TitlePropertyOK()
        {
            //create an instance of the class we want to create
            ClsProduct Product = new ClsProduct();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            Product.Title = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Product.Title, TestData);
        }
        [TestMethod]
        public void DescriptionOK()
        {
            ClsProduct product = new ClsProduct();
            string TestData = "Red Dead Redemption is a Western action-adventure game developed by Rockstar San Diego and published by Rockstar Games. A spiritual successor to 2004's Red Dead Revolver, it is the second game in the Red Dead series, and was released for the PlayStation 3 and Xbox 360 in May 2010.";
            product.Description = TestData;
            Assert.AreEqual(product.Description, TestData);
        }
        [TestMethod]
        public void UnitPriceOK()
        {
            ClsProduct product = new ClsProduct();
            float TestData = 49.99f;
            product.UnitPrice = TestData;
            Assert.AreEqual(product.UnitPrice, TestData);
        }
        [TestMethod]
        public void OutOfStockCheck()
        {
            ClsProduct product = new ClsProduct();
            Boolean TestData = false;
            product.OutOfStock = TestData;
            Assert.AreEqual(product.OutOfStock, TestData);
        }
        [TestMethod]
        public void ReleaseDateCheck()
        {
            ClsProduct product = new ClsProduct();
            DateTime TestData = DateTime.Now.Date;
            product.ReleaseDate = TestData;
            Assert.AreEqual(product.ReleaseDate, TestData);
        }
        [TestMethod]
        public void PlatformOK()
        {
            ClsProduct product = new ClsProduct();
            String TestData = "Xbox 360";
            product.Platform = TestData;
            Assert.AreEqual(product.Platform, TestData);
        }
        [TestMethod]
        public void GenreOK()
        {
            ClsProduct product = new ClsProduct();
            String TestData = "Action-adventure";
            product.Genre = TestData;
            Assert.AreEqual(product.Genre, TestData);
        }
    }
}