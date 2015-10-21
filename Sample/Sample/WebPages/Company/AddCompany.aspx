<%@ Page Title="Add Company" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCompany.aspx.cs" Inherits="Sample.WebPages.Company.AddCompany" %>

<%@ Register Src="~/UserControls/CompanyUC.ascx" TagPrefix="uc1" TagName="CompanyUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Company</h2>
    <uc1:CompanyUC runat="server" ID="CompanyUC" />
    <table>
        <tr>
            <td>
                <asp:Label ID="lbMessage" runat="server" /></td>
        </tr>
        <tr>
            <td>
            <asp:Button ID="CompanyAdd" runat="server" OnClick="CompanyAdd_Click" Text="Add Company" /></td><td></td>
            <td><asp:Button ID="returnToMain" runat="server" OnClick="returnToMain_Click" Text="Return to Main Menu" /></td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        
    </table>
</asp:Content>
