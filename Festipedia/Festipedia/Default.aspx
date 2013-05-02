<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Festipedia._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
          <h1>FestiPedia Home </h1>
            <h3>Fast and easy info on festivals and bands!</h3>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Upcoming Festivals:</h3>
   
   <ul>

       <asp:ListView ID="upcomingFestivals"
                     runat="server"
                     DataSourceID="upFestivals">

            <LayoutTemplate>
                <li>
                <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                </li>
            </LayoutTemplate>

            <ItemTemplate>
                 <%# Eval("fest_naam") %>
            </ItemTemplate>
        
           <EmptyDataTemplate>
                    Error, Data could not be loaded
           </EmptyDataTemplate>
       </asp:ListView>

       <asp:SqlDataSource ID="upFestivals"
                          runat="server"
                          ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
                          SelectCommand="SELECT * FROM [Festivals]"
                          >

       </asp:SqlDataSource>

   </ul>
</asp:Content>
