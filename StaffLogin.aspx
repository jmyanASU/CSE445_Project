<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" Inherits="CSE445_Project5.StaffLogin" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

  <title></title>

</head>

<body>

  <form id="form1" runat="server">

    <div>

      Staff Login Page, It&#39;s now&nbsp;&nbsp;&nbsp;
        <asp:Label ID="datelbl" runat="server" Text="Label"></asp:Label>
        <br />

      <br />

      Username :

      <asp:TextBox ID="txtNameStaff" runat="server"></asp:TextBox>

      <br />

      <br />

      Password :

      <asp:TextBox ID="txtPassStaff" runat="server" TextMode="Password"></asp:TextBox>

      <br />

      <br />

      <br />

      <asp:Button ID="btnStaffLogin" runat="server" Text="LOGIN" OnClick="btnStaffLogin_Click1" />

      <br />

      <br />

      <asp:Label ID="lblErrorLogin" runat="server" Visible="False"></asp:Label>

      <br />

    </div>

  </form>

</body>

</html>
