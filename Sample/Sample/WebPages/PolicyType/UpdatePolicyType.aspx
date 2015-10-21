<%@ Page Title="Edit Policy Types" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePolicyType.aspx.cs" Inherits="Sample.WebPages.PolicyType.UpdatePolicyType" %>

<%@ Register Src="~/UserControls/PolicyTypeUC.ascx" TagPrefix="uc1" TagName="PolicyTypeUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit Policy Type</h2>

    <uc1:PolicyTypeUC runat="server" ID="PolicyTypeUC" />
    <table>
        <tr>
            <td>&nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="EditPolicyType" runat="server" OnClick="EditPolicyType_Click" Text="Update Policy Type"/>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbResult" runat="server" /></td>
        </tr>
    </table>
</asp:Content>
