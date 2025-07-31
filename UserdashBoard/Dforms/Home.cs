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

        //method to get the fault from the database

        private void LoadUserFaults()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            // Define columns once
            listView1.Columns.Add("Description", 150);
            listView1.Columns.Add("Type", 100);
            listView1.Columns.Add("Fine", 80);
            listView1.Columns.Add("Date", 100);
            listView1.Columns.Add("Status", 100);

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Get data from DB
            var faults = FaultRepository.GetFaultsByUserId(_currentUser.UserId);

            // Fill listView1
            foreach (var fault in faults)
            {
                ListViewItem item = new ListViewItem(fault.Description);
                item.SubItems.Add(fault.FaultType);
                item.SubItems.Add(fault.FineAmount.ToString("C")); // "Rs. 500.00"
                item.SubItems.Add(fault.DateRecorded.ToShortDateString());
                item.SubItems.Add(fault.Status);

                listView1.Items.Add(item);
            }
        }





        public Home(User user)
        {
            _currentUser = user;
            InitializeComponent();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadUserFaults();
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
    }
}
