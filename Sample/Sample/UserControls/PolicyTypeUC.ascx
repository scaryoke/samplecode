<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PolicyTypeUC.ascx.cs" Inherits="Sample.UserControls.PolicyTypeUC" %>
<table >
    <tr><td><asp:Label runat="server" Text="Policy Type Information" Font-Size="Large" Font-Bold="true" /></td></tr>
        <tr>
            <td><b>Policy Type:</b></td>
            <td><asp:TextBox ID="tbPolicyType" runat="server" /></td>
        </tr>
        <tr>
            <td><b>Policy Description:   </b></td>
            <td>
                <asp:TextBox ID="tbPolicyDesc" runat="server" Width="300px" Height="100px" TextMode="MultiLine"  /></td>
        </tr>
    </table>