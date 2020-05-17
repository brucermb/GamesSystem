using System;

namespace GamesClasses
{
    public class clsOrder
    {
        private Boolean mOrderActive;
        private Int32 mOrderNo;
        private DateTime mOrderDateAdded;
        private String mOrderFirstName;
        private String mOrderLastName;
        private String mOrderAddress;
        private String mOrderPostcode;
        private String mOrderCity;
        private String mOrderPhoneNumber;
        private String mOrderEmail;

        public bool OrderActive
        {
            get
            {
                return mOrderActive;
            }
            set
            {
                mOrderActive = value;
            }
        }
        public DateTime OrderDateAdded
        {
            get
            {
                return mOrderDateAdded;
            }
            set
            {
                mOrderDateAdded = value;
            }
        }
        public int OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
        public string OrderFirstName
        { get
            {
                return mOrderFirstName;
            }
            set
            {
                mOrderFirstName = value;
            }
        }
        public string OrderLastName
        {
            get
            {
                return mOrderLastName;
            }
            set
            {
                mOrderLastName = value;
            }
        }
        public string OrderAddress
        {
            get
            {
                return mOrderAddress;
            }
            set
            {
                mOrderAddress = value;
            }
        }
        public string OrderPostcode
        {
            get
            {
                return mOrderPostcode;
            }
            set
            {
                mOrderPostcode = value;
            }
        }
        public string OrderCity
        {
            get
            {
                return mOrderCity;
            }
            set
            {
                mOrderCity = value;
            }
        }
        public string OrderPhoneNumber
        {
            get
            {
                return mOrderPhoneNumber;
            }
            set
            {
                mOrderPhoneNumber = value;
            }
        }
        public string OrderEmail
        {
            get
            {
                return mOrderEmail;
            }
            set
            {
                mOrderEmail = value;
            }
        }

        public bool Find(int OrderNo)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Order No to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_FilterByOrderNo");

            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                mOrderActive = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderActive"]);
                mOrderFirstName = Convert.ToString(DB.DataTable.Rows[0]["OrderFirstName"]);
                mOrderLastName = Convert.ToString(DB.DataTable.Rows[0]["OrderLastName"]);
                mOrderAddress = Convert.ToString(DB.DataTable.Rows[0]["OrderAddress"]);
                mOrderPostcode = Convert.ToString(DB.DataTable.Rows[0]["OrderPostcode"]);
                mOrderCity = Convert.ToString(DB.DataTable.Rows[0]["OrderCity"]);
                mOrderPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["OrderPhoneNumber"]);
                mOrderEmail = Convert.ToString(DB.DataTable.Rows[0]["OrderEmail"]);
                mOrderDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDateAdded"]);
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
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

        public void Delete(Int32 OrderNo)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Order No to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_Delete");
        }

        public string Valid(string OrderNo,
                            string OrderFirstName,
                            string OrderLastName,
                            string OrderAddress,
                            string OrderPostcode,
                            string OrderCity,
                            string OrderPhoneNumber,
                            string OrderEmail,
                            string OrderDateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the FirstName is blank
            if (OrderFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank: ";
            }
            //if the first Name is greater than 25 characters
            if (OrderFirstName.Length > 25)
            {
                Error = Error + "The first name must be less than 25 characters: ";
            }
            if (OrderLastName.Length == 0)
            {
                //record the error
                Error = Error + "The last name may not be blank: ";
            }
            //if the first Name is greater than 25 characters
            if (OrderLastName.Length > 25)
            {
                Error = Error + "The less must be less than 25 characters: ";
            }
            //copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(OrderDateAdded);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past: ";
            }
            //return any error messages
            return Error;
        }


    }
}