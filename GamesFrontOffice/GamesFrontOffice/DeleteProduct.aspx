﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteProduct.aspx.cs" Inherits="DeleteProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this product record?<br />
            <br />
&nbsp;<asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
            &nbsp;<asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>
