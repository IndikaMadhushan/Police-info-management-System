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

        private void LoadUserFaultsIntoRichTextBox()
        {
            var currentUser = AuthenticationService.GetCurrentUser();

            if (currentUser == null)
            {
                listView1.Text = "User not logged in.";
                return;
            }

            var faults = FaultRepository.GetFaultsByUserId(currentUser.UserId);

            if (faults.Count == 0)
            {
                listView1.Text = "No faults found.";
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var fault in faults)
            {
                sb.AppendLine($"Description  : {fault.Description}");
                sb.AppendLine($"Type         : {fault.FaultType}");
                sb.AppendLine($"Fine         : Rs. {fault.FineAmount}");
                sb.AppendLine($"Date         : {fault.DateRecorded.ToShortDateString()}");
                sb.AppendLine($"Status       : {fault.Status}");
                sb.AppendLine(new string('-', 40));
            }

            listView1.Text = sb.ToString();
        }



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
            LoadUserFaultsIntoRichTextBox();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
