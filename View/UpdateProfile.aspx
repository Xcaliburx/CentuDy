<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="ProjectFinal.View.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="ViewProfile.aspx">Back</a>
            <h1>Update Profile</h1>
            <br /> <br />

            <asp:Label ID="Label5" runat="server" Text="Username: "></asp:Label>
            <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
            <br /> <br />

            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label> <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br /> <br />

            <asp:Label ID="Label2" runat="server" Text="Gender: "></asp:Label> <br />
            <asp:DropDownList ID="genderDdl" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            <br /> <br />

            <asp:Label ID="Label3" runat="server" Text="Phone Number: "></asp:Label> <br />
            <asp:TextBox ID="txtPhone" TextMode="Number" runat="server"></asp:TextBox>
            <br /> <br />

            <asp:Label ID="Label4" runat="server" Text="Address: "></asp:Label> <br />
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br /> <br />

            <asp:Button ID="btnSave" runat="server" Text="Save Update" OnClick="btnSave_Click" />
            <asp:Label ID="msgLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
