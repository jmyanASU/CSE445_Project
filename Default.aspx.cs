using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Project5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            // Check if the user is logged in
            if (!IsPostBack)
            {
                if (Session["LoggedIn"] == null || !(bool)Session["LoggedIn"])
                {
                    // User is not logged in, redirect to the Login page
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void MemberButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member.aspx");
        }

        protected void StaffButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffLogin.aspx");
        }

        

        protected void TryItButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TryIt.aspx");
        }
    }
}