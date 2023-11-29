<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="CSE445_Project5.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <asp:Label ID="Label7" runat="server" Text="Welcome back" Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:Label ID="Label9" runat="server" Text="!" Font-Bold="True" Font-Size="Large"></asp:Label>
            &nbsp;<br />
            <br />
            <asp:Button ID="Logout" runat="server" OnClick="Logout_Click" Text="Log out" Height="65px" Width="143px" />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;
            <br />
            <asp:TextBox ID="txtNameStaff" runat="server"></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="Username"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtPassStaff" runat="server"></asp:TextBox>
            <asp:Label ID="Label11" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:Button ID="addStaffbtn" runat="server" OnClick="addStaffbtn_Click" Text="Add Staff" />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            
    </form>
</body>
</html>
