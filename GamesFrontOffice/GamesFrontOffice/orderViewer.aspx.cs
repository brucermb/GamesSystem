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
        clsOrder anOrder = new clsOrder();
        anOrder = (clsOrder)Session["AnOrder"];
        Response.Write(anOrder.OrderNo);
    }
}