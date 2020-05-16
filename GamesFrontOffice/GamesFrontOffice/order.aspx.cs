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
            txtFirstName.Text = anOrder.OrderFirstName;
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
        //capture the order no
        anOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //capture the email
        anOrder.OrderEmail = txtEmail.Text;
        //capture the first name
        anOrder.OrderFirstName = txtFirstName.Text;
        //capture the last name
        anOrder.OrderLastName = txtLastName.Text;
        //caputre address
        anOrder.OrderAddress = txtAddress.Text;
        //capture City
        anOrder.OrderCity = txtCity.Text;
        //capture post code
        anOrder.OrderPostcode = txtPostcode.Text;
        //capture Phone Number
        anOrder.OrderPhoneNumber = txtPhoneNumber.Text;
        //capture date added
        anOrder.OrderDateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //store the order no in the session object
        Session["anOrder"] = anOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");

    }
}