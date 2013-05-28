<%@ Page Title="Festivals" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Festivals.aspx.cs" Inherits="Festipedia.Festivals" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
            <h1><%: Title %></h1>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <asp:GridView ID="festView" runat="server" AutoGenerateColumns="false" CssClass="festview">
            <Columns>
                <asp:BoundField DataField="fest_naam" HeaderText="Festival" SortExpression="fest_naam"/>
                <asp:BoundField DataField="fest_locatie" HeaderText="Location" SortExpression="fest_locatie"/>
                <asp:BoundField DataField="fest_datum" HeaderText="Date"  DataFormatString="{0:d}" SortExpression="fest_datum"/>
                <asp:BoundField DataField="fest_duur" HeaderText="Duration" SortExpression="fest_duur"/>
            </Columns>
        </asp:GridView>  
</asp:Content>