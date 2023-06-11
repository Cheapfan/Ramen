<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ramen.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Home</h1>
    <asp:Label ID="lblRole" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <% if (userlist != null) 
    { %>
        <table>
            <tr>
                <td>Id</td>
                <td>Username</td>
                <td>Email</td>
                <td>Gender</td>
                <td>Password</td>
            </tr>
            <% foreach (var tran in userlist) { %>
                <tr>
                    <td><%: tran.Id %></td>
                    <td><%: tran.Username %></td>
                    <td><%: tran.Email %></td>
                    <td><%: tran.Gender %></td>
                    <td><%: tran.Password %></td>
                </tr>
            <% } %>
        </table>
    <% } 
    %>
</asp:Content>
