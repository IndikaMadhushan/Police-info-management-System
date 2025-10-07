using Forms.BusinessLogic;
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
    public partial class ChangePassword : Form
    {
        private readonly int _userId;  // Pass from login session or dashboard
        private readonly PasswordService _passwordService;

        public ChangePassword(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _passwordService = new PasswordService();

            // Hide password characters
            textBox1.PasswordChar = '*';
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldPassword = textBox1.Text.Trim();
            string newPassword = textBox3.Text.Trim();
            string confirmPassword = textBox4.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and Confirm password do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_passwordService.ValidateOldPassword(_userId, oldPassword))
            {
                MessageBox.Show("Incorrect current password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_passwordService.UpdatePassword(_userId, newPassword))
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update password. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
