<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Email: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Password: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />&nbsp; <asp:Button ID="Button2" runat="server" Text="Show Data" OnClick="Button2_Click" />
        </div>
         <table border="1">
     <thead>
         <tr>
             <th>Sr.No</th>

             <th>RegNo</th>
             <th>Name</th>
             <th>Email</th>
             <th>Password</th>
            

         </tr>
     </thead>
     <tbody>
         <asp:Repeater ID="Repeater1" runat="server">

             <ItemTemplate>
                 <tr>
                     <td><%#Container.ItemIndex+1 %></td>
                     <td><%#Eval("regid") %></td>
                     <td><%#Eval("name") %></td>
                     <td><%#Eval("email") %></td>
                     <td><%#Eval("password") %></td>
                 

                 </tr>


             </ItemTemplate>

         </asp:Repeater>


     </tbody>



 </table>
    </form>
</body>
</html>
