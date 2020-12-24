<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUDWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
        <p class="lead">This is a CRUD Operation Based Web Form Application, Using Class Library..</p>
        
    </div>
    <asp:Label ID="Label3" runat="server" Text="Insert Section"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox4" runat="server" placeholder="Enter Student's Name" OnTextChanged="TextBox4_TextChanged" Height="21px"></asp:TextBox>
&nbsp;&nbsp;
    <br />
    <br />
    <asp:Button ID="Button4" runat="server" Text="Insert" OnClick="Button4_Click" />
    <br />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Display" OnClick="Button1_Click" />
     <br />
     <br />
    <asp:GridView ID="GridView1" runat="server" Width="427px" Height="81px" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Delete Section"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Placeholder="Enter Student's Id" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
    &nbsp;<br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Update Section"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" placeholder="Student's Old Id" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <asp:TextBox ID="TextBox3" runat="server" placeholder="Student's New Name" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
    <br />
    <br />
    
</asp:Content>
