<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="Festipedia.Admin.adminPage" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <section class="contentLeft">
        <h2>Add user</h2>
        <asp:Label ID="successLabel" runat="server" Text=""></asp:Label>
        <asp:CreateUserWizard ID="addUserWizard" runat="server" LoginCreatedUser="False" OnCreatedUser="CreateUser_CreatedUser">
            <WizardSteps>
                <asp:CreateUserWizardStep ID="addUserWizardStep1" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:
                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" CssClass="field-validation-error"
                            ErrorMessage="Required." ValidationGroup="addUserWizard"></asp:RequiredFieldValidator></asp:Label>
                            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                    
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:
                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" CssClass="field-validation-error"
                            ErrorMessage="Required." ValidationGroup="addUserWizard"></asp:RequiredFieldValidator></asp:Label>
                            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                        
                        <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:
                            <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" CssClass="field-validation-error"
                            ErrorMessage="Required." ValidationGroup="addUserWizard"></asp:RequiredFieldValidator></asp:Label>
                            <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                        
                        <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:
                            <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" CssClass="field-validation-error"
                            ErrorMessage="Required." ValidationGroup="addUserWizard"></asp:RequiredFieldValidator></asp:Label>
                            <asp:TextBox ID="Email" runat="server"></asp:TextBox>

                        <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" 
                            ErrorMessage="The Password and Confirmation Password must match." ValidationGroup="addUserWizard"></asp:CompareValidator>
                    </ContentTemplate>
                </asp:CreateUserWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>

        <h2>Delete user</h2>
        <asp:DropDownList class="dropList" id="deleteUserList" runat="server" AutoPostBack="true"></asp:DropDownList><br />
        <asp:Button ID="deleteUser" runat="server" Text="Delete User" OnClick="deleteUser_Click" />

    </section>
    <section class="contentRight">

        <h2>Manage User</h2>
        <asp:DropDownList class="dropList" id="UserList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="UserList_SelectedIndexChanged"></asp:DropDownList>
        
        <h3>Details</h3>
        <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="EmailChange">E-mail:
            <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="EmailChange" CssClass="field-validation-error" ErrorMessage="Required." 
            ValidationGroup="manageUserWizard"></asp:RequiredFieldValidator></asp:Label>
            <asp:TextBox ID="EmailChange" runat="server"></asp:TextBox><br />

        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="PasswordChange">Password:
        <asp:RegularExpressionValidator ID="passwordMinLength" ControlToValidate="PasswordChange" runat="server" ValidationExpression="^[\s\S]{0,25}$" Text="Max 25 Characters!" Display="Dynamic"
            ValidationGroup="manageUserWizard"></asp:RegularExpressionValidator></asp:Label>
        <asp:TextBox ID="PasswordChange" runat="server" TextMode="Password"></asp:TextBox><br />

        <asp:Button ID="changeUser" runat="server" Text="Change User" OnClick="changeUser_Click" ValidationGroup="manageUserWizard" />

        <h3>Roles</h3>
        <asp:Repeater ID="UsersRoleList" runat="server">      
            <ItemTemplate>           
                <asp:CheckBox runat="server" ID="RoleCheckBox" AutoPostBack="true" Text='<%# Container.DataItem %>' OnCheckedChanged="RoleCheckBox_CheckChanged" />
            </ItemTemplate> 
        </asp:Repeater> 

    </section>
</asp:Content>
