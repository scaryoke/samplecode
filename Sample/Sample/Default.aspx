<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Sample._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p><b>Welcome to the Six S Senior Health Care Solutions Customer Management System!</b></p>
    <p>
       To add a customer <a href="http://localhost/Dev/Sample/Sample/AddCustomer.aspx" title="AddCustomer">Click Here</a>.
    </p>
    <p>
        To add a policy <a href="http://localhost/Dev/Sample/Sample/AddPolicy.aspx"
            title="Policy">Click here</a>.
    </p>
    <asp:Label ID="Jimbo" runat="server" />
</asp:Content>
