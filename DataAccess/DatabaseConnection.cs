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
        private static string _connectionString;
        
        static DatabaseConnection()
        {
            //Connectin String
            _connectionString = @"Data Source=LAPTOP-1017J42I;Initial Catalog=PoliceInfoManagementDB;Integrated Security=True;";
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
