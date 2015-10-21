<%@ Page Title="Edit Company" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCompany.aspx.cs" Inherits="Sample.WebPages.Company.EditCompany" %>
<%@ Register Src="~/UserControls/CompanyUC.ascx" TagPrefix="uc1" TagName="CompanyUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit Company</h2>
    <uc1:CompanyUC runat="server" ID="CompanyUC" />
    <table>
        <tr>
            <asp:Button ID="CompanyAdd" runat="server" OnClick="CompanyAdd_Click" Text="Update Company" />
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbMessage" runat="server" /></td>
        </tr>
        <tr><td>
            <asp:Button ID="btReturn" runat="server" Text="Return to Company Menu" OnClick="btReturn_Click" Visible="false" />
            </td></tr>
    </table>
</asp:Content>
