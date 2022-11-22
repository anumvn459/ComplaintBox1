<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Complaint_verify.aspx.cs" Inherits="ComplaintBox1.Admin.Complaint_verify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <center>
    <p>
        
        From
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;To<asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="View Complaint" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="C_Id" OnRowDeleting="GridView1_RowDeleting1">
            <Columns>
                <asp:BoundField DataField="C_Id" HeaderText="Complaint id" />
                <asp:BoundField DataField="User_Id" HeaderText="User id" />
                <asp:BoundField DataField="Product_Id" HeaderText="Product Id" />
                <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:CommandField HeaderText="Status" ShowDeleteButton="true" DeleteText="Confirm" />
                 
                <asp:BoundField DataField="Date" HeaderText="Date" />
            </Columns>
        </asp:GridView>
    </p>
    </center>


</asp:Content>
