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
    public partial class PlaceInquries : Form
    {
        private int _currentUserId;
        public PlaceInquries(int userId)
        {
            InitializeComponent();
            _currentUserId = userId;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            // Get data from UI
            string name = textname.Text.Trim();
            string nic = textnic.Text.Trim();
            string address = textaddress.Text.Trim();
            string inquiry = textinquary.Text.Trim();
            string dateText = textdate.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nic) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(inquiry) ||
                string.IsNullOrEmpty(dateText))
            {
                MessageBox.Show("Please fill in all fields before saving.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate date
            if (!DateTime.TryParse(dateText, out DateTime inquiryDate))
            {
                MessageBox.Show("Invalid date format. Please enter a valid date.", "Date Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = DatabaseConnection.Instance.GetConnection())
                {
                    string query = @"INSERT INTO Inquiries 
                                    (UserID, Name, NIC, Address, InquiryText, Date)
                                    VALUES (@UserID, @Name, @NIC, @Address, @InquiryText, @Date)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _currentUserId);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@NIC", nic);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@InquiryText", inquiry);
                        cmd.Parameters.AddWithValue("@Date", inquiryDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your inquiry has been successfully submitted.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optionally clear fields
                            textname.Clear();
                            textnic.Clear();
                            textaddress.Clear();
                            textinquary.Clear();
                            textdate.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit your inquiry. Please try again.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving your inquiry:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

