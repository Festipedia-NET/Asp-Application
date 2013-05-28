<%@ Page Title="Band Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BandDetail.aspx.cs" Inherits="Festipedia.BandDetail" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
            <h1><%: Title %></h1>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    





    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="band_naam" DataValueField="band_id" Rows="15" Width="200px" CssClass="listbox"></asp:ListBox>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:groep15_festivalsContext %>" SelectCommand="SELECT [band_id], [band_naam] FROM [Bands]"></asp:SqlDataSource>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CssClass="festview md" DataKeyNames="band_id" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="band_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="band_id" />
            <asp:BoundField DataField="band_naam" HeaderText="Naam" SortExpression="band_naam" />
            <asp:BoundField DataField="band_soortMuziek" HeaderText="Soort Muziek" SortExpression="band_soortMuziek" />
            <asp:BoundField DataField="band_url" HeaderText="Website" SortExpression="band_url" />
        </Fields>
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:groep15_festivalsContext %>" SelectCommand="SELECT * FROM [Bands] WHERE ([band_id] = @band_id)">
        <SelectParameters>
            <asp:ControlParameter ControlID="ListBox1" Name="band_id" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    





</asp:Content>