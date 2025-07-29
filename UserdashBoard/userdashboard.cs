using Forms.UserdashBoard.Dforms;
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
    public partial class Userdashboard : Form
    {
        public Userdashboard()
        {
            InitializeComponent();
        }

        private void Userdashboard_Load(object sender, EventArgs e)
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
            LoadFormInPanel(new Home());
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
    }
}
