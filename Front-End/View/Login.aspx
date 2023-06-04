<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Front_End.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <br />
            <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblErrUsername" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="lblPassword" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblErrPassword" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Button ID="btnLogin" runat="server" Text="Login" />
            <br />
            <br />
            <asp:Button ID="btnLoginAsGuest" runat="server" Text="Login As Guest" />
            <asp:Button ID="BtnRegister" runat="server" Text="Register" />
        </div>
    </form>
</body>
</html>
