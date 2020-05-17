<%@ Page Language="C#" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 587px">
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 478px; top: 199px; position: absolute"></asp:TextBox>
        </div>
        <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; left: 413px; top: 121px; position: absolute; width: 86px;"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 385px; top: 201px; position: absolute; height: 25px" Text="First Name"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 385px; top: 240px; position: absolute" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 478px; top: 242px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 354px; top: 108px; position: absolute; width: 57px;" Text="Order Number"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 384px; top: 280px; position: absolute" Text="Address"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 386px; top: 355px; position: absolute" Text="Post Code"></asp:Label>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 522px; top: 115px; position: absolute" Text="Find" />
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 388px; top: 163px; position: absolute; bottom: 495px" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 480px; top: 162px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 388px; top: 320px; position: absolute; right: 449px" Text="City"></asp:Label>
        </p>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 478px; top: 282px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 480px; top: 318px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 478px; top: 356px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 478px; top: 395px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 368px; top: 397px; position: absolute" Text="Phone Number"></asp:Label>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 370px; top: 446px; position: absolute" Text="DateAdded"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="Active" runat="server" style="z-index: 1; left: 372px; top: 478px; position: absolute; margin-bottom: 0px" />
        </p>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 478px; top: 442px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 356px; top: 558px; position: absolute; margin-top: 0px" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 322px; top: 558px; position: absolute; right: 1459px" Text="OK" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 320px; top: 518px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
