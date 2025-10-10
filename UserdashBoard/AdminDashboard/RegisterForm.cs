using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Forms.DataAccess;
using Forms.BusinessLogic; // for DatabaseConnection

namespace Forms.UserdashBoard.AdminDashboard
{
    public partial class RegisterForm : Form
    {
        private byte[]? profileImageBytes = null;

        public RegisterForm()
        {
            InitializeComponent();
        }

        // 🔹 Browse Image
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Profile Picture";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = ofd.FileName;
                        picProfile.Image = new Bitmap(filePath);

                        // Convert to byte array
                        profileImageBytes = File.ReadAllBytes(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 🔹 Register Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox6.Text.Trim();
                string username = textBox5.Text.Trim();
                string nic = textBox4.Text.Trim();
                DateTime dob = DateTime.Parse(textBox1.Text.Trim());
                string address = textBox2.Text.Trim();
                string phone = textBox3.Text.Trim();
                string email = textBox7.Text.Trim();
                string job = textBox8.Text.Trim();
                string role = textBox9.Text.Trim();
                string password = textBox10.Text.Trim();
                string password_hash = PasswordHasher.HashPassword(password);

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = DatabaseConnection.Instance.GetConnection())
                {
                    string query = @"
                        INSERT INTO Users
                        (name, username, password_hash, role, address, phone, email, nic, job, dob, profile_picture)
                        VALUES
                        (@name, @username, @password, @role, @address, @phone, @email, @nic, @job, @dob, @profile_picture)";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password_hash);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@job", job);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@profile_picture",
                            (object?)profileImageBytes ?? DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User registered successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Date of Birth (YYYY-MM-DD).",
                    "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Clear all fields after registration
        private void ClearForm()
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox txt)
                    txt.Clear();
            }
            picProfile.Image = null;
            profileImageBytes = null;
        }
    }
}
