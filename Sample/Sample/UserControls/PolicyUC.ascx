<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PolicyUC.ascx.cs" Inherits="Sample.PolicyUC" %>
<table>
    <tr>
        <asp:Label ID="lbTitle" runat="server" Font-Bold="true" Font-Size="Large" />
    </tr>
</table>
<table style="align-content:center;width:700px;border-spacing:20px 10px;tab-size:10;padding:5px">
    <tr>
        <asp:Label ID="lbPolicy" runat="server" Font-Bold="true" Font-Size="Large" Text="Policy Information" />
    </tr>
    <tr>
        <td><b>Age at Issue:    </b></td>
        <td>
            <asp:TextBox ID="tbAge" runat="server" /></td>
         <td><b>Policy Number:   </b></td>
        <td>
            <asp:TextBox ID="tbPolicyNumber" runat="server"></asp:TextBox></td>
    </tr>   
    <tr>
        <td><b>Company: </b></td>
        <td>
            <asp:DropDownList ID="ddList" runat="server">
            </asp:DropDownList>

        </td>
       
        <td><b>Policy Form: </b></td>
        <td>
            
            <asp:DropDownList ID="policyTypeList" runat="server"></asp:DropDownList>

        </td>
    </tr>
    <tr>
        <td><b>Date Written: </b></td>
        <td>
            <asp:TextBox ID="tbDateWritten" runat="server" /></td>
   
        <td><b>Date Effective:
        </b></td>
        <td>
            <asp:TextBox ID="tbDateEffective" runat="server" /></td>
    </tr>
    <tr>
        <td><b>Policy Status: </b></td>
        <td>
            <asp:TextBox ID="tbPolicyStatus" runat="server" /></td>
         <td><b>Renewal: </b></td>
        <td>
            <asp:TextBox ID="tbRenewal" runat="server" /></td>
           
       
    </tr>
    <tr>
        <td><b>Commission Percentage:   </b></td>
        <td>
            <asp:TextBox ID="tbCommission" runat="server" /></td>
       
    </tr>
    <tr>
       
        
    </tr>
    <tr> <td><b>Billing Period: </b></td>
        <td><asp:DropDownList ID="ddBilling" runat="server">
            <asp:ListItem Text="Monthly" Value="MBD" />
            <asp:ListItem Text="Quarterly" Value="QRT" />
            <asp:ListItem Text="Annually" Value="ANN" />
            </asp:DropDownList></td></tr>
    <tr> <td><b>Premium Amount:</b></td>
        <td><asp:TextBox ID="tbPremium" runat="server" />   </td></tr>
    <tr> <td><b>Policy Holder:</b></td>
        <td><asp:DropDownList ID="Primary" runat="server">
            <asp:ListItem Text="Primary" Value="Primary" />
            <asp:ListItem Text="Secondary" Value="Secondary" />
            </asp:DropDownList></td></tr>
</table>
