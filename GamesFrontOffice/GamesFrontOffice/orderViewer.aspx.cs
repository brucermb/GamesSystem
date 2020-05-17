using System;
using GamesClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder anOrder = new clsOrder();
        //get the date from the session object
        anOrder = (clsOrder)Session["anOrder"];
        //display the order number for this entry
        Response.Write(anOrder.OrderNo);
    }
}