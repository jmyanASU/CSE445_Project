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
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //login
            lblMessage.Visible = false;

            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Member.xml";
            string user = txtUsername.Text;
            string password = txtPassword.Text;

            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter username and password!";
                lblMessage.Visible = true;
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
                            FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, false);
                        }
                        else
                        {
                            ProcessLogin(user, false);
                            Response.Redirect("TryIt.aspx");
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Please enter correct password";
                        lblMessage.Visible = true;
                        return;
                    }
                }
            }

            lblMessage.Text = "Please enter the correct credentials.";
            lblMessage.Visible = true;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            //register
            XmlDocument xd = new XmlDocument();
            string path;

            try
            {
                // Determine the path to the XML file
                path = HttpRuntime.AppDomainAppPath + @"\App_Data\Member.xml";

                // Load the XML document
                xd.Load(path);
            }
            catch (Exception)
            {
                // If the XML file doesn't exist, create a new one
                CreateUserXML(RegTextBox1.Text, RegTextBox2.Text);
                return;
            }

            // Get the root element
            XmlNode root = xd.SelectSingleNode("members");

            // Create a new member element
            XmlElement newMember = xd.CreateElement("member");

            // Create name and password elements and set their values
            XmlElement newName = xd.CreateElement("name");
            newName.InnerText = RegTextBox1.Text;

            XmlElement newPwd = xd.CreateElement("password");
            newPwd.InnerText = RegTextBox2.Text;

            // Add the name and password elements to the member element
            newMember.AppendChild(newName);
            newMember.AppendChild(newPwd);

            // Add the member element to the root element
            root.AppendChild(newMember);

            // Save the updated XML document
            xd.Save(path);
        }

        private void CreateUserXML(string memName, string memPwd)
        {
            XmlTextWriter writer = null;

            try
            {
                // Determine the path to the XML file
                string path = HttpRuntime.AppDomainAppPath + @"\App_Data\Member.xml";


                // Create an XML writer with proper formatting
                writer = new XmlTextWriter(path, System.Text.Encoding.Unicode)
                {
                    Formatting = Formatting.Indented
                };

                // Write the XML document content
                writer.WriteStartDocument();
                writer.WriteStartElement("users");
                writer.WriteStartElement("user");
                writer.WriteElementString("username", RegTextBox1.Text);
                writer.WriteElementString("password", memPwd);
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            finally
            {
                // Close the XML writer if it's open
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }


    }
}