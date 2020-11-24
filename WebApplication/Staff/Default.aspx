<%@ Page Title="Staff" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Staff.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    .service-body {
        margin: 30px 0;
    }
    .wordfilter-textarea {
        resize: none;
        width: 100%;
        max-width: 100%;
        height: 80px;
    }
    .service-container {
        margin: 80px 0;
    }
    .service-list > li {
        font-size: 16px;
    }
    </style>
    <div class="jumbotron">
        <h1 class="display-4">Staff Page</h1>
        <p class="lead">This page is only available to staff</p>
        <hr class="my-4"/>
        <p>Please try testing our services below</p>
    </div>

    <div class="section">
        <h2>Available Staff services</h2>
        <ul class="service-list">
            <li><a runat="server" href="#WordCountService">Word Count Service</a></li>
        </ul>
        <hr class="my-4" />
    </div>

    <div class="section service-container" id="WordCountService">
        <h2>Word Count Service</h2>
        <p><strong>Service Reference:</strong> <a href="http://webstrar83.fulton.asu.edu/Page3/Service.svc?wsdl">webstrar83.fulton.asu.edu/Page3/Service.svc?wsdl</a></p>
        <p>This service is used to to count words in a block of text</p>
        <p>Try out this service by typing some text into the input box below and then clicking "Count Words"</p>
        <div class="row service-body">
            <div class="col-md-6" style="margin: 10px 0">
                <div><strong>Input</strong></div>
                <asp:TextBox CssClass="wordfilter-textarea" runat="server" ID="WordCountInput" TextMode="MultiLine"></asp:TextBox>

            </div>
            <div class="col-md-6" style="margin: 10px 0">
                <h3>Word Count: <asp:Label runat="server" ID="WordCountOutput"></asp:Label></h3>
            </div>
        </div>
        <asp:Button type="button" Text="Count Words" runat="server" ID="WordCountButton" onClick="CountWords" CssClass="btn btn-primary" />
    </div>
   
</asp:Content>
