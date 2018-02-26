using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)Session["loginState"]))
            {
                Session["loginState"] = "false";
            }
        }

        protected string NavBarState()
        {
            if ((string)Session["loginState"] == "false")
            {
                string d1 = "<li class=\"active\"><a href=\"MainPage.aspx\" > Home </a></li>";
                string d2 = "<li><a href = \"Register.aspx\"> Register </a></li>";
                string d3 = "<li><a href =\"Login.aspx\"> Login </a></li>";

                return d1 + d2 + d3;
            }
            else
            {
                string d1 = "<li class=\"active\"><a href = \"MainPage.aspx\" > Home </a></li>";
                string d2 = "<li ><a href=\"PackageHistory.aspx\">Package History</a></li>";
                string d3 = "<li><a href=\"UpdateInfo.aspx\"> Update Info</a></li>";
                string d4 = "<li ><a href =\"Login.aspx\"> Logout </a></li>";

                return d1 + d2 + d3 + d4;
            }
        }
    }
}