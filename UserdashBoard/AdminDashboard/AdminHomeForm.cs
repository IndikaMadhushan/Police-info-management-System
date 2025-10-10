using Forms.Models;
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
        public AdminHomeForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

        }
    }
}
