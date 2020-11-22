using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication.Auth
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DoSignup(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            bool alreadyExists = false;

            XmlDataDocument xmldoc = new XmlDataDocument();
            xmldoc.Load(Server.MapPath("~/Members.xml"));
            XmlNodeList memberNodes = xmldoc.GetElementsByTagName("member");
            for (int i = 0; i < memberNodes.Count; i++)
            {
                string u = memberNodes[i].ChildNodes.Item(0).InnerText.Trim();
                if (username == u)
                {
                    alreadyExists = true;
                    break;
                }
            }
            if (alreadyExists)
            {
                return;
            }
            XmlNode usernameNode = xmldoc.CreateNode(XmlNodeType.Element, "username", null);
            usernameNode.InnerText = username;
            XmlNode passwordNode = xmldoc.CreateNode(XmlNodeType.Element, "password", null);
            passwordNode.InnerText = password;
            XmlNode memberNode = xmldoc.CreateNode(XmlNodeType.Element, "member", null);
            memberNode.AppendChild(usernameNode);
            memberNode.AppendChild(passwordNode);

            XmlNode memberRoot = xmldoc.SelectSingleNode("members", null);

            memberRoot.AppendChild(memberNode);

            xmldoc.Save(Server.MapPath("~/Members.xml"));


            FormsAuthentication.SetAuthCookie(username, false);
            FormsAuthentication.RedirectFromLoginPage(username, false);
        }
    }
}