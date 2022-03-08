<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertMedicine.aspx.cs" Inherits="ProjectFinal.View.InsertMedicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="HomePage.aspx">Back to HomePage</a>
            <br />

            <a href="ViewMedicine.aspx">View Medicine</a>
            <br />

            <h1>Insert Medicine</h1>
        </div>

        <div>
            <asp:Label runat="server" Text="Name:"></asp:Label>
            <br />
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
            <br /> <br />
            
            <asp:Label runat="server" Text="Description:"></asp:Label>
            <br />
            <asp:TextBox ID="descriptionTxt" runat="server"></asp:TextBox>
            <br /> <br />
            
            <asp:Label runat="server" Text="Stock:"></asp:Label>
            <br />
            <asp:TextBox ID="numberTxt" TextMode="Number" runat="server" ></asp:TextBox>
            <br /> <br />
            
            <asp:Label runat="server" Text="Price:"></asp:Label>
            <br />
            <asp:TextBox ID="priceTxt" TextMode="Number" runat="server" ></asp:TextBox>
            <br /> <br />
            
            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="Submit_Click"/>
            <br /> <br />
            
            <asp:Label ID="msgLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
