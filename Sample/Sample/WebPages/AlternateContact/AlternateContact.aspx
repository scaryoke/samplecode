<%@ Page Title="Add Alternate Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlternateContact.aspx.cs" Inherits="Sample.WebPages.AlternateContact.AlternateContact" %>
<%@ Register Src="~/UserControls/AlternateContactUC.ascx" TagPrefix="uc1" TagName="AlternateContactUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Alternate Contact</h2>
     <table width="700px">
        <tr>
            <asp:Label ID="lbSpouse" runat="server" Font-Size="Large" Font-Bold="true" Text="Alternate Contact" />
        </tr>
         </table>
    <uc1:AlternateContactUC runat="server" ID="AlternateContactUC" />
    <table>
        <tr>
            <asp:Label ID="fdsa" runat="server" Height="30px" />
        </tr>
         <tr>

            <td>
                <asp:Label ID="lbAnswer" runat="server" Font-Bold="true" /></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btAddAltContact" runat="server" Text="Add Alternate Contact" OnClick="btAddAltContact_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btYes" runat="server" Text="Yes" Visible="false" OnClick="btYes_Click" />

            </td>
            <td>
                <asp:Button ID="btNo" runat="server" Text="No" Visible="false" OnClick="btNo_Click" /></td>
            </tr>
        <tr>
            <td><asp:Button ID="btAddAnother" runat="server" Text="Add Another Contact" OnClick="btAddAnother_Click" Visible="false" /></td>

        </tr>
        <tr>
            <td>
                <asp:Button ID="btReturn" runat="server" Text="Return to Main Menu" OnClick="btReturn_Click" Visible="true"/>
            </td>
        
            <td>
                <asp:Button ID="btAddPolicy" runat="server" Text="Add Policy" OnClick="btAddPolicy_Click" Width="150px" />
            </td>
            <td>
                <asp:Button ID="btAddAlt" runat="server" Text="Add Medicare" OnClick="btAddAlt_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
