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
            
        }

        protected void MemberButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member.aspx");
        }

        protected void StaffButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffLogin.aspx");
        }

        
    }
}