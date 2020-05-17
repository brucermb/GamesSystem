using System;
using System.Collections.Generic;

namespace GamesClasses
{
    public class clsOrderCollection
    {
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder anOrder = new clsOrder();
                //read the fields from the current record
                anOrder.OrderActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderActive"]);
                anOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                anOrder.OrderFirstName = Convert.ToString(DB.DataTable.Rows[Index]["OrderFirstName"]);
                anOrder.OrderLastName = Convert.ToString(DB.DataTable.Rows[Index]["OrderLastName"]);
                anOrder.OrderAddress = Convert.ToString(DB.DataTable.Rows[Index]["OrderAddress"]);
                anOrder.OrderPostcode = Convert.ToString(DB.DataTable.Rows[Index]["OrderPostcode"]);
                anOrder.OrderCity = Convert.ToString(DB.DataTable.Rows[Index]["OrderCity"]);
                anOrder.OrderPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["OrderPhoneNumber"]);
                anOrder.OrderEmail = Convert.ToString(DB.DataTable.Rows[Index]["OrderEmail"]);
                anOrder.OrderDateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDateAdded"]);
                //add the record to the private data member
                mOrderList.Add(anOrder);
                //point at the next record
                Index++;
            }
        }


        private clsOrder mThisOrder;

        List<clsOrder> mOrderList = new List<clsOrder>();

        public List<clsOrder> orderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                
            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
    }
}