<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ComplaintBox1.Guest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">
        Login Page
    </h1>
    <table align="center">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="User Name :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr></tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextPassword" runat="server" Visible="True" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr></tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Cancel" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>


</asp:Content>
