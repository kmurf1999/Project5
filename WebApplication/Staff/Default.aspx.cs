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
                Response.Redirect("~/Auth/Login.aspx", false);
                HttpContext.Current.Response.Flush(); // Sends all currently buffered output to the client.
                HttpContext.Current.Response.SuppressContent = true;
                Context.ApplicationInstance.CompleteRequest();
            }
        }

        public void CountWords(object sender, EventArgs e)
        {
            WordCount.ServiceClient client = new WordCount.ServiceClient();

            string text = WordCountInput.Text;

            WordCountOutput.Text = client.GetWord(text);
        }
    }
}