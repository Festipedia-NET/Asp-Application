<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Festipedia.Admin" %>



<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Welkom op de<%: Title %> page.<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Voeg lid toe" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Verwijder lid" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Pas lid aan" />
            <br />
        </h1>
    </hgroup>

    
</asp:Content>