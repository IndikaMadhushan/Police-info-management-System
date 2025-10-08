using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.DataAccess;
using Microsoft.Data.SqlClient;

namespace Forms.UserdashBoard.Dforms
{
    public partial class FireArmPermission : Form
    {
        // store logged-in user ID
        private int _currentUserId;
        public FireArmPermission(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FireArmPermission_Load(object sender, EventArgs e)
        {
            textDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textname.Text.Trim();
            string nic = textnic.Text.Trim();
            string address = Textaddress.Text.Trim();
            string firearmType = texttype.Text.Trim();
            string reason = textreason.Text.Trim();
            string requestDate = textDate.Text.Trim();

            // Basic validation
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(nic) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(firearmType) ||
                string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Please fill in all fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    string query = @"
                        INSERT INTO FirearmPermissions 
                            (user_id, FullName, NIC, Address, FirearmType, RequestReason, RequestDate, request_date, status)
                        VALUES 
                            (@user_id, @FullName, @NIC, @Address, @FirearmType, @RequestReason, @RequestDate, GETDATE(), 'Pending')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", _currentUserId);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@NIC", nic);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@FirearmType", firearmType);
                        cmd.Parameters.AddWithValue("@RequestReason", reason);
                        cmd.Parameters.AddWithValue("@RequestDate", requestDate);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Your firearm permission request has been submitted successfully!",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit your request. Please try again.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting the request:\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            textname.Clear();
            textnic.Clear();
            Textaddress.Clear();
            texttype.Clear();
            textreason.Clear();
            textDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
