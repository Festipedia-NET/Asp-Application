<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="editPage.aspx.cs" Inherits="Festipedia.Edit.editPage" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
            <h1><%: Title %></h1>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <asp:HyperLink runat="server" Text="Festival toevoegen" NavigateUrl="~/Edit/add.aspx" />
        
        <asp:GridView ID="festView" runat="server" AutoGenerateColumns="False" CssClass="festview">
            <Columns>
                <asp:BoundField DataField="fest_naam" HeaderText="<%$Resources:Resource, festnaam %>" SortExpression="fest_naam"/>
                <asp:BoundField DataField="fest_locatie" HeaderText="<%$Resources:Resource, festlocatie %>" SortExpression="fest_locatie"/>
                <asp:BoundField DataField="fest_datum" HeaderText="<%$Resources:Resource, festdatum %>"  DataFormatString="{0:d}" SortExpression="fest_datum"/>
                <asp:BoundField DataField="fest_duur" HeaderText="<%$Resources:Resource, festduur %>" SortExpression="fest_duur"/>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True"/>
            </Columns>
        </asp:GridView>
    
        <asp:DetailsView>
            
        </asp:DetailsView>  
        <br />
</asp:Content>