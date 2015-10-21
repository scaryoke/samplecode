<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CompanyUC.ascx.cs" Inherits="Sample.UserControls.CompanyUC" %>
<table>
    <tr><td><asp:Label Text="Company Information" Font-Size="Large" Font-Bold="true" runat="server" /></td></tr>
    <tr><td><b>Company Name: </b></td>
        <td><asp:TextBox ID="tbCompany" runat="server"></asp:TextBox></td>
    </tr>
    <tr><td><b>Contact Number: </b></td>
        <td><asp:TextBox ID="tbContactNum" runat="server"></asp:TextBox></td>
    </tr>
</table>