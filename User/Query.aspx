﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserPage.Master" AutoEventWireup="true" CodeBehind="Query.aspx.cs" Inherits="ComplaintBox1.User.Query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   <h1><center>  Product Query Here</center></h1>
    <center>
        <br />
        <br />
 <asp:Label  ID="label1" runat="server" Text="Product Name"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" >

        </asp:DropDownList>
     
        </br>

        


        <asp:Label ID="Label3" runat="server" Text="Query with product"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" Text="Sumbit" OnClick="Button1_Click" />
        

</asp:Content>