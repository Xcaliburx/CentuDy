<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMedicine.aspx.cs" Inherits="ProjectFinal.View.UpdateMedicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="ViewMedicine.aspx">Back</a>
            <br />

            <h1>Update Medicines</h1>

            <div>
                <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
                <br />
                <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
                <br /> <br />

                <asp:Label runat="server" Text="Description:"></asp:Label>
                <br />
                <asp:TextBox ID="descriptionTxt" runat="server"></asp:TextBox>
                <br /> <br />

                <asp:Label runat="server" Text="Stock:"></asp:Label>
                <br />
                <asp:TextBox ID="numberTxt" runat="server" TextMode="Number"></asp:TextBox>
                <br /> <br />
                
                <asp:Label runat="server" Text="Price:"></asp:Label>
                <br />
                <asp:TextBox ID="priceTxt" runat="server" TextMode="Number"></asp:TextBox>
                <br /> <br />
                
                <asp:Button ID="update" runat="server" Text="Submit" OnClick="update_Click"/>
                <br /> <br />
                
                <asp:Label ID="msgLbl" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
