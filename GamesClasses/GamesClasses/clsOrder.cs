using System;

namespace GamesClasses
{
    public class clsOrder
    {
        private Boolean mOrderActive;
        private Int32 mOrderNo;
        private DateTime mDateAdded;
        private decimal mOrderTotal;
        private String mOrderFirstName;
        private String mOrderLastName;
        private String mOrderAddress;
        private String mOrderPostcode;
        private String mOrderCity;
        private String mOrderPhoneNumber;
        private String mOrderEmail;

        public Boolean OrderActive
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
        public DateTime DateAdded 
        {   get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
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
        public decimal OrderTotal 
        { get
            {
                return mOrderTotal;
            }
          set
            {
                mOrderTotal = value;
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
                mOrderCity= value;
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

        public bool Find(int orderNo)
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
                mOrderFirstName = "George";
                mOrderLastName = "Kozis";
                mOrderAddress = "42D Western Road";
                mOrderPostcode = "LE3 OBK";
                mOrderCity = "Leicester";
                mOrderPhoneNumber = "+44 457302049";
                mOrderEmail = "kozis-98@hotmail.com";
                mOrderTotal = Convert.ToDecimal(12.50M);
                mDateAdded = Convert.ToDateTime("16/09/2015");
                mOrderNo = 21;
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
    }
}