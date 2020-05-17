<%@ Page Language="C#" MasterPageFile="~/Product.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <asp:Label ID="lblProductID" runat="server" Text="Product ID" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtProductID" runat="server" Width="218px" ></asp:TextBox>
            <asp:Button ID="lblFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblTitle" runat="server" Text="Title" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtTitle" runat="server" Width="220px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblDescription" runat="server"  Text="Description" Width="200px" length="300px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDescription" runat="server" Height="82px" Width="222px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblUnitPrice" runat="server" Text="Unit Price" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtUnitPrice" runat="server" style="margin-left: 100px" Width="215px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblReleaseDate" runat="server" Text="Release Date" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtReleaseDate" runat="server" style="margin-left: 100px" Width="215px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblGenre" runat="server" Text="Genre" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtGenre" runat="server" style="margin-left: 100px" Width="215px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPlatform" runat="server" Text="Platform" Width="100px"></asp:Label>
            <asp:TextBox ID="txtPlatform" runat="server" style="margin-left: 100px" Width="215px" ></asp:TextBox>
            <br />
    <asp:Label ID="lblOutOfStock" runat="server" Text="Out Of Stock" Width="100px"></asp:Label>
            <asp:TextBox ID="txtOut_Of_Stock" runat="server" style="margin-left: 100px" Width="215px" ></asp:TextBox>
    <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1;" Text="Active" />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="61px" OnClick="btnCancel_Click" />
            <br />
            <br />
    <asp:Label ID="lblError" runat="server" ></asp:Label>  
    </asp:content>