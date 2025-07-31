using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Forms.DataAccess;
using Forms.Models;

namespace Forms.BusinessLogic
{
    public static class AuthenticationService
    {
        //to return the logged-in user
        private static User _currentUser;

        public static void setCurrentUser(User user)
        {
            _currentUser = user;
        }

        public static User GetCurrentUser()
        {
            return _currentUser;
        }

        public static User Authenticate(string username, string password)
        {
            using (var conn = DatabaseConnection.getConnection())
            {
                string query = @"SELECT user_id, password_hash, role, name, nic, address, job, phone, email, dob 
                                 FROM Users 
                                 WHERE username = @username AND is_active = 1";

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
                            string name = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            string nic = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            string address = reader.IsDBNull(5) ? "" : reader.GetString(5);
                            string job = reader.IsDBNull(6) ? "" : reader.GetString(6);
                            string phone = reader.IsDBNull(7) ? "" : reader.GetString(7);
                            string email = reader.IsDBNull(8) ? "" : reader.GetString(8);
                            DateTime? dob = reader.IsDBNull(9) ? (DateTime?)null : reader.GetDateTime(9);

                            string hashedInput = PasswordHasher.HashPassword(password);

                            if (hashedInput == storedHash)
                            {
                                return new User(userId, username, role, name, nic, address, job, phone, email, dob);
                            }
                        }
                    }
                }
            }

            return null; // Invalid username or password
        }

        // ✅ NEW METHOD: Fetch fault descriptions for the logged-in user
        public static List<string> GetFaultDescriptionsByUserId(int userId)
        {
            var faults = new List<string>();

            using (var conn = DatabaseConnection.getConnection())
            {
                string query = "SELECT description FROM Faults WHERE user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string description = reader.GetString(0);
                            faults.Add(description);
                        }
                    }
                }
            }

            return faults;
        }
    }
}
