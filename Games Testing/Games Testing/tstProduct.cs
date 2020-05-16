using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Games_Testing
{
    [TestClass]
    public class tstProduct
    {
        //good test data
        //create some test data to pass to the method
        string Title = "Test Title 123";
        string Description = "Test Description 123";
        string Unit_Price = "49.99";
        string Release_Date = "12/08/2021";
        string Platform = "Sega Megadrive";
        string Genre = "Eternal Horror";

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsProduct ATestProduct = new clsProduct();
            //Test to see that it exists
            Assert.IsNotNull(ATestProduct);
        }

        [TestMethod]
        public void ActiveProductOK()
        {
            //create an instance of the class we want to create
            clsProduct ATestProduct = new clsProduct();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property
            ATestProduct.Active = testData;
            //test to see that the two values are the same;
            Assert.AreEqual(ATestProduct.Active, testData);
        }
        [TestMethod]
        public void ReleaseDateOK()
        {
            //create an instance of the class we want to create
            clsProduct ATestProduct = new clsProduct();
            //create some test data to assign to this property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ATestProduct.Release_Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATestProduct.Release_Date, TestData);
        }
        [TestMethod]
        public void TitleOK()
        {
            clsProduct ATestProduct = new clsProduct();
            string TestData = "Test Title";
            ATestProduct.Title = TestData;
            Assert.AreEqual(ATestProduct.Title, TestData);
        }
        [TestMethod]
        public void PriceOK()
        {
            clsProduct ATestProduct = new clsProduct();
            Double TestData = 49.99;
            ATestProduct.Unit_Price = TestData;
            Assert.AreEqual(ATestProduct.Unit_Price, TestData);
        }
        [TestMethod]
        public void DescriptionOK()
        {
            clsProduct ATestProduct = new clsProduct();
            string TestData = "Product Description example";
            ATestProduct.Description = TestData;
            Assert.AreEqual(ATestProduct.Description, TestData);
        }
        [TestMethod]
        public void PlatformOK()
        {
            clsProduct ATestProduct = new clsProduct();
            string TestData = "Product Platform";
            ATestProduct.Platform = TestData;
            Assert.AreEqual(ATestProduct.Platform, TestData);
        }
        [TestMethod]
        public void GenreOK()
        {
            clsProduct ATestProduct = new clsProduct();
            string TestData = "Genre of product";
            ATestProduct.Genre = TestData;
            Assert.AreEqual(ATestProduct.Genre, TestData);
        }
        [TestMethod]
        public void ProductIDOK()
        {
            clsProduct ATestProduct = new clsProduct();
            int TestData = 000001;
            ATestProduct.Product_ID = TestData;
            Assert.AreEqual(ATestProduct.Product_ID, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Int32 Product_ID = 000001;
            Found = AProduct.Find(Product_ID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductNotFound()
        {
            //create instance of the class to be created
            clsProduct AProduct = new clsProduct();
            //boolean var to store the result of the search
            Boolean Found = false;
            //boolean var to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 000001;
            //invoke the method
            Found = AProduct.Find(Product_ID);
            //check product ID
            if (AProduct.Product_ID != 000001)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 000001;
            //invoke the method
            Found = AProduct.Find(Product_ID);
            //check the property
            if (AProduct.Release_Date != Convert.ToDateTime("08/11/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 000001;
            //invoke the method
            Found = AProduct.Find(Product_ID);
            //check the property
            if (AProduct.Title != "Death Stranding")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUnitPriceFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 000001;
            //invoke the method
            Found = AProduct.Find(Product_ID);
            //check the property
            if (AProduct.Unit_Price != 49.99)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 000001;
            //invoke the method
            Found = AProduct.Find(Product_ID);
            //check the property
            if (AProduct.Description != "Death Stranding is an action game set in an open world, and also includes asynchronous online functions.")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPlatformFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 000001;
            //invoke the method
            Found = AProduct.Find(Product_ID);
            //check the property
            if (AProduct.Platform != "Playstation 4")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGenreFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Product_ID = 000001;
            //invoke the method
            Found = AProduct.Find(Product_ID);
            //check the property
            if (AProduct.Genre != "Action")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsProduct ATestProduct = new clsProduct();
            //String variable to store any error mesages
            String Error = "";
            //invoke the method
            Error = ATestProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Title = ""; //should trigger an error
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMin()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Title = "a"; //should pass
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Title = "aa"; //should pass
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxMinusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Title = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should pass 49 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Title = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should pass 50 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Title = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should fail 51 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMidValue()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Title = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //should pass 25 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TitleExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Title = "";
            Title = Title.PadRight(500, 'a'); //should fail 500 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = ""; //should trigger an error
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = "a"; //should pass
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = "aa"; //should pass
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxMinusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = ""; //should pass 499 characters long
            Description = Description.PadRight(499, 'a'); 
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = ""; //should pass 500 characters long
            Description = Description.PadRight(500, 'a'); //should fail 5000 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = ""; //should fail 501 characters long
            Description = Description.PadRight(501, 'a'); //should fail 501 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMidValue()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = ""; //should pass 250 characters long
            Description = Description.PadRight(250, 'a'); 
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Description = "";
            Description = Description.PadRight(5000, 'a'); //should fail 5000 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Unit_PriceMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Unit_Price = ""; //should trigger an error
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Unit_PriceMin()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Unit_Price = "0.01"; //should pass
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Unit_PriceMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Unit_Price = "1.00"; //should pass
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Unit_PriceMaxMinusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Unit_Price = "999.98"; //should pass 6 characters long
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Unit_PriceMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Unit_Price = "999.99"; //should pass 6 characters long
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Unit_PriceMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Unit_Price = "1000.00"; //should fail 7 characters long
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Unit_PriceMidValue()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Unit_Price = "500.00"; //should pass 
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Unit_PriceExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Unit_Price = "2000.00";
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Release_DateMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-40); //-40 years should pass
            string Release_Date = TestDate.ToString();
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Release_DateMinMinusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-40).AddDays(-1); //-40 years, 1 day, should fail.
            string Release_Date = TestDate.ToString();
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Release_DateMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-39); //-39 years, should pass.
            string Release_Date = TestDate.ToString();
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Release_DateMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(20); //+20 years should pass
            string Release_Date = TestDate.ToString();
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Release_DateMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(20).AddDays(1); //+20 years, 1 day should fail
            string Release_Date = TestDate.ToString();
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Release_DateExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(200); //+200 years should fail
            string Release_Date = TestDate.ToString();
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Release_DateExtremeMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-200); //-200 years should fail
            string Release_Date = TestDate.ToString();
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Release_DateMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string Release_Date = TestDate.ToString();
            Error = AProduct.Valid(Title, Unit_Price, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Genre = ""; //should trigger an error
            Error = AProduct.Valid(Genre, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreMin()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Genre = "a"; //should pass
            Error = AProduct.Valid(Genre, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Genre = "aa"; //should pass
            Error = AProduct.Valid(Genre, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMaxMinusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Genre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should pass 49 characters long
            Error = AProduct.Valid(Genre, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Genre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should pass 50 characters long
            Error = AProduct.Valid(Genre, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Genre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should fail 51 characters long
            Error = AProduct.Valid(Genre, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreMidValue()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Genre = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //should pass 25 characters long
            Error = AProduct.Valid(Genre, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GenreExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Genre = "";
            Genre = Genre.PadRight(500, 'a'); //should fail 500 characters long
            Error = AProduct.Valid(Genre, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PlatformMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Platform = ""; //should trigger an error
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PlatformMin()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Platform = "a"; //should pass
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PlatformMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Platform = "aa"; //should pass
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PlatformMaxMinusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Platform = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should pass 49 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PlatformMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Platform = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should pass 50 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PlatformMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Platform = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //should fail 51 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PlatformMidValue()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Platform = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //should pass 25 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PlatformExtremeMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Platform = "";
            Platform = Platform.PadRight(500, 'a'); //should fail 500 characters long
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateInvalidData()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Release_Date = "this is not a date!";
            Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
            Assert.AreNotEqual(Error, "");
        }
        
    }
}