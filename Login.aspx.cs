using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Project5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the user is already logged in
            if (Session["LoggedIn"] != null && (bool)Session["LoggedIn"])
            {
                // User is already logged in, redirect to the Default page
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Perform login logic
            // Validate username and password, set Session["LoggedIn"] to true if successful

            // For example:
            if (txtUsername.Text == "jmyan" && txtPassword.Text == "123456")
            {
                Session["LoggedIn"] = true;
                // Display welcome message
                lblWelcomeMessage.Text = $"Welcome, {txtUsername.Text}! You have successfully logged in.";
                lblWelcomeMessage.Visible = true;
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid username or password";
            }
        }
    }
}