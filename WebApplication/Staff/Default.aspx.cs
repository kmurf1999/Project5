using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication.Staff
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Auth.Auth auth = new Auth.Auth(Server.MapPath("~/Members.xml"));
            if (!User.Identity.IsAuthenticated || auth.GetRole(User.Identity.Name) != "Staff")
            {
                Response.Redirect("~/Auth/Login");
            }
        }
    }
}