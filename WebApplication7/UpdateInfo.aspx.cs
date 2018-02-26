using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class UpdateInfo : System.Web.UI.Page
    {
        private Customer custOld;
        protected void Page_Load(object sender, EventArgs e)
        {
            int custId = Convert.ToInt32(Session["user"]);
            this.GetCustomer(custId);
            if (custOld == null) { }
            else
                this.DisplayCustomer();
        }
        

        private void GetCustomer(int custId)
        {
            try
            {
                custOld = customerDB.GetCustInfo(custId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void DisplayCustomer()
        {
            lblID.Text = custOld.CustomerID.ToString();
            txtF.Text = custOld.CustFirstName;
            txtL.Text = custOld.CustLastName;
            txtA.Text = custOld.CustAddress;
            txtCi.Text = custOld.CustCity;
            ddlProvinces.Text = custOld.CustProvince;
            txtCo.Text = custOld.CustCountry;
            txtPo.Text = custOld.CustPostal;
            txtH.Text = custOld.CustHomePhone;
            txtB.Text = custOld.CustBusPhone;
            txtE.Text = custOld.CustEmail;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer updateCust = new Customer();
            updateCust = GetInfo();
            updateCust.CustomerID = custOld.CustomerID;


            try
            {
                if (!customerDB.UpdateCustomerInfo(custOld, updateCust)) { }
                else
                {
                    //cust = updateCust;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Customer GetInfo()
        {
            Customer cust = new Customer();
            cust.CustomerID = Convert.ToInt32(lblID.Text);
            cust.CustFirstName = txtF.Text;
            cust.CustLastName = txtL.Text;
            cust.CustAddress = txtA.Text;
            cust.CustCity = txtCi.Text;
            cust.CustProvince = ddlProvinces.Text;
            cust.CustCountry = txtCo.Text;
            cust.CustPostal = txtPo.Text;
            cust.CustHomePhone = txtH.Text;
            cust.CustBusPhone = txtB.Text;
            cust.CustEmail = txtE.Text;
            return cust;
        }

       

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txtF.Text = "";
            txtL.Text = "";
            txtA.Text = "";
            txtCi.Text = "";
            ddlProvinces.Text = "";
            txtCo.Text = "";
            txtPo.Text = "";
            txtH.Text = "";
            txtB.Text = "";
            txtE.Text = "";

           
         
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
           
        }
    }
}