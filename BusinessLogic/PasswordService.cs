using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;
using Forms.DataAccess;

namespace Forms.BusinessLogic
{
    public class PasswordService
    {
        /// <summary>
        /// Hashes a plain text password using SHA256.
        /// </summary>
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        /// Validates the old password for the given user.
        /// </summary>
        public bool ValidateOldPassword(int userId, string oldPassword)
        {
            string hashedOldPassword = HashPassword(oldPassword);

            using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE user_id = @userId AND password_hash = @passwordHash";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@passwordHash", hashedOldPassword);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result > 0;
                }
            }
        }

        /// <summary>
        /// Updates the user's password with the new hashed password.
        /// </summary>
        public bool UpdatePassword(int userId, string newPassword)
        {
            string hashedNewPassword = HashPassword(newPassword);

            using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
            {
                string query = "UPDATE Users SET password_hash = @newPassword, first_login = 0 WHERE user_id = @userId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@newPassword", hashedNewPassword);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
