<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ProjectFinal.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register Page</h1>
            <a href="LoginPage.aspx">Login Here</a>
            <br /> <br />

            <div>
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label> <br />
                <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
                <br /> <br />
            </div>
                
            <div>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> <br />
                <asp:TextBox ID="passwordTxt" TextMode="Password" runat="server"></asp:TextBox>
                <br /> <br />
            </div>

            <div>
                <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label> <br />
                <asp:TextBox ID="confPasswordTxt" TextMode="Password" runat="server"></asp:TextBox>
                <br /> <br />
            </div>

            <div>
                <asp:Label ID="Label7" runat="server" Text="Name"></asp:Label> <br />
                <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
                <br /> <br />
            </div>

            <div>
                <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label> <br />
                <asp:DropDownList ID="genderDdl" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                <br /> <br />
            </div>

            <div>
                <asp:Label ID="Label5" runat="server" Text="Phone Number"></asp:Label> <br />
                <asp:TextBox ID="phoneTxt" TextMode="Number" runat="server"></asp:TextBox>
                <br /> <br />
            </div>

            <div>
                <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label> <br />
                <asp:TextBox ID="addressTxt" runat="server"></asp:TextBox>
                <br /> <br />
            </div>

            <asp:Button ID="BtnRegister" runat="server" Text="Register" OnClick="BtnRegister_Click"/>

            <br />
            <asp:Label ID="msgLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
