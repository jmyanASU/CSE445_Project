<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CSE445_Project5.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
            <div>
                <label for="txtUsername">Username:</label>
                <asp:TextBox ID="txtUsername" runat="server" />
            &nbsp;&nbsp;&nbsp; jmyan</div>
            <div>
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            &nbsp;&nbsp;&nbsp; 123456</div>
            <asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="btnLogin_Click" />
            <asp:Label ID="lblWelcomeMessage" runat="server" Visible="false" ForeColor="Green" />
        </div>
    </form>
</body>
</html>