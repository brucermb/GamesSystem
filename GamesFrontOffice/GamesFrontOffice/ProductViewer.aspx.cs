using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GamesClasses;

public partial class ProductViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creat a new instance of clsProduct
        clsProduct Product = new clsProduct();
        //get the data from the session object
        Product = (clsProduct)Session["Product"];
        //Display the product number for this entry
        //Response.Write(Product.Product_ID);
    }
}