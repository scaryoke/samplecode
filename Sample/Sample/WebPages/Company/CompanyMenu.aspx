<%@ Page Title="Company Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CompanyMenu.aspx.cs" Inherits="Sample.WebPages.Company.CompanyMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
       To add a company <a href="AddCompany.aspx" title="AddCustomer">Click Here</a>.
    </p>
    <p>
        To edit company information <a href="SearchCompanies.aspx" title="Policy">Click here</a>.
    </p>
</asp:Content>
