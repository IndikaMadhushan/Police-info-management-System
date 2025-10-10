using Forms.Models;
using Forms.UserdashBoard.Dforms;
using login;
using splitContainer1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Forms.UserdashBoard.AdminDashboard
{
    public partial class AdminHomeForm : Form
    {
        private readonly User _currentUser;
        private int currentUserId;
        public AdminHomeForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            currentUserId = user.UserId;
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new RegisterForm());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void LoadFormInPanel(Form form)
        {
            panel2.Controls.Clear();           // Clear current form
            form.TopLevel = false;                       // So it behaves like a control
            form.FormBorderStyle = FormBorderStyle.None; // No borders
            form.Dock = DockStyle.Fill;                  // Fill the main panel
            panel2.Controls.Add(form);         // Add to panel
            form.Show();                                 // Display
        }

        private void buttonchangepwd_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword(currentUserId);
            //changePasswordForm.ShowDialog();

            LoadFormInPanel(changePasswordForm);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ProfileForm(currentUserId));
        }
    }
}
