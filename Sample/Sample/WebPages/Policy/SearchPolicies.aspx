<%@ Page Title="Search Policies" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchPolicies.aspx.cs" Inherits="Sample.WebPages.Policy.SearchPolicies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <table>
    <tr>
            <td>
            <div style="height:auto;overflow:auto;width:900px">
                <asp:GridView ID="PolicyView" runat="server" OnRowCommand="PolicyView_RowCommand" AllowPaging="true" Width="700px">
                    <Columns>
                        <asp:ButtonField HeaderText="Edit Policy" Text="Edit" ButtonType="Button" />
                    </Columns>
                </asp:GridView>
                </div>
                </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btAddPolicy" runat="server" Text="Add Policy" OnClick="btAddPolicy_Click" />
            </td>
        </tr>

    </table>
</asp:Content>
