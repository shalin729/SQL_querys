<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PassChangePage.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="font-weight: 700; font-size: xx-large">
            Change Password<br />
            <br />
            <span class="auto-style2">Emai -
            <asp:TextBox ID="TextBox1" runat="server" Width="236px"></asp:TextBox>
            <br />
            <br />
            Old Pass -
            <asp:TextBox ID="TextBox2" runat="server" Width="236px"></asp:TextBox>
            <br />
            <br />
            New Pass -
            <asp:TextBox ID="TextBox3" runat="server" Width="236px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="35px" OnClick="Button1_Click" Text="Submit" Width="86px" />
            </span>
        </div>
    </form>
</body>
</html>
