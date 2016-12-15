using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class DBConnection
    {
        private static SqlConnection connection;
        private DBConnection() { }
        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                string connectionString = String.Format("server={0};database={1};user={2};password={3}",
                Properties.Settings.Default.Server, Properties.Settings.Default.Database,
                Properties.Settings.Default.user, Properties.Settings.Default.password);
                connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                }
                catch(SqlException)
                {
                    throw;
                }
            }
            return connection;
        }
        public static void CloseConnection()
        {
            connection.Close();
        }
    }
}
