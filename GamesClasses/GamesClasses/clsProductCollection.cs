using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamesClasses
{
    public class clsProductCollection
    {
        //private data member for the list
        List<clsProduct> mProductList = new List<clsProduct>();
        //private data member thisAddress
        clsProduct mThisProduct = new clsProduct();

        public clsProduct ThisProduct
        {
            get =>
                //return the private data
                mThisProduct;
            set =>
                //set the private data
                mThisProduct = value;
        }

        //constructor for the class
        public clsProductCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //Object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_SelectAll");
            PopulateArray(DB);
            //get the count of records
            RecordCount = DB.Count;
            //While there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsProduct AProduct = new clsProduct();
                //read in the fields from the current record
                AProduct.Out_Of_Stock = Convert.ToString(DB.DataTable.Rows[Index]["Active"]);
                AProduct.Product_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Product_ID"]);
                AProduct.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AProduct.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AProduct.Unit_Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Unit_Price"]);
                AProduct.Release_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Release_Date"]);
                AProduct.Platform = Convert.ToString(DB.DataTable.Rows[Index]["Platform"]);
                AProduct.Genre = Convert.ToString(DB.DataTable.Rows[Index]["Genre"]);
                //add the record to the private data member
                mProductList.Add(AProduct);
                //point at the next record
                Index++;

            }
        }

        public List<clsProduct> ProductList {
            get => mProductList;
            set => mProductList = value;
        }


        public int Count
        {
            get => mProductList.Count;
            set
            {
                //worrying about this later? }
            }
        }


        public int Add()
        {
            //adds a new record to the database based on the values of mThisProduct
            //Set the primary key of the new record
            mThisProduct.Product_ID = 123;
            //return the primary key of the new record
            return mThisProduct.Product_ID;

        }

        public void Delete()
        {
            //deletes the record pointed to by thisProduct
            //connect to DB
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Product_ID", mThisProduct.Product_ID);
            //execute stored procedure
            DB.Execute("sproc_tblProduct_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Product_ID", mThisProduct.Product_ID);
            DB.AddParameter("@Title", mThisProduct.Title);
            DB.AddParameter("@Description", mThisProduct.Description);
            DB.AddParameter("@Unit_Price", mThisProduct.Unit_Price);
            DB.AddParameter("@Out_Of_Stock", mThisProduct.Out_Of_Stock);
            DB.AddParameter("@Release_Date", mThisProduct.Release_Date);
            DB.AddParameter("@Platform", mThisProduct.Platform);
            DB.AddParameter("@Genre", mThisProduct.Genre);
            DB.AddParameter("@Active", mThisProduct.Active);
            //execute stored proc
            DB.Execute("sproc_tblProduct_Update");
        }

        public void ReportByGenre(string Genre)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Genre", Genre);
            DB.Execute("sproc_tblProduct_FilterByGenre");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //POPULATES THE ARRAY LIST BASED ON THE DATA TABLE IN THE PARAMETER DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //Clear the private array list
            mProductList = new List<clsProduct>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsProduct AProduct = new clsProduct();
                //read in the fields from the current record
                AProduct.Out_Of_Stock = Convert.ToString(DB.DataTable.Rows[Index]["Active"]);
                AProduct.Product_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Product_ID"]);
                AProduct.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AProduct.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AProduct.Unit_Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Unit_Price"]);
                AProduct.Release_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Release_Date"]);
                AProduct.Platform = Convert.ToString(DB.DataTable.Rows[Index]["Platform"]);
                AProduct.Genre = Convert.ToString(DB.DataTable.Rows[Index]["Genre"]);
                //add the record to the private data member
                mProductList.Add(AProduct);
                //Point at the next record
                Index++;
            }
        }
    }


    }