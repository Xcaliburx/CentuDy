<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMedicine.aspx.cs" Inherits="ProjectFinal.View.ViewMedicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="HomePage.aspx">Back</a>
        <br />

        <div>
            <h1>View Medicine</h1>
        </div>

        <asp:TextBox ID="searchTxt" runat="server"></asp:TextBox>
        <asp:Button ID="searchBtn" runat="server" Text="Search"  OnClick="searchBtn_Click"/>
        <br /> <br />

        <asp:Panel ID="insert" runat="server">
            <a href="InsertMedicine.aspx">Insert Medicine</a>
            <br /> <br />
        </asp:Panel>

        <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>

        <asp:GridView ID="medicinesData" runat="server" AutoGenerateColumns="false" OnRowCommand="medicinesData_RowCommand">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="update" Text="Update" HeaderText="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="delete" Text="Delete" HeaderText="Delete" />
                <asp:ButtonField ButtonType="Button" CommandName="addCart" Text="Add To Cart" HeaderText="Add To Cart" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="Stock" HeaderText="Stock" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
            </Columns>
        </asp:GridView>

    </form>
</body>
</html>
