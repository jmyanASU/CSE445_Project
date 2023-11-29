<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="CSE445_Project5.Member" %>


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
                &nbsp; </div>
            <div>
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
                &nbsp;</div>
            <asp:Button ID="btnLogin" runat="server" Text="Log In" OnClick="btnLogin_Click" />
            <asp:Label ID="lblWelcomeMessage" runat="server" Visible="false" ForeColor="Green" />
            <br />
            <br />
        </div>
         <div>
            <h1>Register</h1>
            <asp:Label ID="Label1" runat="server" ForeColor="Red" />
            <div>
                <label for="txtUsername">Username:</label>
                <asp:TextBox ID="RegTextBox1" runat="server" />
                &nbsp; </div>
            <div>
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="RegTextBox2" runat="server" TextMode="Password" />
                &nbsp;</div>
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            <asp:Label ID="Label2" runat="server" Visible="false" ForeColor="Green" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>