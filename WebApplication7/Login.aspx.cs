using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {


            //var hash = SecurePasswordHasher.Hash(txtPassword.Text);

            var pass = SecurePasswordHasher.GetHashPassword(txtCustID.Text);

            var result = SecurePasswordHasher.Verify(txtPassword.Text, pass);

            //var result2 = SecurePasswordHasher.ComparePasswords(txtPassword.Text, pass);

            if (result == true)
            {
                Session["loginState"] = "true";
                Session["user"] = txtCustID.Text;
                Response.Redirect("MainPage.aspx");

            }
            else
            {
                Response.Write("Login Failed");
            }
        }
    }
}