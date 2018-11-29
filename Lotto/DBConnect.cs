using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class DBConnect
    {
        private static SqlConnection con = null;

        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public DBConnect()
        {

        }

        public static SqlConnection Connect()
        {
            if (con == null)
            {
                con = new SqlConnection();
            }
            con.ConnectionString = conStr;
            return con;
        }

        public static void Close(SqlConnection con)
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
