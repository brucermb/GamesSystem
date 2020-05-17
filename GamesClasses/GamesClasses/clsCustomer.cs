using System;

namespace GamesClasses
{
    public class clsCustomer
    {
        
            {
        private Boolean mCustomerActive;
        private Int1 mCustomerNo;
        private DateTime mCustomerDateAdded;
        private Decimal mCustomerTotal;
        private String mCustomerLastName;
        private String mCustomerFirstName;
        private String mCustomerAddress;
        private String mCustomerPostcode;
        private String mCustomerCity;
        private String mCustomerPhoneNumber;
        private String mCustomerEmail;

        public int CustomerNo
        {
            get
            {
                return mCustomerNo;
            }

            set
            {
                mCustomerNo = value;
            }
        }

        public Boolean CustomerActive
        {
            get
            {
                return mCustomerActive;
            }
            set
            {
                mCustomerActive = value;
            }
        }
        public System.DateTime CustomerDateAdded
        {
            get
            {
                return mCustomerDateAdded;
            }
            set
            {
                mCustomerDateAdded = value;
            }
        }
        
        public decimal CustomerTotal
        {
            get
            {
                return mCustomerTotal;
            }
            set
            {
                mCustomerTotal = value;
            }
        }
        public string CustomerFirstName
        {
            get
            {
                return mCustomerFirstName;
            }
            set
            {
                mCustomerFirstName = value;
            }
        }
        public string CustomerLastName
        {
            get
            {
                return mCustomerLastName;
            }
            set
            {
                mCustomerLastName = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }
        public string CustomerPostcode
        {
            get
            {
                return mCustomerPostcode;
            }
            set
            {
                mCustomerPostcode = value;
            }
        }
        public string CustomerCity
        {
            get
            {
                return mCustomerCity;
            }
            set
            {
                mCustomerCity = value;
            }
        }
        public string CustomerPhoneNumber
        {
            get
            {
                return mCustomerPhoneNumber;
            }
            set
            {
                mCustomerPhoneNumber = value;
            }
        }
        public string CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }

        public object Convert { get; private set; }

        public bool Find(int CustomerNo)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer No to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");

            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mCustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerActive"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerPostcode = Convert.ToString(DB.DataTable.Rows[0]["CustomerPostcode"]);
                mCustomerCity = Convert.ToString(DB.DataTable.Rows[0]["CustomerCity"]);
                mCustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhoneNumber"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerTotal = Convert.ToDecimal(DB.DataTable.Rows[0]["CustomerTotal"]);
                mCustomerDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDateAdded"]);
                mCustomerNo = Convert.ToInt1(DB.DataTable.Rows[0]["CustomerNo"]);
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

        public void Delete(Int1 CustomerNo)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer No to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_Delete");
        }



    }

    public class Int1
    {
    }
}
