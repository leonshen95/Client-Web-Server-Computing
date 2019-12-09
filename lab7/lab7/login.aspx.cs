using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(user.Text, pass.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(user.Text, true);
                Response.Redirect("./private/Show.aspx");
                msg.Text = "";
            }
            else
            {
                msg.Text = "Login failed. Please check your user name and password and try again.";
                user.Text = "";
            }
        }
    }
}