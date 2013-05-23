<%@ Page Title="Bands" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bands.aspx.cs" Inherits="Festipedia.Bands" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
            <h1><%: Title %></h1>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Label id=lblWelcome Text="<%$Resources:Resource, test %>" 
           runat="server"></asp:Label>
    <asp:GridView ID="bandView" runat="server" AutoGenerateColumns="false" CssClass="bandview" AllowPaging="true" OnPageIndexChanging="bandView_PageIndexChanging" OnSorting="bandView_Sorting" PageSize="15">
            <Columns>
                <asp:BoundField DataField="band_naam" HeaderText="Band Name"/>
                <asp:BoundField DataField="band_soortMuziek" HeaderText="Genre"/>
                <asp:HyperLinkField HeaderText="Website" DataNavigateUrlFields="band_url" DataTextField="band_url" Target="_blank"/>
            </Columns>
        </asp:GridView>  
</asp:Content>