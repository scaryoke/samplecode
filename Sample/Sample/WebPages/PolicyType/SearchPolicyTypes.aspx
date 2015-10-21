<%@ Page Title="Edit Policy Types" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchPolicyTypes.aspx.cs" Inherits="Sample.WebPages.PolicyType.SearchPolicyTypes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Select Policy Type</h2>
     <table>
        <tr>
            <td>
            <div style="height:auto;overflow:auto;width:900px">
                <asp:GridView ID="PolicyTypeView" runat="server" OnRowCommand="policyTypeView_RowCommand" AllowPaging="true" Width="700px">
                    <Columns>
                        <asp:ButtonField HeaderText="Edit Policy Type" Text="Edit Policy Type" ButtonType="Button" />
                    </Columns>
                </asp:GridView>
                </div>
                </td>
            </tr>
         </table>
</asp:Content>
