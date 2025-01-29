<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label2" runat="server" style="font-weight: 700; font-size: x-large" Text="Registration form"></asp:Label>
            <br />
            <br />
            <br />
            Name -
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Email -
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Password -
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Ph No -
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        Search -
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search" />
&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" />
&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Edit" />
&nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Update" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <p>
            &nbsp;</p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; font-size: xx-large; text-align: center" Text="LogIn"></asp:Label>
        <br />
        <br />
        Email -&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 0px"></asp:TextBox>
        <br />
        <br />
        Password -
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="LogIn" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Reset password" />
        <br />
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
