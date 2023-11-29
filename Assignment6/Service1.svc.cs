using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment6
{
    public class Service1 : IService1
    {
        public void addMember(string user, string pass)
        {
            //create a new xmlDoc
            XmlDocument xmlDoc = new XmlDocument();
            //create a path and load it into the xml doc
            string path = HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data/Members.xml");
            xmlDoc.Load(path);
            //create member element 
            XmlNode member = xmlDoc.CreateElement("Member", xmlDoc.DocumentElement.NamespaceURI);
            //create user element
            XmlNode xuser = xmlDoc.CreateElement("username", xmlDoc.DocumentElement.NamespaceURI);
            //set the text for user element and add it to member element
            xuser.InnerText = user;
            member.AppendChild(xuser);
            //create password element 
            XmlNode xpass = xmlDoc.CreateElement("password", xmlDoc.DocumentElement.NamespaceURI);
            //set the text for password element and add it to member element 
            xpass.InnerText = pass;
            member.AppendChild(xpass);
            //add the member element to the xml document
            xmlDoc.DocumentElement.AppendChild(member);
            //save the xml document 
            xmlDoc.Save(path);
        }

        public string hashPass(string pass)
        {
            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                //get the text data from the given password
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(pass);
                //compute the has based on the text data 
                byte[] hash = sha.ComputeHash(textData);
                //return the hashed string
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
    }
}
