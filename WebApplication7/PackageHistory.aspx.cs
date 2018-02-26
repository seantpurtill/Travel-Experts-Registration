using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class PackageHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected String PackageHistoryDisplay()
        {
            int custId = Convert.ToInt32(Session["user"]);

            List<CustomerPackage> customerPackageList = new List<CustomerPackage>();
            customerPackageList = PackageDB.GetCustPackages(custId);

            string packageCards = "";
            decimal sum = 0;
            string d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13;

            foreach (CustomerPackage package in customerPackageList)
            {
                d1 = "<div class=\"row\">";
                d2 = "<div class=\"col-md-4\" >";
                d3 = "<div class=\"card\">";
                d4 = "<div class=\"card-block\">";
                d5 = "<h4 class=\"card-title\">" + package.PkgName + "</h4>";
                d6 = "<p class=\"card-text\">Description: " + package.PkgDesc + "</p>";
                d7 = "<p class=\"card-text\">Booking Date: " + Convert.ToDateTime(package.BookingDate).ToLongDateString() + "</p>";
                d8 = "<p class=\"card-text\">Start Date: " + Convert.ToDateTime(package.PkgStartDate).ToLongDateString() + "</p>";
                d9 = "<p class=\"card-text\">End Date: " + Convert.ToDateTime(package.PkgEndDate).ToLongDateString() + "</p>";
                d10 = "<p class=\"card-text\">Price: " + package.PkgBasePrice.ToString("c") + "</p>";
                d11 = "</div>";
                d12 = "</div>";
                d13 = "</div>";
                sum += package.PkgBasePrice;

                packageCards += d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10 + d11 + d12 + d13;
            }

            d1 = "<div class=\"row\">";
            d2 = "<div class=\"col-md-4\" >";
            d3 = "<div class=\"card\">";
            d4 = "<div class=\"card-block\">";
            d5 = "<h4 class=\"card-title\">Total cost</h4>";
            d6 = "<p class=\"card-text\">" + sum.ToString("c") + "</p>";
            d7 = "</div>";
            d8 = "</div>";
            d9 = "</div>";
            packageCards += d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9;

            return packageCards;
        }
    }
}