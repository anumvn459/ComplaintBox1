<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserPage.Master" AutoEventWireup="true" CodeBehind="productview.aspx.cs" Inherits="ComplaintBox1.User.productview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h1 align="center">List Of Product</h1>
    <table align="center">
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataKeyNames="Product_Id" >
                            <Columns>
                                
                                <asp:BoundField DataField="Product_Id" HeaderText="Product Id" />
                                <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />  
                                <asp:BoundField DataField="Price" HeaderText="Product Price" /> 
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                
                    
            </table>

</asp:Content>
