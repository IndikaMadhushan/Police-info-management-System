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

            //Call method to load faults for the current user
            LoadFaults();


        }

        //method to load faults for the current user
        private void LoadFaults()
        {
            var faults = FaultRepository.GetFaultsByUserId(_currentUser.UserId);

            StringBuilder sb = new StringBuilder();

            if (faults.Count == 0)
            {
                sb.AppendLine("No faults recorded.");
            }
            else
            {
                sb.AppendLine("Your Fault Records:\n");
                sb.AppendLine("-------------------------------------------------------------------");
                sb.AppendLine($"{"Description",-30} {"Type",-15} {"Fine",-10} {"Date",-20} {"Status",-10}");
                sb.AppendLine("-------------------------------------------------------------------");

                foreach (var fault in faults)
                {
                    sb.AppendLine($"{fault.Description,-30} {fault.FaultType,-15} {fault.FineAmount,-10:C} {fault.DateRecorded.ToShortDateString(),-20} {fault.Status,-10}");
                }
            }

            richBoxBounty.Text = sb.ToString();
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



        private void richBoxBounty_TextChanged(object sender, EventArgs e)
        {

        }

        private void textaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
