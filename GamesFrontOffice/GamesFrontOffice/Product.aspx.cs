using GamesClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Product : System.Web.UI.Page
{
    Int32 Product_ID;


    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the product to be processed
        Product_ID = Convert.ToInt32(Session["Product_ID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (Product_ID != -1)
            {
                //display the current data for the record
                DisplayProduct();
            }
        }


    }

    void DisplayProduct()
    {
        clsProductCollection AProduct = new clsProductCollection();
        //find the record to update
        AProduct.ThisProduct.Find(Product_ID);
        //display the record to update
        txtProductID.Text = AProduct.ThisProduct.Product_ID.ToString();
        txtTitle.Text = AProduct.ThisProduct.Title;
        txtDescription.Text = AProduct.ThisProduct.Description;
        txtUnitPrice.Text = AProduct.ThisProduct.Unit_Price.ToString();
        txtReleaseDate.Text = AProduct.ThisProduct.Release_Date.ToString();
        txtGenre.Text = AProduct.ThisProduct.Genre;
        txtOut_Of_Stock.Text = AProduct.ThisProduct.Out_Of_Stock;
        txtPlatform.Text = AProduct.ThisProduct.ToString();
    }

    //event handler for the ok button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //creates a new instance of clsProduct
        clsProduct AProduct = new clsProduct();
        //capture product_id
        string ProductID = Convert.ToString(txtProductID);       
        //capture title
        string Title = txtTitle.Text;
        //Capture Description
        string Description = txtDescription.Text;
        //Capture unit price
        string Unit_Price = txtUnitPrice.Text;
        //Capture Platform
        string Platform = txtPlatform.Text;
        //Capture Release_Date
        string Release_Date = txtReleaseDate.Text;
        //Capture Genre
        string Genre = txtGenre.Text;
        //Capture Out of stock
        string Out_Of_Stock = txtOut_Of_Stock.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AProduct.Valid(Title, Description, Unit_Price, Release_Date, Platform, Genre);
        if (Error == "")
        {
            //capture the product id
            AProduct.Product_ID = Product_ID;

            //capture the title
            AProduct.Title = Title;
            //capture the Description
            AProduct.Description = Description;
            //capture the Unit price
            AProduct.Unit_Price = Convert.ToDouble(Unit_Price);
            //capture the genre
            AProduct.Genre = Genre;
            //Capture the platform
            AProduct.Platform = Platform;
            //Capture the release date
            AProduct.Release_Date = Convert.ToDateTime(Release_Date);
            //capture the out of stock status
            AProduct.Out_Of_Stock = Out_Of_Stock;
         
            
            //Create a new instance of the address collection
            clsProductCollection ProductList = new clsProductCollection();
            //if this is a new record then add the data
            if (Product_ID == -1)
            {
                //set the ThisProduct property
                ProductList.ThisProduct = AProduct;
                //Add the new record
                ProductList.Add();

            }
            else//otherwise must be an update
            {
                //find the record to update
                ProductList.ThisProduct.Find(Product_ID);
                //set the thisproduct property
                ProductList.ThisProduct = AProduct;
                //update the record
                ProductList.Update();
            }

            //Redirect back to the listpage
            Response.Redirect("ProductList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

        //store the product id in the session object
        Session["AProduct"] = AProduct;
        //Redirect to the viewer page
        Response.Redirect("ProductViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        Int32 Product_ID;
        Boolean Found = false;
        Product_ID = Convert.ToInt32(txtProductID.Text);
        Found = AProduct.Find(Product_ID);
        if (Found == true)
        {
            txtTitle.Text = AProduct.Title;
            txtDescription.Text = AProduct.Description;
            txtUnitPrice.Text = AProduct.Unit_Price.ToString();
            txtReleaseDate.Text = AProduct.Release_Date.ToString();
            txtGenre.Text = AProduct.Genre.ToString();
            txtPlatform.Text = AProduct.Platform.ToString();
            txtOut_Of_Stock.Text = AProduct.Out_Of_Stock.ToString();

        }

    }

    //this is the event handler for the cancel button
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("Default.aspx");
    }
}