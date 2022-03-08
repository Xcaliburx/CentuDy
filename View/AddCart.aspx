<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCart.aspx.cs" Inherits="ProjectFinal.View.AddCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="HomePage.aspx">Back to HomePage</a>
        <br /><br />

        <div>
            <h1>Add Medicine to Cart</h1>
            <br /><br />
            
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:Label ID="nametxt" runat="server" Text=""></asp:Label>
            <br /> <br />

            <asp:Label runat="server" Text="Description:"></asp:Label>
            <asp:Label ID="descriptiontxt" runat="server" Text=""></asp:Label>
            <br /> <br />

            <asp:Label runat="server" Text="Stock:"></asp:Label>
            <asp:Label ID="stocktxt" runat="server" Text=""></asp:Label>
            <br /> <br />
                
            <asp:Label runat="server" Text="Price:"></asp:Label>
            <asp:Label ID="pricetxt" runat="server" Text=""></asp:Label>
            <br /> <br />

            <asp:Label ID="Label2" runat="server" Text="Input Quantity" ></asp:Label>
            <br />
            <asp:TextBox ID="quantityTxt" runat="server"></asp:TextBox>
            <br /> <br />

            <asp:Button ID="sumbit" runat="server" Text="Submit" Onclick="sumbit_Click"/>
            <br />
            <asp:Label ID="msgLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
