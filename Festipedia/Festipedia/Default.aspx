﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Festipedia._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
          <h1>FestiPedia Home </h1>
            <h3>Fast and easy info on festivals and bands!</h3>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2 class="content-title">Upcoming Festivals:</h2>
   
    <!-- Begin Listview -->
        <asp:ListView ID="upcomingFestivals" runat="server" ItemType="Festipedia.Models.Festival" SelectMethod="getListData" AutoGenerateColumns="false">
            <LayoutTemplate>
                  <table class="festview" runat="server" id="tblFest">
                    <tr id="Tr2" runat="server">
                         <th id="Th1" runat="server">Festival Name</th>
                         <th id="Th2" runat="server">Location</th>
                         <th id="Th3" runat="server">Date</th>
                         <th id="Th4" runat="server">Duration</th>
                    </tr>
                    <tr runat="server" id="itemPlaceholder" />
                 </table>
            </LayoutTemplate>

            <ItemTemplate>
                 <tr id="Tr1" runat="server">                       
                            <td>
                              <a href ="#" ><%#: Item.fest_naam %> </a>
                            </td>
                            <td >
                             <%#: Item.fest_locatie %>
                            </td>
                            <td >
                             <%#: Item.fest_datum %>
                            </td>
                            <td >
                             <%#: Item.fest_duur %> Days
                            </td>
                 </tr>
            </ItemTemplate>
           
            <EmptyDataTemplate>
                    Error, Data could not be loaded
            </EmptyDataTemplate>
        </asp:ListView>  
      <!-- Einde Listview --> 
      
    
</asp:Content>
