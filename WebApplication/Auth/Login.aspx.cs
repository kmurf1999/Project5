using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Encryption;

namespace WebApplication.Auth
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Request.IsAuthenticated);
        }

        protected void DoLogin(object sender, EventArgs e)
        {
            // perform login
            bool success = false;
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string hash = Hasher.hash(password);
            // open member document
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            FileStream fs = new FileStream(Server.MapPath("~/Members.xml"), FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("member");
            for (int i=0; i < xmlnode.Count; i++)
            {
                string u = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                string h = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                if (username == u && hash == h)
                {
                    success = true;
                    break;
                }
            }
            // add login cookie
            if (success)
            {
                FormsAuthentication.SetAuthCookie(username, false);
                FormsAuthentication.RedirectFromLoginPage(username, false);
            }
        }

    }
}