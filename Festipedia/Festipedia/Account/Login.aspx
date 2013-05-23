<%@ Page Title="<%$Resources:Resource, login %>" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Festipedia.Account.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
    </hgroup>
    <section id="loginForm">
        <h2><asp:Label ID="Label1" runat="server" Text="<%$Resources:Resource, logintext1%>"></asp:Label></h2>
        <asp:Login runat="server" ViewStateMode="Disabled" RenderOuterTable="false">
            <LayoutTemplate>
                <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />
                </p>
                <fieldset>
                    <legend><asp:Label ID="Label1" runat="server" Text="<%$Resources:Resource, logintext2%>"></asp:Label></legend>
                    <ol>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="UserName" Text="<%$Resources:Resource, username %>"></asp:Label>
                            <asp:TextBox runat="server" ID="UserName" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="<%$Resources:Resource, usernameError %>" />
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Password" Text="<%$Resources:Resource, password %>"></asp:Label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="<%$Resources:Resource, passwordError %>" />
                        </li>
                        <li>
                            <asp:CheckBox runat="server" ID="RememberMe" />
                            <asp:Label runat="server" AssociatedControlID="RememberMe" CssClass="checkbox" Text="<%$Resources:Resource, rememberMe %>"></asp:Label>
                        </li>
                    </ol>
                    <asp:Button runat="server" CommandName="Login" Text="<%$Resources:Resource, login %>" />
                </fieldset>
            </LayoutTemplate>
        </asp:Login>
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled" Text="<%$Resources:Resource, register %>"></asp:HyperLink>
            <asp:Label ID="Label2" runat="server" Text="<%$Resources:Resource, logintext3%>"></asp:Label>
        </p>
    </section>

    <section id="socialLoginForm">
        <h2><asp:Label ID="Label3" runat="server" Text="<%$Resources:Resource, logintext4%>"></asp:Label></h2>
        <uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />
    </section>
</asp:Content>
