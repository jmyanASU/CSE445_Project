using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Project5
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            foreach (string key in Request.Cookies.AllKeys)
            {
                HttpCookie cookie = Request.Cookies[key];
                cookie.Expires = DateTime.Now.AddMonths(-1);
                Response.AppendCookie(cookie);
            }
            Response.Redirect("default.aspx");
        }
        private void CreateUserXML(string memName, string memPwd)
        {
            XmlTextWriter writer = null;

            try
            {
                // Determine the path to the XML file
                string path = HttpRuntime.AppDomainAppPath;
                path += (path == "http://webstrar31.fulton.asu.edu/") ? @"page10\App_Data\Staff.xml"
                                                                        : @"\App_Data\Staff.xml";

                // Create an XML writer with proper formatting
                writer = new XmlTextWriter(path, System.Text.Encoding.Unicode)
                {
                    Formatting = Formatting.Indented
                };

                // Write the XML document content
                writer.WriteStartDocument();
                writer.WriteStartElement("users");
                writer.WriteStartElement("user");
                writer.WriteElementString("username", stafflbl.Text);
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

        protected void addStaffbtn_Click(object sender, EventArgs e)
        {
            XmlDocument xd = new XmlDocument();
            ;
            string path;

            try
            {
                // Determine the path to the XML file
                path = HttpRuntime.AppDomainAppPath;
                path += (path == "http://webstrar31.fulton.asu.edu/") ? @"page10\App_Data\Staff.xml"
                                                                        : @"\App_Data\Staff.xml";


                // Load the XML document
                xd.Load(path);
            }
            catch (Exception)
            {
                // If the XML file doesn't exist, create a new one
                CreateUserXML(stafflbl.Text, passwordlbl.Text);
                return;
            }

            // Get the root element
            XmlNode root = xd.SelectSingleNode("users");

            // Create a new member element
            XmlElement newUser = xd.CreateElement("user");

            // Create name and password elements and set their values
            XmlElement newName = xd.CreateElement("username");
            newName.InnerText = stafflbl.Text;

            XmlElement newPwd = xd.CreateElement("password");
            newPwd.InnerText = passwordlbl.Text;

            // Add the name and password elements to the member element
            newUser.AppendChild(newName);
            newUser.AppendChild(newPwd);

            // Add the member element to the root element
            root.AppendChild(newUser);

            // Save the updated XML document
            xd.Save(path);
        }
    }
}