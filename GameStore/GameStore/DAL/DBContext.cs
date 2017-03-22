using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL
{
    class DBContext
    {
        public static SqlConnection openConnection()
        {
            SqlConnection connection = new SqlConnection(url());
            connection.Open();
            return connection;
        }

        public static SqlConnection closeConnection(SqlConnection connection)
        {
            connection.Close();
        }

        public static string url()
        {
            ConfigurationManager.ConnectionStrings["connection"].ToString();
        }
    }
}
