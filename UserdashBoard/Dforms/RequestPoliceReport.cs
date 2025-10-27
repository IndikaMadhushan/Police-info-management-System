using Forms.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.UserdashBoard.Dforms
{
    public partial class RequestPoliceReport : Form
    {
        public RequestPoliceReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Collect form data
            string name = textname.Text.Trim();
            string nic = textnic.Text.Trim();
            string address = textaddress.Text.Trim();
            string position = textpossition.Text.Trim();
            string email = textmail.Text.Trim();
            string reason = textreason.Text.Trim();

            // Validate that all fields are filled
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(nic) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(position) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Please fill in all fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Connect to the database
                //var db = new DatabaseConne
                using (var connection = DatabaseConnection.Instance.GetConnection())
                {
                    //connection.Open();

                    // SQL query to insert police report request
                    string query = @"
                        INSERT INTO PoliceReportRequests (FullName, NIC, Address, Position, Email, Reason, RequestDate)
                        VALUES (@FullName, @NIC, @Address, @Position, @Email, @Reason, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@FullName", name);
                        cmd.Parameters.AddWithValue("@NIC", nic);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Position", position);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Reason", reason);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Police report request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit the request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting the request:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            textname.Clear();
            textnic.Clear();
            textaddress.Clear();
            textpossition.Clear();
            textmail.Clear();
            textreason.Clear();
        }


        private void textreason_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
