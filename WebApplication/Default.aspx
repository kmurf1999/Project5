<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
     .custom-row {
         display: grid;
         grid-template-columns: 1fr 1fr;
         grid-gap: 20px;
     }
    .protected-link {
        background: #eee;
        border-radius: 6px;
        width: 100%;
        padding: 20px;
         color: inherit;
    }
    .protected-link > h2 {
        color: cornflowerblue;
    }
    .protected-link:hover {
        transform: translateY(-5px);
        transition: transform .3s ease;
    }
    </style>

    <div class="jumbotron">
      <h1 class="header">Project 5</h1>
      <p>This website is the final project for CSE445</p>
      <p class="text-muted">Created by Kyle Murphy & Luke Shumaker</p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <ul class="list-group">
                <li class="list-group-item">Below you will find links to both our staff and member pages.</li>
                <li class="list-group-item">You must be logged-in with the correct credentials to access these pages.</li>
                <li class="list-group-item">To login or register, please use the links located on the top bar of the this page.</li>
            </ul>
        </div>
    </div>

    <div class="custom-row">
        <a href="~/Staff/Default" runat="server" class="col-md-6 protected-link">
            <h2>Staff Only</h2>
            <p>Access Staff-only page to test services only available to staff members</p>
            <p>You must be logged-in on a staff account to access this page</p>
        </a>
        <a href="~/Member/Default" runat="server" class="col-md-6 protected-link">
            <h2>Members Only</h2>
            <p>Access Member-only page to test services only available to members</p>
            <p>You must be logged-in on a member account to access this page</p>
        </a>
    </div>
</asp:Content>
