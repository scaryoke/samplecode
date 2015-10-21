<%@ Page Title="View Report" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewReports.aspx.cs" Inherits="Sample.WebPages.Reports.ViewReports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Policy Types Sold by Agent</h2>
    <table>
        <tr>
            <td>
                <asp:DropDownList runat="server" ID="ddEmployeeList">
                    <asp:ListItem Text="" Value="" />
                </asp:DropDownList></td>
            <td>
                <asp:Button ID="btViewReports" OnClick="btViewReports_Click" runat="server" Text="View Report" /></td>
        </tr>
    </table>
    <asp:TextBox ID="tbReport" runat="server" Width="700px" Height="500px" TextMode="MultiLine" Font-Size="Large" />
</asp:Content>
