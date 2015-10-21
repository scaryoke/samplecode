<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MedicareUC.ascx.cs" Inherits="Sample.UserControls.MedicareUC" %>
<table>
    <tr>
        <td><b>Medicare Card Number: </b></td>
        <td><asp:TextBox ID="tbMediCard" runat="server" /></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td><b>Medicare A Date Enrolled: </b></td>
        <td><asp:TextBox ID="tbDateA" runat="server" /></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <b>Medicare B Date Enrolled: </b>
        </td>
        <td>
            <asp:TextBox ID="tbDateB" runat="server" />
        </td>
    </tr>
</table>