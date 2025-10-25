using System;
using Microsoft.Data.SqlClient;
using Forms.DataAccess;
using Forms.Models;

namespace Forms.BusinessLogic
{
    public static class AuthenticationService
    {
        private static User? _currentUser; // ✅ nullable field

        public static void SetCurrentUser(User user)
        {
            _currentUser = user;
        }

        public static User? GetCurrentUser()
        {
            return _currentUser;
        }

        public static User? Authenticate(string username, string password)
        {
            var db = DatabaseConnection.Instance;

            using (var conn = db.GetConnection())
            {
                string query = @"SELECT user_id, password_hash, role, name, nic, address, job, phone, email, dob, profile_picture 
                                 FROM Users 
                                 WHERE username = @username AND is_active = 1";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            string storedHash = reader.GetString(1);
                            string role = reader.GetString(2);
                            string name = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            string nic = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            string address = reader.IsDBNull(5) ? "" : reader.GetString(5);
                            string job = reader.IsDBNull(6) ? "" : reader.GetString(6);
                            string phone = reader.IsDBNull(7) ? "" : reader.GetString(7);
                            string email = reader.IsDBNull(8) ? "" : reader.GetString(8);
                            DateTime? dob = reader.IsDBNull(9) ? (DateTime?)null : reader.GetDateTime(9);
                            // public byte[] ProfilePicture;
                            byte[] ProfilePicture = reader["profile_picture"] == DBNull.Value ? null : (byte[])reader["profile_picture"];

                            string hashedInput = PasswordHasher.HashPassword(password);

                            if (hashedInput == storedHash)
                            {
                                return new User(userId, username, role, name, nic, address, job, phone, email, dob, ProfilePicture);
                            }
                        }
                    }
                }
            }

            return null; // Invalid username or password
        }
    }
}
