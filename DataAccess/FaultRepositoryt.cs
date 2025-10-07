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
        public string Status { get; set; } = string.Empty;

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
    }
}
