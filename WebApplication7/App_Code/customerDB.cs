using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7
{
    public class customerDB
    {
        public static bool emailalreadyused(string given_email)
        {
            string SelectedEmail = ""; //get email
            bool emailpresent = true;

            SqlConnection connection = TravelExpertsDB.GetConnection();

            // create select command
            string selectString = "select CustEmail from Customers";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {
                // open connection
                connection.Open();
                // run the select command and process the results adding states to the list
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())// process next row
                {
                    SelectedEmail = reader["CustEmail"].ToString();
                    if (SelectedEmail == given_email)
                        emailpresent = true;
                    else
                        emailpresent = false;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex; // throw it to the form to handle
            }
            finally
            {
                connection.Close();
            }

            return emailpresent;
        }



        // inserts new customer record into register
        public static bool AddCustomer(Customer cust) // returns generated customer id
        {

            // prepare connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // prepare the statement
            string insertString = "insert into Customers " +
                                  "(CustFirstName, CustLastName, CustAddress, CustCity, " +
                                  "  CustProv, CustPostal, CustCountry, CustHomePhone, " +
                                  "  CustBusPhone, CustEmail, AgentID, CustPassword) " +
                               
                                  "values( @CustFirstName, @CustLastName, @CustAddress, @CustCity, " +
                                         " @CustProv, @CustPostal, @CustCountry, @CustHomePhone, " +
                                         " @CustBusPhone, @CustEmail, @CustAgentID, @CustPassword)";
            SqlCommand insertCommand = new SqlCommand(insertString, connection);

            insertCommand.Parameters.AddWithValue("@CustFirstName", cust.CustFirstName);
            insertCommand.Parameters.AddWithValue("@CustLastName", cust.CustLastName);
            insertCommand.Parameters.AddWithValue("@CustAddress", cust.CustAddress);
            insertCommand.Parameters.AddWithValue("@CustCity", cust.CustCity);
            insertCommand.Parameters.AddWithValue("@CustProv", cust.CustProvince);
            insertCommand.Parameters.AddWithValue("@CustPostal", cust.CustPostal);
            insertCommand.Parameters.AddWithValue("@CustCountry", cust.CustCountry);
            insertCommand.Parameters.AddWithValue("@CustHomePhone", cust.CustHomePhone);
            insertCommand.Parameters.AddWithValue("@CustBusPhone", cust.CustBusPhone);
            insertCommand.Parameters.AddWithValue("@CustEmail", cust.CustEmail);
            insertCommand.Parameters.AddWithValue("@CustAgentID", cust.AgentID);
            insertCommand.Parameters.AddWithValue("@Custpassword", cust.CustPassword);
          

            try
            {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery(); //for DML statements

                if (count > 0)
                    return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public static bool UpdateCustomerInfo(Customer customer, Customer updateCust)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateString = "UPDATE Customers "
                + "SET CustFirstName = @NewCustomerFirstName, "
                + "CustLastName = @NewCustLastName, "
                + "CustAddress = @NewCustAddress, "
                + "CustCity = @NewCustCity, "
                + "CustProv = @NewCustProv, "
                + "CustPostal = @NewCustPostal, "
                + "CustCountry = @NewcustCountry, "
                + "CustHomePhone = @NewCustHomePhone, "
                + "CustBusPhone = @NewCustBusPhone, "
                + "CustEmail = @NewCustEmail "
                + "WHERE CustomerId = @OldCustomerId "
                + "AND CustFirstName = @OldCustFirstName "
                + "AND CustLastName = @OldCustLastName "
                + "AND CustAddress = @OldCustAddress "
                + "AND CustCity = @OldCustCity "
                + "AND CustProv = @OldCustProv "
                + "AND CustPostal = @OldCustPostal "
                + "AND CustCountry = @OldcustCountry "
                + "AND CustHomePhone = @OldCustHomePhone "
                + "AND CustBusPhone = @OldCustBusPhone "
                + "AND CustEmail = @OldCustEmail";

            SqlCommand updateCmd = new SqlCommand(updateString, con);

            updateCmd.Parameters.AddWithValue("@NewCustomerFirstName", updateCust.CustFirstName);
            updateCmd.Parameters.AddWithValue("@NewCustLastName", updateCust.CustLastName);
            updateCmd.Parameters.AddWithValue("@NewCustAddress", updateCust.CustAddress);
            updateCmd.Parameters.AddWithValue("@NewCustCity", updateCust.CustCity);
            updateCmd.Parameters.AddWithValue("@NewCustProv", updateCust.CustProvince);
            updateCmd.Parameters.AddWithValue("@NewCustPostal", updateCust.CustPostal);
            updateCmd.Parameters.AddWithValue("@NewcustCountry", updateCust.CustCountry);
            updateCmd.Parameters.AddWithValue("@NewCustHomePhone", updateCust.CustHomePhone);
            updateCmd.Parameters.AddWithValue("@NewCustBusPhone", updateCust.CustBusPhone);
            updateCmd.Parameters.AddWithValue("@NewCustEmail", updateCust.CustEmail);

            updateCmd.Parameters.AddWithValue("@OldCustomerId", customer.CustomerID);
            updateCmd.Parameters.AddWithValue("@OldCustFirstName", customer.CustFirstName);
            updateCmd.Parameters.AddWithValue("@OldCustLastName", customer.CustLastName);
            updateCmd.Parameters.AddWithValue("@OldCustAddress", customer.CustAddress);
            updateCmd.Parameters.AddWithValue("@OldCustCity", customer.CustCity);
            updateCmd.Parameters.AddWithValue("@OldCustProv", customer.CustProvince);
            updateCmd.Parameters.AddWithValue("@OldCustPostal", customer.CustPostal);
            updateCmd.Parameters.AddWithValue("@OldcustCountry", customer.CustCountry);
            updateCmd.Parameters.AddWithValue("@OldCustHomePhone", customer.CustHomePhone);
            updateCmd.Parameters.AddWithValue("@OldCustBusPhone", customer.CustBusPhone);
            updateCmd.Parameters.AddWithValue("@OldCustEmail", customer.CustEmail);

            try
            {
                con.Open();
                int count = updateCmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public static Customer GetCustInfo(int customerId)
        {
            Customer cust = new Customer();
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectString = "SELECT CustomerId, CustFirstName, CustLastName, CustAddress, CustCity, CustProv, "
                + "CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail "
                + "From Customers "
                + "WHERE CustomerId = @CustomerId "
                + "ORDER BY CustFirstName";
            SqlCommand cmd = new SqlCommand(selectString, con);
            cmd.Parameters.AddWithValue("@CustomerId", customerId);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cust = new Customer();
                    cust.CustomerID = (int)reader["CustomerId"];
                    cust.CustFirstName = reader["CustFirstName"].ToString();
                    cust.CustLastName = reader["CustLastName"].ToString();
                    cust.CustAddress = reader["CustAddress"].ToString();
                    cust.CustCity = reader["CustCity"].ToString();
                    cust.CustProvince = reader["CustProv"].ToString();
                    cust.CustPostal = reader["CustPostal"].ToString();
                    cust.CustCountry = reader["CustCountry"].ToString();
                    cust.CustHomePhone = reader["CustHomePhone"].ToString();
                    cust.CustBusPhone = reader["CustBusPhone"].ToString();
                    cust.CustEmail = reader["CustEmail"].ToString();
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return cust;
        }
    }
}
        // email

        //public static void createnewpassword(string given_email)
        //{
            

        //    SqlConnection connection = TravelExpertsDB.GetConnection();

        //    // create select command
        //    string selectString = "select CustEmail from Customers";
        //    SqlCommand selectCommand = new SqlCommand(selectString, connection);
        //    try
        //    {
        //        // open connection
        //        connection.Open();
        //        // run the select command and process the results adding states to the list
        //        SqlDataReader reader = selectCommand.ExecuteReader();
        //        while (reader.Read())// process next row
        //        {
        //            //SelectedEmail = reader["CustEmail"].ToString();
        //            //if (SelectedEmail == given_email)
        //            //    emailpresent = true;
        //            //else
        //            //    emailpresent = false;

        //        }
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex; // throw it to the form to handle
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

            
        //}


    
