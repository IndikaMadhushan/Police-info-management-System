using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.Models;

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

        private void userdashboard_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
