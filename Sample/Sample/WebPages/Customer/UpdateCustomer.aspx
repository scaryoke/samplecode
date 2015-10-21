<%@ Page Title="Edit Customer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateCustomer.aspx.cs" Inherits="Sample.WebPages.Customer.UpdateCustomer" %>

<%@ Register Src="~/UserControls/CustomerUC.ascx" TagPrefix="uc1" TagName="CustomerUC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit Customer</h2>
    <uc1:CustomerUC runat="server" ID="CustomerUC" />
    <table width="300px">

        <tr>
            <td>
                <asp:Label ID="lbError" runat="server" CssClass="failureNotification" /></td>
        </tr>
        <tr>

            <td>
                <asp:Label ID="lbAnswer" runat="server" Font-Bold="true" /></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btYes" runat="server" Text="Yes" Visible="false" OnClick="btYes_Click" />

            </td>
            <td>
                <asp:Button ID="btNo" runat="server" Text="No" Visible="false" OnClick="btNo_Click" /></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Update Customer" OnClick="Button1_Click" /></td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="btAlt" runat="server" Text="Add Alternate Contact" OnClick="btAlt_Click" Visible="false" /></td>
            <td>
                <asp:Button ID="btAltNo" runat="server" Text="View Policies" OnClick="btAltNo_Click" Visible="false" /></td>
            <td>
                <asp:Button ID="btMedicare" runat="server" Visible="false" Text="Add Medicare" OnClick="btMedicare_Click" /></td>
        </tr>
    </table>
</asp:Content>
