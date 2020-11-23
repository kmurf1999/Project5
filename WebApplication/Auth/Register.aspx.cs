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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            passwordError.Visible = false;
            passwordAgainError.Visible = false;
            usernameError.Visible = false;
            CaptchaError.Visible = false;
            if (User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectFromLoginPage(User.Identity.Name, false);
            }
        }

        protected void DoSignup(object sender, EventArgs e)
        {
            usernameError.Visible = false;
            passwordError.Visible = false;
            passwordAgainError.Visible = false;
            CaptchaError.Visible = false;

            bool isHuman = RegisterCaptcha.Validate(CaptchaCodeTextBox.Text);
            CaptchaCodeTextBox.Text = null;

            if (!isHuman)
            {
                CaptchaError.Text = "Invalid code";
                CaptchaError.Visible = true;
                return;
            }

            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string passwordAgain = passwordAgainInput.Text;
            Auth auth = new Auth(Server.MapPath("~/Members.xml"));
            
            if (auth.MemberExists(username))
            {
                usernameError.Text = "This username is already in use";
                usernameError.Visible = true;
                return;
            }

            if (password != passwordAgain)
            {
                passwordAgainError.Text = "passwords don't match";
                passwordAgainError.Visible = true;
                return;
            }

            bool success = auth.Register(username, password, "Member");
            if (success)
            {
                FormsAuthentication.SetAuthCookie(username, false);
                FormsAuthentication.RedirectFromLoginPage(username, false);
            } else
            {
                usernameError.Text = "Unknown error";
                passwordError.Text = "Unknown error";
                usernameError.Visible = true;
                passwordError.Visible = true;
            }


        }
    }
}