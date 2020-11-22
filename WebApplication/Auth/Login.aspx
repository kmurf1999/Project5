<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication.Auth.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Please Login</h1>
    <section id="loginForm">
        <asp:TextBox ID="usernameInput" runat="server" autofocus="true"></asp:TextBox>
        <asp:TextBox ID="passwordInput" runat="server" type="password"></asp:TextBox>
        <asp:Button ID="loginButton" runat="server" Text="Sign In" OnClick="DoLogin" />
    </section>
</asp:Content>
