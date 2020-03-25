<%@ Page Language="C#" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 479px; top: 203px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 385px; top: 201px; position: absolute; height: 25px" Text="First Name"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 385px; top: 240px; position: absolute" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 478px; top: 242px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
