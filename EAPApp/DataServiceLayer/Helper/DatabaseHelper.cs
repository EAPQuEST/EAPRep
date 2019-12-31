using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DataServiceLayer.Helper
{
    class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = null;

            try
            {
              //  String connectionstring = ConfigurationManager.ConnectionStrings["PresentataionLayer.Properties.Settings.EngineeringAllotmentDatabaseConnectionString"].ConnectionString;

                con = new SqlConnection(connectionstring);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : DBHelper.cs:GetConnection", ex.Message.ToString());
            }
            return con;

        }
    }
}
