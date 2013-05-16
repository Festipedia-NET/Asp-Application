<%@ Page Title="Festivals" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Festivals.aspx.cs" Inherits="Festipedia.Festivals" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
            <h1><%: Title %></h1>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        
    </hgroup>    
    <asp:GridView ID="festView" runat="server">
    </asp:GridView>
</asp:Content>