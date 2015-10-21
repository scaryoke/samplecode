<%@ Page Title="Customer Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerMenu.aspx.cs" Inherits="Sample.WebPages.Customer.CustomerMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <p>
       To add a customer <a href="AddCustomer.aspx" title="AddCustomer">Click Here</a>.
    </p>
    <p>
        To edit customer information <a href="EditCustomer.aspx" title="Policy">Click here</a>.
    </p>
</asp:Content>
