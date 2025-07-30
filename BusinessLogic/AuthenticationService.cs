using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Forms.DataAccess;
using Forms.Models;

namespace Forms.BusinessLogic
{
    public static class AuthenticationService
    {
        
            public static User Authenticate(string username, string password)
            {
                using (var conn = DatabaseConnection.getConnection())
                {
                    string query = "SELECT user_id, password_hash,  role FROM Users WHERE username = @username AND is_active = 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                string storedHash = reader.GetString(1);
                                string role = reader.GetString(2);

                                string hashedInput = PasswordHasher.HashPassword(password);

                                if (hashedInput == storedHash)
                                {
                                    return new User(userId, username, role);
                                }
                            }
                        }
                    }
                }
                return null; // Invalid username or password
            }
    }
}
