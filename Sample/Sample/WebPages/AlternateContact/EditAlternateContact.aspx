<%@ Page Title="Edit Alternate Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditAlternateContact.aspx.cs" Inherits="Sample.WebPages.AlternateContact.EditAlternateContact" %>
<%@ Register Src="~/UserControls/AlternateContactUC.ascx" TagPrefix="uc1" TagName="AlternateContactUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit Alternate Contact</h2>
     <table width="700px">
        <tr>
            <asp:Label ID="lbSpouse" runat="server" Font-Size="Large" Font-Bold="true" Text="Alternate Contact" />
        </tr>
         </table>
    <uc1:AlternateContactUC runat="server" ID="AlternateContactUC" />
    <table>
        <asp:Button ID="btUpdate" runat="server" OnClick="btUpdate_Click" Text="Update Alternate Contact" />
        <tr>
            <td><asp:Label ID="lbResult" runat="server"/></td>
        </tr>
    </table>
</asp:Content>
