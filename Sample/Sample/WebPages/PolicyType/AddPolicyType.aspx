<%@ Page Title="Add Policy Type" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPolicyType.aspx.cs" Inherits="Sample.WebPages.PolicyType.AddPolicyType" %>
<%@ Register Src="~/UserControls/PolicyTypeUC.ascx" TagPrefix="uc1" TagName="PolicyTypeUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add Policy Type</h2>
    <uc1:PolicyTypeUC runat="server" ID="PolicyTypeUC" />
    <table>
        <tr><td><asp:Label runat="server" ID="lbResult"/></td></tr>
        <tr><td><asp:Button ID="btAddPolicyType" Text="Add Policy Type" runat="server" OnClick="btAddPolicyType_Click" /></td></tr>
        <tr><td>&nbsp;</td></tr>
        
    </table>
</asp:Content>
