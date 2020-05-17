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
        //capture the order no 
        anOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //store the order in the session object
        Session["anOrder"] = anOrder;
        //redirect to the viewer page
        Response.Redirect("orderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder anOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record 
        Found = anOrder.Find(OrderNo);
        //if found 
        if (Found == true)
        {
            txtEmail.Text = anOrder.OrderEmail;
            txtOrderNo.Text = anOrder.OrderFirstName;
            txtLastName.Text = anOrder.OrderLastName;
            txtAddress.Text = anOrder.OrderAddress;
            txtCity.Text = anOrder.OrderCity;
            txtPostcode.Text = anOrder.OrderPostcode;
            txtPhoneNumber.Text = anOrder.OrderPhoneNumber;
            txtDateAdded.Text = anOrder.OrderDateAdded.ToString();

        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder anOrder = new clsOrder();
        string OrderNo = txtOrderNo.Text;
        string OrderFirstName = txtFirstName.Text;
        string OrderLastName = txtLastName.Text;
        string OrderAddress = txtAddress.Text;
        string OrderCity = txtCity.Text;
        string OrderPhoneNumber = txtPhoneNumber.Text;
        string OrderEmail = txtEmail.Text;
        string OrderPostcode = txtPostcode.Text;
        string OrderDateAdded = txtDateAdded.Text;
        //variable to store any errors
        string Error = "";
        //validate the data
        Error = anOrder.Valid(OrderNo, OrderFirstName, OrderLastName, OrderAddress, OrderPostcode, OrderCity, OrderPhoneNumber, OrderEmail, OrderDateAdded);
        if (Error == "")
        {
            anOrder.OrderNo = Convert.ToInt32(OrderNo);
            anOrder.OrderCity = OrderCity;
            anOrder.OrderAddress = OrderAddress;
            anOrder.OrderPostcode = OrderPostcode;
            anOrder.OrderDateAdded = Convert.ToDateTime(OrderDateAdded);
            Session["anOrder"] = anOrder;
            Response.Write("orderViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}