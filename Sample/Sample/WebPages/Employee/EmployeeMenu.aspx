<%@ Page Title="Employee Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeMenu.aspx.cs" Inherits="Sample.WebPages.Employee.EmployeeMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
       To add an employee <a href="AddEmployee.aspx" title="AddCustomer">Click Here</a>.
    </p>
    <p>
        To edit an employee <a href="SearchEmployees.aspx" title="Policy">Click here</a>.
    </p>
</asp:Content>
