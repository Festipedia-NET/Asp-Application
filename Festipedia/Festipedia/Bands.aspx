<%@ Page Title="<%$Resources:Resource, groepen %>" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bands.aspx.cs" Inherits="Festipedia.Bands" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
            <h1><%: Title %></h1>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <a href="BandDetail.aspx" class="button margbutton">Band Details</a>
    <asp:GridView ID="bandView" runat="server" AutoGenerateColumns="false" CssClass="bandview" AllowPaging="true" OnPageIndexChanging="bandView_PageIndexChanging" OnSorting="bandView_Sorting" PageSize="15">
        <Columns>
            <asp:BoundField DataField="band_naam" HeaderText="<%$Resources:Resource, bandnaam %>"/>
            <asp:BoundField DataField="band_soortMuziek" HeaderText="<%$Resources:Resource, genre %>"/>
            <asp:HyperLinkField HeaderText="Website" DataNavigateUrlFields="band_url" DataTextField="band_url" Target="_blank"/>
        </Columns>
    </asp:GridView>  
</asp:Content>