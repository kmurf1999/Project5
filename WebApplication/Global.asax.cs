using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using System.Xml;

namespace WebApplication
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // create members.xml if it doesn't exist
            if (!File.Exists(Server.MapPath("~/Members.xml")))
            {
                XmlDocument doc = new XmlDocument();

                XmlDeclaration xmldecl = doc.CreateXmlDeclaration("1.0", null, null);
                XmlNode members = doc.CreateNode(XmlNodeType.Element, "members", "");

                doc.Save(Server.MapPath("~/Members.xml"));
            }
        }
    }
}