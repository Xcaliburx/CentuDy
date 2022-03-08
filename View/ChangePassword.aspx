<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="ProjectFinal.View.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="ViewProfile.aspx">Back</a>
            <h1>Change Password</h1>
            <br /> <br />

            <asp:Label ID="Label5" runat="server" Text="Username: "></asp:Label>
            <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
            <br /> <br />

            <asp:Label ID="Label1" runat="server" Text="Old Password: "></asp:Label> <br />
            <asp:TextBox ID="txtOld" TextMode="Password" runat="server"></asp:TextBox>
            <br /> <br />

            <asp:Label ID="Label2" runat="server" Text="New Password: "></asp:Label> <br />
            <asp:TextBox ID="txtNew" TextMode="Password" runat="server"></asp:TextBox>
            <br /> <br />

            <asp:Label ID="Label3" runat="server" Text="Confirm Password: "></asp:Label> <br />
            <asp:TextBox ID="txtConfirm" TextMode="Password" runat="server"></asp:TextBox>
            <br /> <br />

            <asp:Button ID="btnChange" runat="server" Text="Change Password" OnClick="btnChange_Click"/>
            <asp:Label ID="msglbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
