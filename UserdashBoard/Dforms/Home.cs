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

namespace Forms.UserdashBoard.Dforms
{
    public partial class Home : Form
    {
        private User _currentUser;
        public Home(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            textname.Text = _currentUser.Name;
            textid.Text = _currentUser.NIC;
            textaddress.Text = _currentUser.Address;
            textjob.Text = _currentUser.Job;
            texttel.Text = _currentUser.Phone;
            textmail.Text = _currentUser.Email;
            textDate.Text = _currentUser.DateOfBirth?.ToString("yyyy-MM-dd");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
