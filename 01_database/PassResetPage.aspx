<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PassResetPage.aspx.cs" Inherits="PassResetPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong><span class="auto-style1">&nbsp;Reset password</span></strong><br />
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
    </form>
</body>
</html>
