<%@ Page Title="Edit Customer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCustomer.aspx.cs" Inherits="Sample.WebPages.Customer.EditCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table width=" 700px">
        <tr>
            <td><b>Select:  </b>
                <asp:DropDownList ID="ddStuff" runat="server">
                    <asp:ListItem Text="Last Name" Value="LastName" />
                </asp:DropDownList>
                <asp:TextBox ID="tbSearchValue" runat="server" /></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btSearch" Text="Search" runat="server" OnClick="btSearch_Click" /></td>
        </tr>
        <tr>
            <asp:Label ID="lbData" runat="server" />
        </tr>
        <tr>
            <td>&nbsp;
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <div style="height: auto; overflow: auto; width: 90%">
                    <asp:GridView ID="customer" runat="server" OnRowCommand="customer_RowCommand" Width="90%">

                        <Columns>
                            <asp:ButtonField HeaderText="Edit Policies" ButtonType="Link" Text="Edit Policy" CommandName="EditPolicies" />
                            <asp:ButtonField HeaderText="Edit Customer" Text="Edit Customer" ButtonType="Link" CommandName="EditCustomer" />
                            <asp:ButtonField HeaderText="Edit Medicare" Text="Edit Medicare" ButtonType="Link" CommandName="EditMedicare" />
                            <asp:ButtonField HeaderText="Edit Alternate Contact" Text="Edit Alternate Contact" ButtonType="Link" CommandName="EditAlternateContact" />
                        </Columns>
                        <HeaderStyle Wrap="true" BackColor="#00aaaa" Width="700px"></HeaderStyle>
                    </asp:GridView>

                </div>

            </td>
        </tr>
    </table>
</asp:Content>
