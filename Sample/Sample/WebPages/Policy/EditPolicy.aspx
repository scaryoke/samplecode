    <%@ Page Title="Edit Policy" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditPolicy.aspx.cs" Inherits="Sample.WebPages.Policy.EditPolicy" %>
<%@ Register Src="~/UserControls/PolicyUC.ascx" TagPrefix="uc1" TagName="PolicyUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit Policy</h2>
    <asp:Label ID="lbHeader" runat="server" Font-Bold="true" Font-Size="Large" /><br />
    <uc1:PolicyUC runat="server" ID="PolicyUC" />
    <br />
     <table width="300px">
    <asp:Button ID="UpdatePolicy" runat="server" OnClick="UpdatePolicy_Click" Text="Update Policy" />
   
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
    </table>
</asp:Content>
