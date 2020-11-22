<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication.Auth.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Register</h1>
    <section id="loginForm">
        <asp:TextBox ID="usernameInput" runat="server" autofocus="true"></asp:TextBox>
        <asp:TextBox ID="passwordInput" runat="server" type="password"></asp:TextBox>
        <asp:Button ID="signupButton" runat="server" Text="Sign Up" OnClick="DoSignup" />
    </section>
</asp:Content>
