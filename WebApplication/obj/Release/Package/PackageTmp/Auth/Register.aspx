<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication.Auth.Register" %>
<%@ Register Assembly="BotDetect" Namespace="BotDetect.Web.UI" TagPrefix="BotDetect" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    .signup-header {
        margin: 30px 0;
        text-align: center;
    }
    .error-text {
        color: red;
    }
    #signupForm {
        margin: 0 auto;
        width: fit-content;
    }
    </style>
    <h1 class="signup-header">Please Signup</h1>
    <div id="signupForm">
            <div class="form-group">
                <asp:Label ID="usernameLabel" runat="server" AssociatedControlID="usernameInput">Username</asp:Label>
                <asp:TextBox ID="usernameInput" runat="server" CssClass="form-control" autofocus="true"></asp:TextBox>
                <asp:Label CssClass="error-text" ID="usernameError" runat="server" AssociatedControlID="usernameInput"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Label ID="passwordLabel" runat="server" AssociatedControlID="passwordInput">Password</asp:Label>
                <asp:TextBox ID="passwordInput" runat="server"  CssClass="form-control" type="password"></asp:TextBox>
                <asp:Label CssClass="error-text" ID="passwordError" runat="server" AssociatedControlID="passwordInput"></asp:Label>
            </div>
           <div class="form-group">
                <asp:Label ID="passwordAgainLabel" runat="server" AssociatedControlID="passwordAgainInput">Repeat Password</asp:Label>
                <asp:TextBox ID="passwordAgainInput" runat="server"  CssClass="form-control" type="password"></asp:TextBox>
                <asp:Label CssClass="error-text" ID="passwordAgainError" runat="server" AssociatedControlID="passwordAgainInput"></asp:Label>
            </div>
            <div class="form-group">
                <BotDetect:WebFormsCaptcha ID="RegisterCaptcha" runat="server" UserInputID="CaptchaCodeTextBox" />
                <asp:TextBox CssClass="form-control" ID="CaptchaCodeTextBox" runat="server" />
                <asp:Label CssClass="error-text" ID="CaptchaError" runat="server" AssociatedControlID="CaptchaCodeTextBox"></asp:Label>
            </div>
            <div>
                <asp:Button ID="registerButton" CssClass="btn btn-primary btn-block" runat="server" Text="Sign Up" OnClick="DoSignup" />
            </div>

    </div>
</asp:Content>