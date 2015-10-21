<%@ Page Title="Add Employee" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="AddEmployee.aspx.cs" Inherits="Sample.WebPages.Employee.AddEmployee" %>
<%@ Register Src="~/UserControls/EmployeeUC.ascx" TagPrefix="uc1" TagName="EmployeeUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>New Employee</h2><br />
    
    <uc1:EmployeeUC runat="server" ID="EmployeeUC" />
    <table>
        <tr><td><asp:Label ID="response" runat="server" Visible="false" />
</td></tr>
    <tr><td><asp:Button ID="bttnAdd" runat="server" OnClick="AddNewEmployee" Text="Add New Employee"/></td></tr>
    
    </table>
</asp:Content>
