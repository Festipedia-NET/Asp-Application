<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="editPage.aspx.cs" Inherits="Festipedia.Edit.editPage" EnableEventValidation="false" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper inhoud-titel ">
            <h1><%: Title %></h1>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

        <asp:GridView ID="festView" runat="server" AutoGenerateColumns="False" CssClass="festView" showfooter="True"
            OnRowEditing="festView_RowEditing"         
            OnRowCancelingEdit="festView_RowCancelingEdit" 
            OnRowUpdating="festView_RowUpdating" OnRowDeleting="festView_RowDeleting" Width="850px">
            <Columns>
                <asp:TemplateField HeaderText="Id" SortExpression="fest_id">
                    <EditItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("fest_id") %>'></asp:Label>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:Button ID="btnInsert" runat="server" OnClick="Insert_Click" Text="Insert" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("fest_id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Festivalnaam" SortExpression="fest_naam">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("fest_naam") %>' Width="110px"></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Width="110px"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("fest_naam") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Locatie" SortExpression="fest_locatie">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("fest_locatie") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("fest_locatie") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Datum" SortExpression="fest_date">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("fest_datum") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("fest_datum") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Duur" SortExpression="fest_duur">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Eval("fest_duur") %>' Width="54px"></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Width="54px"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Eval("fest_duur") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <br />
</asp:Content>