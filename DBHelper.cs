using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace cs_Week5.dao
{
    class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = null;
            string connectionString = null;

            try
            {

                connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\1028283\\Desktop\\raheena\\Week5\\cs_Week5\\cs_Week5\\StudentDB.mdf; Integrated Security = True";
                con = new SqlConnection(connectionString);

            }
            catch(Exception ex)
            {
                Console.Out.WriteLine("*** Error : DBHelper.cs:GetConnection", ex.Message.ToString());
            }
            return con;
        }
    }
}
