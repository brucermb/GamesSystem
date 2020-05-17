using System;

namespace GamesClasses
{
    public class clsProduct
    {
        public bool Active;

        //product_id
        //private member var
        private Int32 mProduct_ID { get; set; }
        //public member var
        public Int32 Product_ID { get { return mProduct_ID; } set { mProduct_ID = value; } }

        //title
        //private
        private string mTitle { get; set; }
        //public
        public string Title { get { return mTitle; } set { mTitle = value; } }

        //Description
        //private
        private string mDescription { get; set; }
        //public
        public string Description { get { return mDescription; } set { mDescription = value; } }

        //out of stock
        //private
        private string mOut_Of_Stock { get; set; }
        //public
        public string Out_Of_Stock { get { return mOut_Of_Stock; } set { mOut_Of_Stock = value; } }

        //Unit_Price
        //private
        private double mUnit_Price { get; set; }
        //public
        public double Unit_Price { get { return mUnit_Price; } set { mUnit_Price = value; } }

        //Platform
        //private
        private string mPlatform { get; set; }
        //public
        public string Platform { get { return mPlatform; } set { mPlatform = value; } }

        //Genre
        //private
        public string mGenre { get; set; }
        //public
        public string Genre { get { return mGenre; } set { mGenre = value; } }

        //release date
        //private
        private DateTime mRelease_Date;
        //public
        public DateTime Release_Date
        {
            get { return mRelease_Date; }
            set { mRelease_Date = value; }
        }






        public bool Find(int Product_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the product id to search for
            DB.AddParameter("@Product_ID", Product_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_filterByProductID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mProduct_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Product_ID"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mUnit_Price = Convert.ToDouble(DB.DataTable.Rows[0]["Unit_Price"]);
                mOut_Of_Stock = Convert.ToString(DB.DataTable.Rows[0]["Out_Of_Stock"]);
                mRelease_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Release_Date"]);
                mPlatform = Convert.ToString(DB.DataTable.Rows[0]["Platform"]);
                mGenre = Convert.ToString(DB.DataTable.Rows[0]["Genre"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string Title, string Description, string Unit_Price, string Release_Date, string Platform, string Genre)
        {
            //string variable to store the error
            string Error = "";

            //create a temporary variable to store date values
            DateTime DateTemp;


            //if title is blank
            if (Title.Length == 0)
            {
                Error = Error + "The product title may not be empty : ";
            }

            //if title is over 50 char
            if (Title.Length > 50)
            {
                Error = Error + "The product title must not be greater than 50 characters long : ";
            }


            //if description is blank
            if (Description.Length == 0)
            {
                Error = Error + "The product description may not be empty : ";
            }

            //if title is over 50 char
            if (Description.Length > 500)
            {
                Error = Error + "The product description must not be greater than 500 characters long : ";
            }

            //if unit price is blank
            if (Unit_Price.Length == 0)
            {
                Error = Error + "The unit price of a product can not be empty : ";
            }

            //if unit price is over 6 char (including decimal)
            if (Unit_Price.Length > 6)
            {
                Error = Error + "The unit price of a product must not be greater than 999.99 : ";
            }

            //copy the dateAdded value to the DateTemp variable
            
            try
            {
                //copy the release_date value to the datetemp variable
                DateTemp = Convert.ToDateTime(Release_Date);
                if (DateTemp < DateTime.Now.AddYears(-40))
                {
                    //record the error
                    Error = Error + "The date cannot be further than 20 years in the past : ";
                }
                if (DateTemp > DateTime.Now.AddYears(20))
                {
                    //record the error
                    Error = Error + "The date cannot be greather than 20 years in the future : ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //if genre is blank
            if (Genre.Length == 0)
            {
                Error = Error + "The product genre may not be empty : ";
            }

            //if genre is over 50 char
            if (Genre.Length > 50)
            {
                Error = Error + "The product genre must not be greater than 50 characters long : ";
            }

            //if platform is blank
            if (Platform.Length == 0)
            {
                Error = Error + "The product platform may not be empty : ";
            }

            //if platform is over 50 char
            if (Platform.Length > 50)
            {
                Error = Error + "The product platform must not be greater than 50 characters long : ";
            }



            //return any error message
            return Error;
        }




    }
}