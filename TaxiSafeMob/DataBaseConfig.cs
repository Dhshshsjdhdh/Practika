using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TaxiSafeMob
{
    class DataBaseConfig
    {

        public static string Name;

        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-HH3U1T3\SQLEXPRESS;Initial Catalog=TaxiSafe;Integrated Security=True");
        public void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return SqlConnection;
        }

    }
}
