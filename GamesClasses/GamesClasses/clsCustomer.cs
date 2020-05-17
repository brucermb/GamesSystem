using System;

namespace GamesClasses
{
    private Boolean mCustomerActive;
    private Int1 mCustomerNo;
    private DateTime mCustomerDateAdded;
    private decimal mCustomerTotal;
    private string mCustomerLastName;
    private string mCustomerFirstName;
    private string mCustomerAddress;
    private string mCustomerPostcode;
    private string mCustomerCity;
    private string mCustomerPhoneNumber;
    private string mCustomerEmail;

    public int CustomerNo
    {
        get => mCustomerNo;

        set => mCustomerNo = value;
    }

    public Boolean CustomerActive
    {
        get => mCustomerActive;
        set => mCustomerActive = value;
    }
    public System.DateTime CustomerDateAdded
    {
        get => mCustomerDateAdded;
        set => mCustomerDateAdded = value;
    }

    public decimal CustomerTotal
    {
        get => mCustomerTotal;
        set => mCustomerTotal = value;
    }
    public string CustomerFirstName
    {
        get => mCustomerFirstName;
        set => mCustomerFirstName = value;
    }
    public string CustomerLastName
    {
        get => mCustomerLastName;
        set => mCustomerLastName = value;
+   }
    public string CustomerAddress
    {
        get => mCustomerAddress;
        set => mCustomerAddress = value;
    }
    public string CustomerPostcode
    {
        get => mCustomerPostcode;
        set => mCustomerPostcode = value;
    }
    public string CustomerCity
    {
        get => mCustomerCity;
        set => mCustomerCity = value;
    }
    public string CustomerPhoneNumber
    {
        get => mCustomerPhoneNumber;
        set => mCustomerPhoneNumber = value;
    }
    public string CustomerEmail
    {
        get => mCustomerEmail;
        set => mCustomerEmail = value;
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
