<%@ Page Title="Festivals" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Festivals.aspx.cs" Inherits="Festipedia.Festivals" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
            <h1><%: Title %></h1>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <asp:GridView ID="festView" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="fest_naam" HeaderText="Festival" />
                <asp:BoundField DataField="fest_locatie" HeaderText="Locatie" />
                <asp:BoundField DataField="fest_datum" HeaderText="Datum"  DataFormatString="{0:d}"/>
                <asp:BoundField DataField="fest_duur" HeaderText="Duur" />
            </Columns>
        </asp:GridView>  
</asp:Content>