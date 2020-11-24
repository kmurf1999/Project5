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
      <hr />
      <p style="font-size: 14px;" class="text-muted">Created by Kyle Murphy & Luke Shumaker</p>
    </div>

    <div style="margin-bottom: 12px;" class="section">
        <div class="row">
            <div class="col-md-12">
            <p>Below you will find links to both our staff and member pages.</p>
            <p >You must be logged-in with the correct credentials to access these pages.</p>
            <p >To login or register, please use the links located on the top bar of the this page.</p>
            </div>
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

    <div class="section">
        <div class="row">
            <div class="col-md-12">
            <h3>Service Directory</h3>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th scope="col">Provider Name</th>
                        <th scope="col">Service Name & Link</th>
                        <th scope="col">Method Signature</th>
                        <th scope="col">Description</th>
                    </tr>
                </thead>
                <tbody>
                    <tr class="bg-info">
                        <th class="" scope="row" colspan="4">Member Services</th>
                    </tr>
                    <tr>
                        <th scope="row">Kyle Murphy</th>
                        <td><a runat="server" href="~/Member/Default.aspx#WordFilterService">Stop Word Filter</a></td>
                        <td><code>string WordFilter(string text)</code></td>
                        <td><p>Filters stop words from a block of text</p></td>
                    </tr>
                    <tr>
                        <th scope="row">Kyle Murphy</th>
                        <td><a runat="server" href="~/Member/Default.aspx#WeatherService">Weather5Day</a></td>
                        <td><code>string[] Weather5day(string zipcode)</code></td>
                        <td><p>Get's 5 day average temperative forecast for a given zipcode</p></td>
                    </tr>
                    <tr class="bg-info">
                        <th class="" scope="row" colspan="4">Staff Services</th>
                    </tr>
                    <tr>
                        <th scope="row">Luke Shumaker</th>
                        <td><a runat="server" href="~/Staff/Default.aspx#WordCountService">WordCount</a></td>
                        <td><code>string WordCount(string text)</code></td>
                        <td><p>Returns the number of words in a block of text</p></td>
                    </tr>
                </tbody>
            </table>
            </div>

        </div>
    </div>
</asp:Content>
