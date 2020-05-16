<%@ Page Language="C#" AutoEventWireup="true" Codefile="ProductList.aspx.cs" Inherits="ProductList" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        HttpContext.Current.Session["Product_ID"] = -1;
        //redirect to the data entry page
        HttpContext.Current.Response.Redirect("Product.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 Product_ID;
        //if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            Product_ID = Convert.ToInt32(lstProductList.SelectedValue);
            //store the data in the session object
            HttpContext.Current.Session["Product_ID"] = Product_ID;
            //redirect to the delete page
            HttpContext.Current.Response.Redirect("DeleteProduct.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 Product_ID;
        //if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Product_ID = Convert.ToInt32(lstProductList.SelectedValue);
            //store the data in the session Object
            Session["Product_ID"] = Product_ID;
            //redirect to the edit page
            Response.Redirect("Product.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";

        }
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstProductList" runat="server" Height="283px" Width="296px" OnSelectedIndexChanged="lstProductList_SelectedIndexChanged"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            &nbsp;<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
&nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

            <br />
            <br />
            Enter a Genre
            <input id="txtbox" type="text" /><br />
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
            &nbsp;<asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
            <br />
            <br />

            <br />
            <asp:Label ID="lblError" runat="server" Text="Error"></asp:Label>
        </div>
    </form>
</body>
</html>
