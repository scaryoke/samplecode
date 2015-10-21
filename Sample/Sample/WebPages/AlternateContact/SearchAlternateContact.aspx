<%@ Page Title="Edit Alternate Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchAlternateContact.aspx.cs" Inherits="Sample.WebPages.AlternateContact.SearchAlternateContact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <table>
        <tr>
            <td>
            <div style="height:auto;overflow:auto;width:900px">
                <asp:GridView ID="AltContactView" runat="server" OnRowCommand="AltContactView_RowCommand" >
                    <Columns>
                        <asp:ButtonField HeaderText="Edit Alternate Contact" ButtonType="Button" Text="Edit" />
                    </Columns>
                </asp:GridView>
                </div>
                </td>
            </tr>
         <tr>
             <td>
                 &nbsp;
             </td>
         </tr>
         <tr><td><asp:Label ID="lbAltMessage" runat="server" /></td></tr>
         <tr><td><asp:Button ID="btAddAlt" runat="server" Text="Add Alternate Contact" OnClick="btAddAlt_Click" /></td></tr>
         </table>
</asp:Content>
