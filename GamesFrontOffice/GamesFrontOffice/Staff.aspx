<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 499px">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="Username" Width="100px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="127px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password" Width="100px"></asp:Label>
        <asp:TextBox ID ="Textbox2" runat="server" Width ="127px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Name" Width="100px"></asp:Label>
        <asp:TextBox ID ="Textbox3" runat="server" Width ="127px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Date Of Birth" Width="100px"></asp:Label>
        <asp:TextBox ID ="Textbox4" runat="server" Width ="127px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Date Added" Width="100px"></asp:Label>
        <asp:TextBox ID ="Textbox5" runat="server" Width ="127px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1;" Text="Active" />
        <br />
        <asp:Button ID="btnOk" runat="server" Height="26px" Text="OK" Width="61px" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index:1;" Height="26px" Text="Cancel" Width="61px" OnClick="btnCancel_Click" />

    </form>
    </body>
</html>
