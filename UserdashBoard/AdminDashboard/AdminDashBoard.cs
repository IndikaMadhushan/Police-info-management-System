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
    public partial class AdminDashBoard : Form
    {
        private readonly User _currentUser;
        public AdminDashBoard(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonFireArm_Click(object sender, EventArgs e)
        {

        }
    }
}
