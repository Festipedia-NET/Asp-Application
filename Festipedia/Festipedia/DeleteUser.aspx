<%@ Page Title="Delete user" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="Festipedia.DeleteUser" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Welkom op de <%: Title %> page.<br />
            <br />
</h1>
    </hgroup>



        <asp:GridView ID="deleteView" runat="server" AutoGenerateColumns="false" AllowPaging="true"  AllowSorting="true" >
            <Columns>
                <asp:BoundField DataField="gebr_id" HeaderText="ID" />
                <asp:BoundField DataField="gebr_naam" HeaderText="Naam" />
                <asp:BoundField DataField="gebr_adres" HeaderText="Adres" />
                <asp:BoundField DataField="gebr_gebDat" HeaderText="Datum"  DataFormatString="{0:d}"/>
                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
            </Columns>

            </asp:GridView>
</asp:Content>