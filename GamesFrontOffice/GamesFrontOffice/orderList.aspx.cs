using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class orderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if thiss is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box 
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        GamesClasses.clsOrderCollection Orders = new GamesClasses.clsOrderCollection();
        //set the data source to the list of post codes in the collection 
        lstOrders.DataSource = Orders.orderList;
        //set the name of the primary key
        lstOrders.DataValueField = "OrderNo";
        //set the data field to display
        lstOrders.DataTextField = "OrderPostcode";
        //bind the data to the list
        lstOrders.DataBind();
    }


    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}