<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomerUC.ascx.cs" Inherits="Sample.WebUserControl1" %>
<table style="width:100%" class="dashboard">
    <tr>
        
           <asp:Label ID="lbCustInfo" runat="server" Font-Size="Large" Font-Bold="true" Font-Underline="true" Text="Customer Information" />
        <tr>
            <td><b>First Name:</b></td>
            <td>
                <asp:TextBox ID="tbFirstName" runat="server" BorderColor="Gray"></asp:TextBox></td>
            <td><b>Middle Initial:</b></td>
            <td>
                <asp:TextBox ID="tbMI" runat="server" Width="25%" BorderColor="Gray"/></td>
            <td><b>Last Name:</b></td>
            <td>
                <asp:TextBox ID="tbLastName" runat="server" BorderColor="Gray"></asp:TextBox>

            </td>


        </tr>
        <tr>
            <td><b>Social Security Number:</b></td>
            <td>
                <asp:TextBox ID="tbSSN" runat="server" BorderColor="Gray"/></td>


            <td><b>Date of Birth: </b></td>
            <td>
                <asp:TextBox ID="tbDOB" runat="server" BorderColor="Gray" />
            </td>
        </tr>
    <tr>
      <td>
          &nbsp;
      </td>
  </tr>
    <%--<tr>
        <td>
    
            
<table style="align-content:center;padding:.5%;border-color:black;border:dashed;width:100%">
  <tr>
      <td>
          &nbsp;
      </td>
  </tr>--%>
        <tr>
            <td>
            <asp:Label ID="lbAddress" runat="server" Font-Size="Large" Font-Bold="true" Font-Underline="true" Text="Customer Address" BorderColor="Gray"/></td>
        </tr>
<tr>
            <td><b>Address:</b>
            
                </td><td>
               
                <asp:TextBox ID="tbStreet" runat="server" Width="200%" BorderColor="Gray" /></td>
        </tr>
       <%-- </table>
              </td></tr>--%>  
            <tr><td><b>Town:</b></td>
            <td>
                <asp:TextBox ID="tbCity" runat="server" BorderColor="Gray"/></td>
            <td><b>State:</b></td>
            <td>
                <asp:TextBox ID="tbState" runat="server" Width="25%" MaxLength="2" BorderColor="Gray"/>
            </td>

            <td><b>Zip Code:</b></td>
            <td>
                <asp:TextBox ID="tbZipCode" runat="server" BorderColor="Gray" />
            </td>
        </tr>

        <tr>
            <td><b>County:</b></td>

            <td>
                <asp:TextBox ID="tbCounty" runat="server" BorderColor="Gray" /></td>
            <td><b>Phone Number:</b></td>
            <td>
                <asp:TextBox ID="tbPhoneNum" runat="server" BorderColor="Gray" /></td>

        </tr>
 <tr>
      <td>
          &nbsp;
      </td>
  </tr>
        <tr><td>
            <asp:Label ID="lbSpouse" runat="server" Font-Size="Large" Font-Bold="true" Font-Underline="true" Text="Spouse" /></td>
        </tr>
        <tr>
            <td><b>First Name:</b></td>
            <td>
                <asp:TextBox ID="tbSpouseFirst" runat="server" BorderColor="Gray"></asp:TextBox>
            </td>
    
            <td><b>Last Name:   </b></td>
            <td>
                <asp:TextBox ID="tbSpouseLast" runat="server" BorderColor="Gray"></asp:TextBox>
            </td>
        </tr>
   

<%--</table>         
    <table style="align-content:center;border-spacing:20px 10px;padding:1%;border-color:black;border:dashed;width:100%" >--%>
       <tr>
      <td>
          &nbsp;
      </td>
  </tr> <tr>
            <td>
            <asp:Label ID="lbNotes" runat="server" Font-Size="Large" Font-Bold="true" Font-Underline="true" Text="Customer Notes" /></td>
        </tr>
        <tr>
            <td><b>Notes:</b></td>
            <td>
                <asp:TextBox ID="tbNotes" runat="server" Width="200%" Height="150%" TextMode="MultiLine" BorderColor="Gray" /></td>
        </tr>
    </table>
        