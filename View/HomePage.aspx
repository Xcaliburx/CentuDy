<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectFinal.View.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblUser" runat="server" Text=""></asp:Label>
            <br /> <br />
            
            <asp:Button ID="btnmedicine" runat="server" Text="View Medicine" OnClick="btnmedicine_Click" />
            <br /> <br />

            <asp:Button ID="btnprofile" runat="server" Text="View Profile"  OnClick="btnprofile_Click"/>
            <br /> <br />

            <asp:Panel ID="cart" runat="server">
                <asp:Button ID="btnCart" runat="server" Text="View Cart" OnClick="btnCart_Click"/>
                <br /> <br />
            </asp:Panel>

            <asp:Panel ID="history" runat="server">
                <asp:Button ID="btnhistory" runat="server" Text="View Transaction History" OnClick="btnhistory_Click"/>
                <br /> <br />
            </asp:Panel>

            <asp:Panel ID="medicine" runat="server">
                <asp:Button ID="btnmedicineins" runat="server" Text="Insert Medicine" OnClick="btnmedicineins_Click"/>
                <br /> <br />
            </asp:Panel>

            <asp:Panel ID="users" runat="server">
                <asp:Button ID="btnuser" runat="server" Text="View Users" OnClick="btnuser_Click"/>
                <br /> <br />
            </asp:Panel>

            <asp:Panel ID="report" runat="server">
                <asp:Button ID="btnreport" runat="server" Text="View Transaction Report" OnClick="btnreport_Click"/>
                <br /> <br />
            </asp:Panel>


            <asp:Button ID="Btnlogout" runat="server" Text="Logout" OnClick="Btnlogout_Click" />
        </div>
    </form>
</body>
</html>
