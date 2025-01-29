<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PassResetPage.aspx.cs" Inherits="PassResetPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter email to reset password<br />
            <br />
            <strong>Email</strong>&nbsp; -
            <asp:TextBox ID="TextBox1" runat="server" Width="256px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Sand OTP" OnClick="Button1_Click" />
            <br />
            <br />
            New password
            <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
&nbsp;
            <br />
            <br />
            OTP
            <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="submit OTP" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </form>
</body>
</html>
