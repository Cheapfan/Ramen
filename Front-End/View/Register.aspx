<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Front_End.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register</h1>
            <br />

            <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblErrUsername" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblErrEmail" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblErrPassword" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password: "></asp:Label>
            <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblErrConfirmPassword" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Label ID="lblGender" runat="server" Text="Gender: "></asp:Label>
            <asp:RadioButton ID="radioBtnGenderMale" runat="server" Text="Male" GroupName="gender" />  
            <asp:RadioButton ID="radioBtnGenderFemale" runat="server" Text="Female" GroupName="gender" />  
            <br />
            <asp:Label ID="lblErrGender" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />

            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <br />

            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Go to Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
