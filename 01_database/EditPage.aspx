<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditPage.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Edit Profile<br />
            <br />
            Email -
            <asp:TextBox ID="TextBox2" runat="server" Width="274px" Enabled="False"></asp:TextBox>
            <br />
            <br />
            Name -
            <asp:TextBox ID="TextBox1" runat="server" Width="274px"></asp:TextBox>
            <br />
            <br />
            Ph No -
            <asp:TextBox ID="TextBox3" runat="server" Width="274px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
