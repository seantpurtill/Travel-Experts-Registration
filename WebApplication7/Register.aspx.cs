using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class Register : System.Web.UI.Page
    {
        public Customer addCust;

        List<Agents> agentlistfullName = new List<Agents>();

        private void PutCustData(Customer addCust)
        {
            int randomagent;
            Random rdm = new Random();
            randomagent = rdm.Next(1, 9);


            if (chkAgents.Checked)
            {
                addCust.AgentID = Convert.ToInt32(ddlAgents.SelectedValue);

            }

            else if (!chkAgents.Checked)
            {
                addCust.AgentID = randomagent;

            }

            addCust.CustFirstName = txtfirst.Text;
            addCust.CustLastName = txtlast.Text;
            addCust.CustAddress = txtaddress.Text;
            addCust.CustCity = txtcity.Text;
            addCust.CustProvince = ddlProvinces.Text;
            addCust.CustPostal = txtpostal.Text;
            addCust.CustCountry = txtcountry.Text;
            addCust.CustHomePhone = txthomephone.Text;
            addCust.CustBusPhone = txtbizphone.Text;
            addCust.CustEmail = txtemail.Text;
            addCust.CustPassword = SecurePasswordHasher.Hash(txtpassword.Text);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            agentlistfullName = AgentDB.GetAgents();
            ddlAgents.DataSource = agentlistfullName;
            ddlAgents.DataTextField = "AgtFullName";
            ddlAgents.DataValueField = "AgentID";
            ddlAgents.DataBind();
        }



        protected void chkAgents_CheckedChanged1(object sender, EventArgs e)
        {
            if (chkAgents.Checked)
            {
                ddlAgents.Visible = true;
                ddlAgents.Enabled = true;
            }

            else if (!chkAgents.Checked)
            {

                ddlAgents.Visible = false;
                ddlAgents.Enabled = false;

            }
        }

        protected void btnToRegister_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != txtconfirm.Text)
            {
                Response.Write("Passwords must match");
            }
            else
            {

                string checkEmail;
                bool emailPresent = true;
                checkEmail = txtemail.Text;

                emailPresent = customerDB.emailalreadyused(checkEmail);

                if (emailPresent == true)
                {
                    Response.Write("Sorry that email is already registered");
                }
                else
                {
                    addCust = new Customer();
                    this.PutCustData(addCust);
                    try
                    {
                        customerDB.AddCustomer(addCust);
                        Response.Write("Customer Registered");

                    }
                    catch (Exception)
                    {
                        Response.Write("This is wrong");
                    }
                }
            }
        }

        protected void ddlAgents_Load(object sender, EventArgs e)
        {
            agentlistfullName = AgentDB.GetAgents();
            ddlAgents.DataSource = agentlistfullName;
            ddlAgents.DataTextField = "AgtFullName";
            ddlAgents.DataValueField = "AgentID";
        }
    }
}