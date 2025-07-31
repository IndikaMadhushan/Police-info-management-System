using Forms.BusinessLogic;
using Forms.DataAccess;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Forms.UserdashBoard.Dforms
{

    public partial class Home : Form
    {
        private User _currentUser;

        public Home(User user)
        {
            _currentUser = user;
            InitializeComponent();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Load user details into the form controls
            textname.Text = _currentUser.Name;
            textid.Text = _currentUser.NIC;
            textaddress.Text = _currentUser.Address;
            textjob.Text = _currentUser.Job;
            texttel.Text = _currentUser.Phone;
            textmail.Text = _currentUser.Email;
            textDate.Text = _currentUser.DateOfBirth?.ToString("yyyy-MM-dd");

            


            //Load Faults List
            LoadFaults();
        }

        //method to load faults for the current user
        private void LoadFaults()
        {
            listViewBounty.Items.Clear(); // Clear previous items
            var faults = FaultRepository.GetFaultsByUserId(_currentUser.UserId);
            foreach (var fault in faults)
            {
                listViewBounty.Items.Add(fault.ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewBounty.Columns.Add("Description", 200);
            listViewBounty.Columns.Add("Type", 100);
            listViewBounty.Columns.Add("Fine", 80);
            listViewBounty.Columns.Add("Date", 120);
            listViewBounty.Columns.Add("Status", 100);

        }
       

    }
}
