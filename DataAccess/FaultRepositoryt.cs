using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.DataAccess
{
    public class Fault
    {
        public string Description { get; set; }
        public string FaultType { get; set; }
        public decimal FineAmount { get; set; }
        public DateTime DateRecorded { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{DateRecorded.ToShortDateString()} - {FaultType}: {Description} (${FineAmount}) - {Status}";
        }
    }

    public static class FaultRepository
    {
        public static List<Fault> GetFaultsByUserId(int userId)
        {
            List<Fault> faults = new List<Fault>();

            using (SqlConnection conn = DatabaseConnection.getConnection())
            {
                string query = @"SELECT description, fault_type, fine_amount, date_recorded, status 
                                 FROM Faults WHERE user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            faults.Add(new Fault
                            {
                                Description = reader["description"].ToString(),
                                FaultType = reader["fault_type"].ToString(),
                                FineAmount = reader.GetDecimal(reader.GetOrdinal("fine_amount")),
                                DateRecorded = reader.GetDateTime(reader.GetOrdinal("date_recorded")),
                                Status = reader["status"].ToString()
                            });
                        }
                    }
                }
            }

            return faults;
        }
    }
}
