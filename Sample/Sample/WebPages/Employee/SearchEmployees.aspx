<%@ Page Title="Edit Employee" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchEmployees.aspx.cs" Inherits="Sample.WebPages.Employee.SearchEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Select Employee</h2>
    <table>
        <tr>
            <td>
                <asp:GridView ID="EmployeeView" runat="server" OnRowCommand="EmployeeView_RowCommand">
                    <Columns>
                        <asp:ButtonField ButtonType="Link" Text="Edit Employee" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
