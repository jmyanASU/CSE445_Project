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
            <asp:Button ID="Logout" runat="server" OnClick="Logout_Click" Text="Log out" Height="25px" Width="95px" />
            <br />
            <br />
            As a Staff you have access to an array of functionalities:<br />
            <br />
            <br />
        
            <asp:Label ID="functionality1lbl" runat="server" Text="Functionaliy 1" Font-Bold="True" Font-Size="Large"></asp:Label>
            <br />
            <asp:TextBox ID="stafflbl" runat="server"></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="Username"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="passwordlbl" runat="server"></asp:TextBox>
            <asp:Label ID="Label11" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:Button ID="addStaffbtn" runat="server" OnClick="addStaffbtn_Click" Text="Add Staff" />
            <br />
            <br />
        
            <asp:Label ID="functionality1lbl0" runat="server" Text="Functionaliy 2" Font-Bold="True" Font-Size="Large"></asp:Label>
            <br />
                    <section class="row" aria-labelledby="aspnetTitle">
            <p class="lead">SPOONACULAR RECIPE FOOD NUTRITION</p>
        </section>

        <div class="row">
            <br />
            <a href="http://webstrar31.fulton.asu.edu/page10/Service1.svc">http://webstrar31.fulton.asu.edu/page10/Service1.svc</a><br />
            <asp:TextBox ID="txtIdSummary" runat="server" Width="400px"></asp:TextBox>
            <asp:Button ID="GetRecipeSummarybtn" runat="server" OnClick="GetRecipeSummarybtn_Click" Text="Get Recipe Summary" Width="140px" />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="summarylbl" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="SearchByIngredientstxt" runat="server" Width="400px"></asp:TextBox>
            <asp:Button ID="SearchByIngredientbtn" runat="server" OnClick="SearchByIngredientbtn_Click" Text="Search Recipe by Ingredient" Width="175px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="searchByIngredientlbl" runat="server" Text=" "></asp:Label>
            <asp:TextBox ID="MenuAutoComplet" runat="server" Width="400px"></asp:TextBox>
            <asp:Button ID="MenuAutoCompletebtn" runat="server" OnClick="MenuAutoCompletebtn_Click" Text="Auto Complete your Menu" Width="161px" />
            <br />
            <asp:Label ID="MenuAutoCompletelbl" runat="server"></asp:Label>
            <br />
            <br />
        </div>
            <br />
            &nbsp;&nbsp;&nbsp;
          
    </form>
</body>
</html>
