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
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            passwordError.Visible = false;
            usernameError.Visible = false;
            CaptchaError.Visible = false;
            if (User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectFromLoginPage(User.Identity.Name, false);
            }
        }

        protected void DoLogin(object sender, EventArgs e)
        {
            usernameError.Visible = false;
            passwordError.Visible = false;
            CaptchaError.Visible = false;

            bool isHuman = LoginCaptcha.Validate(CaptchaCodeTextBox.Text);
            CaptchaCodeTextBox.Text = null;

            if (!isHuman)
            {
                CaptchaError.Text = "Invalid code";
                CaptchaError.Visible = true;
                return;
            }
           
            // perform login
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            Auth auth = new Auth(Server.MapPath("~/Members.xml"));
            bool success = auth.Login(username, password);
            // add login cookie
            if (success)
            {
                FormsAuthentication.SetAuthCookie(username, false);
                FormsAuthentication.RedirectFromLoginPage(username, false);
            } else
            {
                usernameError.Text = "Invalid username";
                passwordError.Text = "Invalid password";
                passwordError.Visible = true;
                usernameError.Visible = true;
            }
        }

    }
}