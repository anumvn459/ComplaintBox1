﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UserVerification.aspx.cs" Inherits="ComplaintBox1.Admin.UserVerification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">List Of User</h1>
    <table align="center">
                <tr>
                    <td>&nbsp</td>
                    <td>&nbsp</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="login_id" OnRowDeleting="GridView1_RowDeleting" >
                            <Columns>
                                <asp:TemplateField>
                                     <ItemTemplate>
                                        <input type="checkbox" runat="server" name="ch" value='<%Eval("Id") %>' />

                                     </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="login_id" HeaderText="UserId" />
                                <asp:BoundField DataField="UserName" HeaderText="UserName" />  
                                <asp:CommandField HeaderText="Status" ShowDeleteButton="true" DeleteText="Confirm" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                
                    
            </table>
</asp:Content>


