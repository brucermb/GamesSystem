using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GamesClasses;

public partial class DeleteProduct : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 Product_ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        Product_ID = Convert.ToInt32(Session["Product_ID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //CREATE A NEW INSTANCE OF THE PRODUCT LIST
        clsProductCollection ProductList = new clsProductCollection();
        //find the record to delete
        ProductList.ThisProduct.Find(Product_ID);
        //delete the record
        ProductList.Delete();
        //redirect back to the main page
        Response.Redirect("ProductList.aspx");


    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("ProductList.aspx");
    }
}