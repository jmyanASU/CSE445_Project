<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSE445_Project5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Welcome to Group 31!</h1>
        <p>
            Discover a world of culinary delights with our recipe system!</p>
        <p>
            Explore a vast collection of popular recipes, effortlessly find the wine paring with the simple descriptions.</p>
        <p>
            Elevate your cooking experience with our system designed for food enthusiasts like you!</p>
        <p>
            &nbsp;</p>
        <p>
            To be able to test this application, the user can register for an account from the member page which will then allow them to login as a member.</p>
        <p>
            &nbsp;After they log in as a member, they are able to test all of the functionalites and services of the application.
        </p>
        <p>
            They can also test the staff page by logging in with the given TA login, username: &quot;TA&quot; and password: &quot;Cse44598!&quot;.</p>
        <p>
            &nbsp;They will then have access to the staff page where they can add new staff members.</p>
        <p>
            For end users to sign up for the services they will just need to access the members page and register for an account.
        </p>
        <p>
            After that they will be able to log in to the account and have access to all the functionalities and services.</p>
        <p>
            <br />
        </p>
        <asp:Button ID="MemberButton" runat="server" Text="Member Page" OnClick="MemberButton_Click" />
        <asp:Button ID="StaffButton" runat="server" Text="Staff Page" OnClick="StaffButton_Click" />
    </div>
</asp:Content>


