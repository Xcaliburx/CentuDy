<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectFinal.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login Page</h1>
            <a href="RegisterPage.aspx">Register Here</a>
            <br /> <br />

            <div>
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label> <br />
                <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
                <br /> <br />
            </div>

            <div>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> <br />
                <asp:TextBox TextMode="Password" ID="passwordTxt" runat="server"></asp:TextBox>
                <br /> <br />
            </div>
        
            <asp:CheckBox ID="rememberMe" runat="server" />
            <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>
            <br /> <br />

            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
            
            <br />
            <asp:Label ID="messageLbl" runat="server" Text=""></asp:Label>
        
        </div>
    </form>
</body>
</html>
