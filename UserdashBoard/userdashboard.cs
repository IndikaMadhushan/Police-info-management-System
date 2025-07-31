using Forms.DataAccess;
using Forms.Models;
using Forms.UserdashBoard.Dforms;
using login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Forms.UserdashBoard
{

    public partial class UserDashboard : Form
    {
        private readonly User _currentUser;

        


        public UserDashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;

        }

        private void Userdashboard_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

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

        private void buttonHome_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new Home(_currentUser));
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new PayBountyFee());
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new RequestPoliceReport());
        }

        private void buttonInquiries_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new PlaceInquries());
        }

        private void buttonFirearm_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new FireArmPermission());
        }

        private void buttonchangepwd_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ChangePassword());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();

        
        }
    }
}
