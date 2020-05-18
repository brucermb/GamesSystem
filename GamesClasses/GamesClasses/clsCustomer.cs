using System;
using System.Web.Configuration;

private decimal mCustomerTotal;

namespace GamesClasses
{

        public class clsCustomer
        {
        private Boolean mCustomerActive;
        private int mCustomerNo;
        private DateTime mCustomerDateAdded;
        private decimal mCustomerTotal;
        private string mCustomerFirstName;
        private string mCustomerLastName;
        private string mCustomerAddress;
        private string mCustomerPostcode;
        private string mCustomerTown;
        private string mCustomerPhoneNumber;
        private string mCustomerEmail;
        private string mCustomerDateOfBirth;

        public list<clsCustomer> CustomerList { 
            get
        {
                return mCustomerNo;
        }
            set
            {
                mCustomerNo = value
            }
            public void Delete()
        {
            //deletes the record pointed to by CustomerAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerAddress", mCustomerAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomerAddress_Delete");
        }

        public bool Find(int CustomerAddress)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer No to search for
            DB.AddParameter("@CustomerAddress", CustomerAddress);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerAddress");

        }
        public int add()
    {
    //adds a new record to the database based on the values of the MCustomerAddress
    //set the primary key value of the new record
    mCustomerAddress.CustomerAddressNo = 12
    //return the primary key of the new record
    return mCustomerAddress.CustomerAddress
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
            public DateTime CustomerDateAdded
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
            public string CustomerTown
            {
                get
                {
                    return mCustomerTown;
                }
                set
                {
                    mCustomerTown = value;
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
            set => mCustomerEmail = value;
               
            public string CustomerDateOfBirth
            {
                get
                {
                    return mCustomerDateOfBirth;
                }
                set
                {
                    mCustomerDateOfBirth = value;
                }
                }
            }
            }

         
            public void Delete(int CustomerNo)
            {
                //create an instance of the data connection 
                clsDataConnection DB = new clsDataConnection();
                //add the parameter for the Customer No to search for
                DB.AddParameter("@CustomerNo", CustomerNo);
                //execute the stored procedure 
                DB.Execute("sproc_tblCustomer_Delete");
            }

    public bool Find(int CustomerAddress)
{
    //set the private data members to the test data value
    CustomerAddress = 10 Downing Street;
    //create an instance of the data connection 
    clsDataConnection DB = new clsDataConnection();
    //add the parameter for the Customer No to search for
    DB.AddParameter("@CustomerAddress", CustomerAddress
    //execute the stored procedure 
    DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
}


}
        
