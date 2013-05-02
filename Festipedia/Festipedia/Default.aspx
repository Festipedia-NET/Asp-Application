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
                     ItemsSource="{Binding Path=Festival}">

            <LayoutTemplate>
                <li>
                <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                </li>
            </LayoutTemplate>

            <ItemTemplate>
                {Binding Path=ProductID}
            </ItemTemplate>
        
           <EmptyDataTemplate>
                    Error, Data could not be loaded
           </EmptyDataTemplate>
       </asp:ListView>

       

   </ul>
</asp:Content>
