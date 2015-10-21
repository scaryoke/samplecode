<%@ Page Title="Edit Company" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchCompanies.aspx.cs" Inherits="Sample.WebPages.Company.SearchCompanies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Select Company</h2>
    <table>
        <tr>
            <td>
            <div style="height:auto;overflow:auto;width:900px">
                <asp:GridView ID="companyGrid" runat="server" OnRowCommand="companyGrid_RowCommand" AllowPaging="true" Width="500px">
                    <Columns>
                        <asp:ButtonField HeaderText="Edit Company" Text="Edit Company" ButtonType="Button" />
                    </Columns>
                </asp:GridView>
                </div>
                </td>
            </tr>
    </table>
</asp:Content>
