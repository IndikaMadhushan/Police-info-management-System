using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Forms.DataAccess
{
    public class DatabaseConnection
    {
        private static string _connectionString = null;
        
        static DatabaseConnection()
        {
            _connectionString = @"Data Source=INDIKA\SQLEXPRE;Initial Catalog=PoliceInfoManagementDB;Integrated Security=True;";
        }

        
        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            return conn;
        }

        public static bool TestConnectin()
        {
            try
            {
                using (var connection = getConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
