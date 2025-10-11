using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient; // ✅ Modern SQL client
using Forms.DataAccess;

namespace Forms.DataAccess
{
    public class Fault
    {
        public string Description { get; set; } = string.Empty;
        public string FaultType { get; set; } = string.Empty;
        public decimal FineAmount { get; set; }
        public DateTime DateRecorded { get; set; }
        public DateTime FaultDate { get; set; }
        public int UserId { get; set; }
        public int RecordedBy { get; set; }
        public string Status { get; set; } = "Active";

        public override string ToString()
        {
            return $"{DateRecorded.ToShortDateString()} - {FaultType}: {Description} (Rs.{FineAmount}) - {Status}";
        }
    }

    public static class FaultRepository
    {
        public static List<Fault> GetFaultsByUserId(int userId)
        {
            var faults = new List<Fault>();
            var db = DatabaseConnection.Instance; // ✅ Use singleton instance

            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"SELECT description, fault_type, fine_amount, date_recorded, status 
                                 FROM Faults WHERE user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var fault = new Fault
                            {
                                Description = reader["description"]?.ToString() ?? string.Empty,
                                FaultType = reader["fault_type"]?.ToString() ?? string.Empty,
                                FineAmount = reader.GetDecimal(reader.GetOrdinal("fine_amount")),
                                DateRecorded = reader.GetDateTime(reader.GetOrdinal("date_recorded")),
                                Status = reader["status"]?.ToString() ?? string.Empty
                            };

                            faults.Add(fault);
                        }
                    }
                }
            }

            return faults;
        }

        public static bool RecordFault(Fault fault)
        {
            var db = DatabaseConnection.Instance;
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"INSERT INTO Faults (user_id, description, fault_type, fine_amount, recorded_by, fault_date, status)
                                 VALUES (@user_id, @description, @fault_type, @fine_amount, @recorded_by, @fault_date, @status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", fault.UserId);
                    cmd.Parameters.AddWithValue("@description", fault.Description);
                    cmd.Parameters.AddWithValue("@fault_type", fault.FaultType);
                    cmd.Parameters.AddWithValue("@fine_amount", fault.FineAmount);
                    cmd.Parameters.AddWithValue("@recorded_by", fault.RecordedBy);
                    cmd.Parameters.AddWithValue("@fault_date", fault.FaultDate);
                    cmd.Parameters.AddWithValue("@status", fault.Status);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // ✅ Helper to get user_id by NIC
        public static int? GetUserIdByNIC(string nic)
        {
            var db = DatabaseConnection.Instance;
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT user_id FROM Users WHERE NIC = @nic";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nic", nic);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : (int?)null;
                }
            }
        }
    }
}

