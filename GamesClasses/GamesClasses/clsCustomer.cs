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
            private string mCutomerDateOfBirth;
        private string mCustomerDateOfBirth;

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
                set
                {
                    mCustomerEmail = value;
                }
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

            public interface add()
    {
    //adds a new record to the database based on the values of the MCustomerAddress
    //set the primary key value of the new record
    mCustomerAddress.CustomerAddressNo = 12
    //return the primary key of the new record
    return mCustomerAddress.CustomerAddress
    }
            public bool Find(int CustomerAddress)
            {
                //create an instance of the data connection 
                clsDataConnection DB = new clsDataConnection();
    //add the parameter for the Customer No to search for
    DB.AddParameter("@CustomerAddress", CustomerAddress);
    //execute the stored procedure 
    DB.Execute("sproc_tblCustomer_FilterByCustomerAddress");

                //If one record is found (there should be either one or zero)
                if (DB.Count == 1)
                {
        mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                    mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                    mCustomerActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerActive"]);
                    mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                    mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                    mCustomerPostcode = Convert.ToString(DB.DataTable.Rows[0]["CustomerPostcode"]);
                    mCustomerTown = Convert.ToString(DB.DataTable.Rows[0]["CustomerTown"]);
                    mCustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhoneNumber"]);
                    mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                    mCustomerTotal = Convert.ToDecimal(DB.DataTable.Rows[0]["CustomerTotal"]);
                    mCustomerDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDateAdded"]);
                    mCustomerDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDateOfBirthAdded"]);
                    
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

            public void Delete(int CustomerNo)
            {
                //create an instance of the data connection 
                clsDataConnection DB = new clsDataConnection();
                //add the parameter for the Customer No to search for
                DB.AddParameter("@CustomerNo", CustomerNo);
                //execute the stored procedure 
                DB.Execute("sproc_tblCustomer_Delete");
            }



        }
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
        
