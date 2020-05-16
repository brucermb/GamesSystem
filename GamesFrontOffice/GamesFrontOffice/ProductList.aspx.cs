using System;
using GamesClasses;


public partial class ProductList : System.Web.UI.Page
{

    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this Is the first time the page Is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayProducts();
        }
    }

    void DisplayProducts()
    {
        //create an instance of the product collection
        GamesClasses.clsProductCollection Products = new GamesClasses.clsProductCollection();

        //set the data source to the list of products in the collection
        lstProductList.DataSource = Products.ProductList;
        
        //SET THE NAME OF THE PRIMARY KEY
        lstProductList.DataValueField = "Product_ID";
        
        //set the data field to display
        lstProductList.DataTextField = "Genre";

        //bind the data to the list
        lstProductList.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsProductCollection Products = new clsProductCollection();
        //Products.ReportByGenre(txtFilter.Text);
        lstProductList.DataSource = Products.ProductList;
        //set the name of the primary field
        lstProductList.DataValueField = "Product_ID";
        //SET THE NAME OF THE FIELD TO DISPLAY
        lstProductList.DataTextField = "Genre";
        //bind the data to the list
        lstProductList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsProductCollection Products = new clsProductCollection();
        //clear any existing filter to tidy up the interface
        //txtFilter.text = "";
        lstProductList.DataSource = Products.ProductList;
        //set the name of the primary key
        lstProductList.DataValueField = "Product_ID";
        //set the name of the field to display
        lstProductList.DataTextField = "Genre";
        //bind the data to the list
        lstProductList.DataBind();
    }

    protected void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
