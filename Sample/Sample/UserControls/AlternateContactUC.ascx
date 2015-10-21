<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AlternateContactUC.ascx.cs" Inherits="Sample.UserControls.AlternateContactUC" %>
<table>
    <tr>
        <td><b>First Name: </b></td>
        <td>
            <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox></td>
        <td><b>Last Name:  </b></td>
        <td>
            <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
        </td>
        <td><b>Relationship:</b></td>
        <td>
            <asp:TextBox ID="tbRelationship" runat="server" /></td>
        <td><b>Contact Number:</b></td>
        <td>
            <asp:TextBox ID="tbContactNum" runat="server" /></td>
    </tr>
</table>
