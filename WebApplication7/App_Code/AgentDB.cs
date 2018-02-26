using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7
{
    class AgentDB
    {
        public static List<Agents> GetAgents()
        {
            List<Agents> agentlist = new List<Agents>();//Create an empty list of suppliers
            //List<string> agentlistfullName = new List<string>();//Create an empty list of suppliers
            Agents agent = null;//Create a null supplier

            SqlConnection con = TravelExpertsDB.GetConnection();//Create a connection to db

            //Build the query to access the supplierId and SupName from the Suppliers table
            string selectQuery = "SELECT AgentID, AgtFirstName, AgtLastName " +
                                 "FROM Agents";
            //Build the selectCommand by giving SqlCommand the query and the connection to the db
            SqlCommand selectCommand = new SqlCommand(selectQuery, con);

            try
            {
                con.Open();//Open the connection
                SqlDataReader reader = selectCommand.ExecuteReader();//Execute the select command and store results in reader
                while (reader.Read()) //Read the suppliers if they still exist
                {
                    agent = new Agents();//Create a new supplier for this iteration
                    //Add the supplier properties
                    agent.AgentID = (int)reader["AgentID"];
                    agent.AgtFirstName = (string)reader["AgtFirstName"];
                    agent.AgtLastName = (string)reader["AgtlastName"];

                    agent.AgtFullName = agent.AgtFirstName + " " + agent.AgtLastName;

                    agentlist.Add(agent);//Add this supplier to the supplier list
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();//Close the connection
            }
            //foreach (Agents a in agentlist)
            //{
            //    String FullName;

            //    FullName = agent.AgtFirstName + " " + agent.AgtLastName;

            //    agentlistfullName.Add(FullName);
            //}
            return agentlist;


        }

    }
}
