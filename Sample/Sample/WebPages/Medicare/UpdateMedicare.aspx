<%@ Page Title="Update Medicare" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateMedicare.aspx.cs" Inherits="Sample.WebPages.Medicare.UpdateMedicare" %>
<%@ Register Src="~/UserControls/MedicareUC.ascx" TagPrefix="uc1" TagName="MedicareUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit Medicare</h2>
    <asp:Label ID="lbHeader" runat="server" Font-Bold="true" Font-Size="Large" /><br />
    <uc1:MedicareUC runat="server" ID="MedicareUC" />
    <table>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbResult" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btEditMedicare" runat="server" Text="Edit Medicare" OnClick="btEditMedicare_Click" />
            </td>
        </tr>

    </table>
</asp:Content>
