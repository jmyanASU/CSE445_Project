using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment6WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            //create a service reference 
            ServiceReference1.Service1Client addMember = new ServiceReference1.Service1Client();
            //call the add member method
            addMember.addMember(addUser.Text, addPass.Text);
            //removes the text after adding it to the xml doc
            addUser.Text = "";
            addPass.Text = "";
        }

        protected void hashBtn_Click(object sender, EventArgs e)
        {
            //create a service reference 
            ServiceReference1.Service1Client hash = new ServiceReference1.Service1Client();
            //set the hashOut label to the output of the hashPass method
            hashOut.Text=hash.hashPass(hashPass.Text);
        }
    }
}