using System;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Forms.DataAccess; // ✅ For DatabaseConnection

namespace Forms.UserdashBoard.AdminDashboard
{
    public partial class ProfileForm : Form
    {
        private readonly int _currentUserId;

        public ProfileForm(int currentUserId)
        {
            InitializeComponent();
            _currentUserId = currentUserId;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    string query = @"
                        SELECT 
                            name, role, address, phone, email, 
                            nic, dob, job, profile_picture 
                        FROM Users 
                        WHERE user_id = @user_id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", _currentUserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["name"]?.ToString() ?? "";
                                txtRole.Text = reader["role"]?.ToString() ?? "";
                                txtAddress.Text = reader["address"]?.ToString() ?? "";
                                txtPhone.Text = reader["phone"]?.ToString() ?? "";
                                txtEmail.Text = reader["email"]?.ToString() ?? "";
                                txtNic.Text = reader["nic"]?.ToString() ?? "";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
