<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.Master" AutoEventWireup="true" CodeBehind="userreg.aspx.cs" Inherits="ComplaintBox1.Guest.userreg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <h1 align="center">User Registration</h1><br />
    <table align="center">
        <tr>
           <td>Name :</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
           <td>Email :</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
           <td>Phone Number :</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
           <td>PassWord :</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
           <td colspan="2" align="center">
               <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /></td>
            
        </tr>
    </table>
</asp:Content>


