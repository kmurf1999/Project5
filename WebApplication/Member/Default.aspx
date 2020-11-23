<%@ Page Title="Members" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Member.Default" %>

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
        <h1 class="display-4">Member Page</h1>
        <p class="lead">This page is only available to members</p>
        <hr class="my-4"/>
        <p>Please try testing our services below</p>
    </div>

    <div class="section">
        <h2>Available Member services</h2>
        <ul class="service-list">
            <li><a runat="server" href="#WordFilterService">Word Filter Service</a></li>
            <li><a runat="server" href="#WeatherService">Weather Service</a></li>
        </ul>
        <hr class="my-4" />
    </div>

    <div class="section service-container" id="WordFilterService">
        <h2>Word Filter Service</h2>
        <p><strong>Service Reference:</strong> <a href="http://webstrar83.fulton.asu.edu/Page1/Service.svc?wsdl">webstrar83.fulton.asu.edu/Page1/Service.svc?wsdl</a></p>
        <p>This service is used to filter out stop words from a block of text. Stop word are words that don't matter like "and", "or", and "but".</p>
        <p>Try out this service by typing some text into the input box below and then clicking "Filter Words"</p>
        <div class="row service-body">
            <div class="col-md-6">
                <div><strong>Input</strong></div>
                <asp:TextBox CssClass="wordfilter-textarea" runat="server" ID="WordFilterInput" TextMode="MultiLine"></asp:TextBox>

            </div>
            <div class="col-md-6">
                <div><strong>Output</strong></div>
                <asp:TextBox CssClass="wordfilter-textarea" runat="server" ID="WordFilterOutput" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>
        <asp:Button Text="Filter Words" runat="server" ID="WordFilterButton" onClick="FilterWords" CssClass="btn btn-primary" />
    </div>

        <div class="section service-container" id="WeatherService">
        <h2>Weather Service</h2>
        <p><strong>Service Reference:</strong> <a href="http://webstrar83.fulton.asu.edu/Page2/Service.svc?wsdl">webstrar83.fulton.asu.edu/Page2/Service.svc?wsdl</a></p>
        <p>This service allows users to easily get a 5 day average temperature forecast for a given zipcode</p>
        <p>Try it out by entering a zipcode below and then clicking "Get Weather"</p>
        
        <div class="row service-body">
            <div class="col-md-6">
                <asp:Label runat="server" ID="WeatherServiceInputLabel" AssociatedControlID="WeatherServiceInput">Enter zipcode</asp:Label>
                <asp:TextBox style="margin-bottom: 10px;" runat="server" CssClass="form-control" ID="WeatherServiceInput" />
                <asp:Button Text="Get Weather" runat="server" ID="WeatherServiceButton" onClick="GetWeather" CssClass="btn btn-primary" />

            </div>
            <div class="col-md-6">
                <ul class="list-group">
                <li class="list-group-item"><strong>Day 1: </strong><asp:Label runat="server" ID="WeatherServiceOutput1"></asp:Label></li>
                <li class="list-group-item"><strong>Day 2: </strong><asp:Label runat="server" ID="WeatherServiceOutput2"></asp:Label></li>
                <li class="list-group-item"><strong>Day 3: </strong><asp:Label runat="server" ID="WeatherServiceOutput3"></asp:Label></li>
                <li class="list-group-item"><strong>Day 4: </strong><asp:Label runat="server" ID="WeatherServiceOutput4"></asp:Label></li>
                <li class="list-group-item"><strong>Day 5: </strong><asp:Label runat="server" ID="WeatherServiceOutput5"></asp:Label></li>
            </ul>
            </div>
        </div>
   
    </div>
</asp:Content>
