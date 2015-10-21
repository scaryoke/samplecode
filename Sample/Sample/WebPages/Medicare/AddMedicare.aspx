<%@ Page Title="Add Medicare" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddMedicare.aspx.cs" Inherits="Sample.WebPages.Medicare.AddMedicare" %>
<%@ Register Src="~/UserControls/MedicareUC.ascx" TagPrefix="uc1" TagName="MedicareUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Medicare Information</h2><br />
    <asp:Label ID="lbHeader" runat="server" Font-Bold="true" Font-Size="Large" /><br />
    <uc1:MedicareUC runat="server" ID="MedicareUC" />
    <table>
        <tr><td><asp:Label ID="lbError" runat="server" CssClass="failureNotification" /></td></tr>
        <tr>

            <td>
                <asp:Label ID="lbAnswer" runat="server" Font-Bold="true" /></td>
        </tr>
        <tr>
            <td></td><td>
    <asp:Button ID="btAddMedicare" runat="server" OnClick="btAddMedicare_Click" Text="Add Medicare Information" /></td></tr>
        <tr>
            <td>
                <asp:Button ID="btReturn" runat="server" Text="Return to Main Menu" OnClick="btReturn_Click" Visible="true"/>
            </td>
        
            <td>
                <asp:Button ID="Button1" runat="server" Text="Add Policy" OnClick="btAddPolicy_Click" Width="175px" />
            </td>
            <td>
                <asp:Button ID="btAddAlt" runat="server" Text="Add Alternate Contact" OnClick="btAddAlt_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
