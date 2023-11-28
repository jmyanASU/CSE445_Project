<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSE445_Project5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Welcome to Our Application</h1>
        <p>
            Our application provides the following functionality: explain in next phase
            <!-- Describe your application's functionality here -->
        </p>
        <p>
            To get started, you can log in for our services. Click the "Log In" button below</p>
        <p>
            If you are a TA/grader testing the application, use the following staff credentials:
            <br />
            Username: "TA" | Password: Cse44598!
        </p>
        <asp:Button ID="TryItButton" runat="server" Text="Try It Page" OnClick="TryItButton_Click" />
        <asp:Button ID="MemberButton" runat="server" Text="Member Page" OnClick="MemberButton_Click" />
        <asp:Button ID="StaffButton" runat="server" Text="Staff Page" OnClick="StaffButton_Click" />
    </div>
</asp:Content>


