<%@ Page Title="Edit Employee" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEmployee.aspx.cs" Inherits="Sample.WebPages.Employee.EditEmployee" %>
<%@ Register Src="~/UserControls/EmployeeUC.ascx" TagPrefix="uc1" TagName="EmployeeUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit Employee</h2><br />
    
    <uc1:EmployeeUC runat="server" ID="EmployeeUC" />
    <table>
        <tr>
            <td>
                <asp:Label ID="lbResponse" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btEditEmployee" runat="server" Text="Edit Employee" OnClick="btEditEmployee_Click" />
            </td>
        </tr>
        
    </table>
</asp:Content>
