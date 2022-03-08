<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="ProjectFinal.View.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="HomePage.aspx">Back to HomePage</a>
            <h1>View Profile</h1>

            <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
            <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
            <br /> <br />

            <asp:Label ID="Label3" runat="server" Text="Name: "></asp:Label>
            <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
            <br /> <br />

            <asp:Label ID="Label5" runat="server" Text="Gender: "></asp:Label>
            <asp:Label ID="lblGender" runat="server" Text=""></asp:Label>
            <br /> <br />

            <asp:Label ID="Label7" runat="server" Text="Phone Number: "></asp:Label>
            <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
            <br /> <br />

            <asp:Label ID="Label9" runat="server" Text="Address: "></asp:Label>
            <asp:Label ID="lblAddress" runat="server" Text="Label"></asp:Label>
            <br /> <br />

            <asp:Button ID="btnUpdate" runat="server" Text="Update Profile" OnClick="btnUpdate_Click" />
            <br /> <br />

            <asp:Button ID="btnchange" runat="server" Text="Change Password" OnClick="btnchange_Click" />
            <br /> <br />
        </div>
    </form>
</body>
</html>
