<%@ Page Title="Add Policy" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPolicy.aspx.cs" Inherits="Sample.WebPages.Policy.AddPolicy" %>
<%@ Register Src="~/UserControls/PolicyUC.ascx" TagPrefix="uc1" TagName="PolicyUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Policy</h2>
    <uc1:PolicyUC runat="server" ID="PolicyUC"/>
    <table width="300px">
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
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Confirm Information" OnClick="Button1_Click" /></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btReturn" runat="server" Text="Return to Main Menu" OnClick="btReturn_Click" Visible="true"/>
            </td>
        
            <td>
                <asp:Button ID="btAddMedicare" runat="server" Text="Add Medicare" OnClick="btAddMedicare_Click" width="140px"/>
            </td>
            <td>
                <asp:Button ID="btAddAlt" runat="server" Text="Add Alternate Contact" OnClick="btAddAlt_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
