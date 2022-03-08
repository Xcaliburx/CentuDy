<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="ProjectFinal.View.ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="HomePage.aspx">Back to HomePage</a>
        <div>
            <h1>View Cart</h1>
        </div>

        <asp:Repeater ID="CartData" runat="server">
            <ItemTemplate>
                Medicine Name:
                <asp:Label ID="nameTxt" runat="server" Text=' <%# Eval ("Medicine.Name") %>'></asp:Label>
                <br />

                Medicine Price:
                <asp:Label ID="priceTxt" runat="server" Text=' <%# Eval ("Medicine.Price") %>'></asp:Label>
                <br />

                Quantity:
                <asp:Label runat="server" Text=' <%# Eval ("Quantity") %>'></asp:Label>
                <br />

                Subtotal:
                <asp:Label ID="subTotalTxt" runat="server" Text='<%# (Convert.ToInt32( Eval ("Medicine.Price")) * Convert.ToInt32(Eval ("Quantity"))).ToString() %>'></asp:Label>
                <br /><br />

                <asp:Button ID="Delete" UseSubmitBehavior="false" CommandArgument='<%# Eval ("MedicineId") %>' runat="server" Text="Remove Item" OnClick="Delete_Click"/>
                <br /><br /> <br />
            </ItemTemplate>
        </asp:Repeater>

        <asp:Label ID="tesLabel" runat="server" Text=""></asp:Label>
        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="GrandTotal: "></asp:Label>
        <asp:Label ID="subtotal" runat="server" Text=""></asp:Label>

        <br />
        <asp:Button ID="Checkout" runat="server" Text="Checkout" OnClick="Checkout_Click"/>
    </form>
</body>
</html>
