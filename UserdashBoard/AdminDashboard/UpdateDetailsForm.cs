using Forms.BusinessLogic;
using Forms.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Forms.UserdashBoard.AdminDashboard
{
    public partial class UpdateDetailsForm : Form
    {
        private byte[]? profileImageBytes = null;
        private int User_id;

        public UpdateDetailsForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string username = txtUserName.Text.Trim();
                string nic = txtNIC.Text.Trim();
                DateTime dob = DateTime.Parse(txtDOB.Text.Trim());
                string address = txtAddress.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string job = txtJob.Text.Trim();
                string role = txtRole.Text.Trim();

                //converting the profile imagae if updated
                byte[] profileImageBytes = null;
                if (picProfile.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(picProfile.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        profileImageBytes = ms.ToArray();
                    }
                }




                using (var connection = DatabaseConnection.Instance.GetConnection())
                {
                    string query = @"
                                    UPDATE Users
                                            SET 
                                                name = @name,
                                                username = @username,
                                                role = @role,
                                                address = @address,
                                                phone = @phone,
                                                email = @email,
                                                nic = @nic,
                                                job = @job,
                                                dob = @dob,
                                                profile_picture = @profile_picture
                                            WHERE user_id = @User_id";
                   
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@job", job);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@profile_picture", (object?)profileImageBytes ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@user_id", User_id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No user found with the given ID or NIC.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            LoadProfileData(id);
        }

        private void LoadProfileData(string nic)
        {
            
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    string query = @"
                        SELECT 
                            user_id, name,username, role, address, phone, email, 
                            nic, dob, job, profile_picture 
                        FROM Users 
                        WHERE nic = @NIC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIC", nic);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User_id = (int)reader["user_id"];
                                txtName.Text = reader["name"]?.ToString() ?? "";
                                txtUserName.Text = reader["username"]?.ToString() ?? "";
                                txtRole.Text = reader["role"]?.ToString() ?? "";
                                txtAddress.Text = reader["address"]?.ToString() ?? "";
                                txtPhone.Text = reader["phone"]?.ToString() ?? "";
                                txtEmail.Text = reader["email"]?.ToString() ?? "";
                                txtNIC.Text = reader["nic"]?.ToString() ?? "";
                                txtDOB.Text = reader["dob"]?.ToString() ?? "";
                                txtJob.Text = reader["job"]?.ToString() ?? "";

                                // ✅ If ProfilePicture is stored as VARBINARY
                                if (reader["profile_picture"] != DBNull.Value)
                                {
                                    byte[] imageBytes = (byte[])reader["profile_picture"];
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        picProfile.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    picProfile.Image = Properties.Resources.default_profile; // optional placeholder image
                                }
                            }
                            else
                            {
                                MessageBox.Show("Profile not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
