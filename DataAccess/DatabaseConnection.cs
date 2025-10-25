using System;
using Microsoft.Data.SqlClient; // ✅ modern namespace

namespace Forms.DataAccess
{
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> _instance =
            new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        private readonly string _connectionString;

        // Nullable connection for safety
        private SqlConnection? _connection;

        private DatabaseConnection()
        {
<<<<<<< HEAD
            _connectionString = @"Data Source=LAPTOP-1017J42I;Initial Catalog=PoliceInfoManagementDB;Integrated Security=True;TrustServerCertificate=True;";
=======
            _connectionString = @"Data Source=Indika\SQLEXPRESS;Initial Catalog=PoliceInfoManagementDB;Integrated Security=True;TrustServerCertificate=True;";
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            

        }

        public static DatabaseConnection Instance => _instance.Value;

        public SqlConnection GetConnection()
        {
            // Always create a *new* connection for thread safety
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
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
