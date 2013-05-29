<%@ Page Title="Festival Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FestiDetail.aspx.cs" Inherits="Festipedia.FestiDetail" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
            <h1><%: Title %></h1>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    



    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" CssClass="listbox" DataSourceID="SqlDataSource1" DataTextField="fest_naam" DataValueField="fest_id" Rows="15" Width="200px"></asp:ListBox>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:groep15_festivalsContext %>" SelectCommand="SELECT [fest_id], [fest_naam] FROM [Festivals] ORDER BY [fest_naam]"></asp:SqlDataSource>
                    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CssClass="festview md" DataKeyNames="fest_id" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
                        <Fields>
                            <asp:BoundField DataField="fest_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="fest_id" />
                            <asp:BoundField DataField="fest_naam" HeaderText="Naam" SortExpression="fest_naam" />
                            <asp:BoundField DataField="fest_locatie" HeaderText="Locatie" SortExpression="fest_locatie" />
                            <asp:BoundField DataField="fest_datum" HeaderText="Datum" SortExpression="fest_datum" />
                            <asp:BoundField DataField="fest_duur" HeaderText="Duur" SortExpression="fest_duur" />
                        </Fields>
                    </asp:DetailsView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:groep15_festivalsContext %>" SelectCommand="SELECT * FROM [Festivals] WHERE ([fest_id] = @fest_id)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="ListBox1" Name="fest_id" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </ContentTemplate>
            </asp:UpdatePanel>
        </ContentTemplate>
    </asp:UpdatePanel>
    



</asp:Content>