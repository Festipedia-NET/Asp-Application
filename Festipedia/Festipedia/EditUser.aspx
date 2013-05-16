<%@ Page Title="Edit user" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EditUser.aspx.cs" Inherits="Festipedia.EditUser" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Welkom op de <%: Title %> page.<br />
            <br />
                
            <asp:GridView ID="grdEdit" runat="server" SkinID="Professional" Font-Name="Verdana"
                Font-Size="10pt" Cellpadding="4"
                HeaderStyle-BackColor="#444444"
                HeaderStyle-ForeColor="White"
                AlternatingRowStyle-BackColor="#dddddd"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="gebr_id" HeaderText="ID" />
                    <asp:BoundField DataField="gebr_naam" HeaderText="Naam" />
                    <asp:BoundField DataField="gebr_adres" HeaderText="Adres" />
                    <asp:BoundField DataField="gebr_gebDat" HeaderText="Datum"  DataFormatString="{0:d}"/>
                    <asp:BoundField DataField="gebr_email" HeaderText="Email" />
                    <asp:BoundField DataField="gebr_wachtwoord" HeaderText="Wachtwoord" />
                    <asp:BoundField DataField="gebr_bevoegdheid" HeaderText="Bevoegdheid" />
                </Columns>
            </asp:GridView>
                
            <br />
        </h1>
    </hgroup>

    
</asp:Content>