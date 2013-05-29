<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="Festipedia.Admin.adminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <section class="contentLeft">
        <h2>Add user</h2>
        <asp:Label ID="successLabel" runat="server" Text=""></asp:Label>
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" LoginCreatedUser="False" OnCreatedUser="CreateUser_CreatedUser">
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" CssClass="field-validation-error"
                            ErrorMessage="Required." ValidationGroup="CreateUserWizard1"></asp:RequiredFieldValidator></asp:Label>
                        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                    
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" CssClass="field-validation-error"
                            ErrorMessage="Required." ValidationGroup="CreateUserWizard1"></asp:RequiredFieldValidator></asp:Label>
                        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                        
                        <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:
                        <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" CssClass="field-validation-error"
                            ErrorMessage="Required." ValidationGroup="CreateUserWizard1"></asp:RequiredFieldValidator></asp:Label>
                        <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                        
                        <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:
                        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" CssClass="field-validation-error"
                            ErrorMessage="Required." ValidationGroup="CreateUserWizard1"></asp:RequiredFieldValidator>
                        </asp:Label>
                        <asp:TextBox ID="Email" runat="server"></asp:TextBox>

                        <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" 
                            ErrorMessage="The Password and Confirmation Password must match." ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                    </ContentTemplate>
                </asp:CreateUserWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>
    </section>
    <section class="contentRight">
        <h2>Manage user</h2>
        <asp:DropDownList class="dropList" id="RoleList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="RoleList_SelectedIndexChanged"></asp:DropDownList><br />
        <asp:DropDownList class="dropList" id="UserRoleList" runat="server" AutoPostBack="true"></asp:DropDownList>
    </section>
</asp:Content>
