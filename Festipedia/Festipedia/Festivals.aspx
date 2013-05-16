<%@ Page Title="Festivals" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Festivals.aspx.cs" Inherits="Festipedia.Festivals" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Find all the information.</h2>
    </hgroup>
    <asp:EntityDataSource ID="Test" runat="server">

    </asp:EntityDataSource>

</asp:Content>