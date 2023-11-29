using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace CSE445_Project5
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Today.ToLongDateString();
        }

        private void ProcessLogin(string username, bool createPersistentCookie)
        {
            var now = DateTime.UtcNow.ToLocalTime();
            TimeSpan expirationTimeSpan = FormsAuthentication.Timeout;

            var ticket = new FormsAuthenticationTicket(
                1,
                username,
                now,
                now.Add(expirationTimeSpan),
                createPersistentCookie,
                "Staff",
                FormsAuthentication.FormsCookiePath);

            var encryptedTicket = FormsAuthentication.Encrypt(ticket);

            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket)
            {
                HttpOnly = true,
                Secure = FormsAuthentication.RequireSSL,
                Path = FormsAuthentication.FormsCookiePath
            };

            if (ticket.IsPersistent)
            {
                cookie.Expires = ticket.Expiration;
            }
            if (FormsAuthentication.CookieDomain != null)
            {
                cookie.Domain = FormsAuthentication.CookieDomain;
            }

            Response.Cookies.Add(cookie);
        }

        protected void btnStaffLogin_Click1(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;

            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Staff.xml";
            string user = txtNameStaff.Text;
            string password = txtPassStaff.Text;

            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(password))
            {
                lblErrorLogin.Text = "Please enter username and password!";
                lblErrorLogin.Visible = true;
                return;
            }

            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);

            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement)
            {
                if (node["name"].InnerText == user)
                {
                    if (node["password"].InnerText == password)
                    {
                        if (Request.QueryString["ReturnUrl"] != null)
                        {
                            FormsAuthentication.RedirectFromLoginPage(txtNameStaff.Text, false);
                        }
                        else
                        {
                            ProcessLogin(user, false);
                            Response.Redirect("Staff.aspx");
                        }
                    }
                    else
                    {
                        lblErrorLogin.Text = "Please enter correct password";
                        lblErrorLogin.Visible = true;
                        return;
                    }
                }
            }

            lblErrorLogin.Text = "Please enter the correct credentials.";
            lblErrorLogin.Visible = true;
        }
    }

}
