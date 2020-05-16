using System;
using GamesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Games_Testing
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductListOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestItem = new clsProduct();
            TestItem.Active = true;
            TestItem.Product_ID = 000007;
            TestItem.Title = "Test";
            TestItem.Description = "Testing";
            TestItem.Unit_Price = Convert.ToDouble("50.00");
            TestItem.Release_Date = Convert.ToDateTime("12/08/1991");
            TestItem.Genre = "Horror";
            TestItem.Platform = "Sega Megadrive";
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);
        }

        //[TestMethod]
        //public void CountProductOK()
        //{
        //    clsProductCollection AllProducts = new clsProductCollection();
        //    //test data
        //    Int32 SomeCount = 2;
        //    //assign the data to property
        //    AllProducts.Count = SomeCount;
        //    Assert.AreEqual(AllProducts.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();

            TestProduct.Active = true;
            TestProduct.Product_ID = 000007;
            TestProduct.Title = "Test";
            TestProduct.Description = "Testing";
            TestProduct.Unit_Price = Convert.ToDouble("50.00");
            TestProduct.Release_Date = Convert.ToDateTime("12/08/1991");
            TestProduct.Genre = "Horror";
            TestProduct.Platform = "Sega Megadrive";

            //assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);



        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            List<clsProduct> TestList = new List<clsProduct>();
            clsProduct TestProduct = new clsProduct();

            //set its properties
            TestProduct.Active = true;
            TestProduct.Product_ID = 000007;
            TestProduct.Title = "Test";
            TestProduct.Description = "Testing";
            TestProduct.Unit_Price = Convert.ToDouble("50.00");
            TestProduct.Release_Date = Convert.ToDateTime("12/08/1991");
            TestProduct.Genre = "Horror";
            TestProduct.Platform = "Sega Megadrive";

            //add item to the test list
            TestList.Add(TestProduct);
            //Assign the data to the property
            AllProducts.ProductList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    clsProductCollection AllProducts = new clsProductCollection();
        //    Assert.AreEqual(AllProducts.Count, 2);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //creat the item of test data
            clsProduct TestProduct = new clsProduct();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            //TestProduct.Out_Of_Stock = true;
            TestProduct.Product_ID = 000007;
            TestProduct.Title = "Test";
            TestProduct.Description = "Testing";
            TestProduct.Unit_Price = Convert.ToDouble("50.00");
            TestProduct.Release_Date = Convert.ToDateTime("12/08/1991");
            TestProduct.Genre = "Horror";
            TestProduct.Platform = "Sega Megadrive";
            //set thisproduct to the test data
            AllProducts.ThisProduct = TestProduct;
            //add the record
            PrimaryKey = AllProducts.Add();
            //Set the primary key of the test data
            TestProduct.Product_ID = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);


        }

        [TestMethod]
        public void DeleteMethodOK() 
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();
            Int32 PrimaryKey = 0;
            TestProduct.Product_ID = 000007;
            TestProduct.Title = "Test";
            TestProduct.Description = "Testing";
            TestProduct.Unit_Price = Convert.ToDouble("50.00");
            TestProduct.Release_Date = Convert.ToDateTime("12/08/1991");
            TestProduct.Genre = "Horror";
            TestProduct.Platform = "Sega Megadrive";
            AllProducts.ThisProduct = TestProduct;
            PrimaryKey = AllProducts.Add();
            TestProduct.Product_ID = PrimaryKey;
            AllProducts.ThisProduct.Find(PrimaryKey);
            AllProducts.Delete();
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestProduct = new clsProduct();
            Int32 PrimaryKey = 0;
            //set its propertieis
            TestProduct.Product_ID = 000022;
            TestProduct.Title = "Test";
            TestProduct.Description = "Testing";
            TestProduct.Unit_Price = Convert.ToDouble("50.00");
            TestProduct.Release_Date = Convert.ToDateTime("12/08/1991");
            TestProduct.Out_Of_Stock = "0";
            TestProduct.Genre = "Horror";
            TestProduct.Platform = "Sega Megadrive";
            AllProducts.ThisProduct = TestProduct;
            //add test data
            PrimaryKey = AllProducts.Add();
            //set primary key of test data
            TestProduct.Product_ID = PrimaryKey;
            //modify the test data
            TestProduct.Product_ID = 000007;
            TestProduct.Title = "Test2";
            TestProduct.Description = "2Testing";
            TestProduct.Unit_Price = Convert.ToDouble("60.00");
            TestProduct.Release_Date = Convert.ToDateTime("12/08/1998");
            TestProduct.Genre = "Rythem";
            TestProduct.Platform = "Sega Saturn";
            AllProducts.ThisProduct = TestProduct;
            //set the record based on the new test data
            AllProducts.ThisProduct = TestProduct;
            //update the record
            AllProducts.Update();
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see thisproduct matches the test data
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ReportByGenreMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProductCollection FilteredProducts = new clsProductCollection();
            FilteredProducts.ReportByGenre("");
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);

        }

        [TestMethod]
        public void ReportByGenreNoneFound()
        {
            clsProductCollection FilteredProducts = new clsProductCollection();
            FilteredProducts.ReportByGenre("HotDog Sales");
            Assert.AreEqual(0, FilteredProducts.Count);
        }
        [TestMethod]
        public void ReportByGenreTestDataFound()
        {
            clsProductCollection FilteredProducts = new clsProductCollection();
            Boolean OK = true;
            FilteredProducts.ReportByGenre("Role-playing");
            //check that the correct number of records are found
            if (FilteredProducts.Count == 2)
            {
                //check that the first record product_id is 000003
                if (FilteredProducts.ProductList[0].Product_ID != 000003)
                {
                    OK = true;
                }
                //check that the first record product_id is 000004
                if (FilteredProducts.ProductList[0].Product_ID != 000004)
                {
                    OK = false;
                }
                else
                {
                    OK = false;

                }
                //test to see that there are no records
                Assert.IsTrue(OK);
            }

        }

        }
    }
