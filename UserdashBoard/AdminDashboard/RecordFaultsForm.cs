using Forms.DataAccess;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms.UserdashBoard.AdminDashboard
{
    public partial class RecordFaultsForm : Form
    {
        private readonly int _adminId; // Officer's user_id (recorded_by)

        public RecordFaultsForm(int adminId)
        {
            _adminId = adminId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nic = textBox1.Text.Trim();
                string description = textBox2.Text.Trim();
                string faultType = textBox3.Text.Trim();
                string fineText = textBox4.Text.Trim();
                string faultDateText = textBox5.Text.Trim();

                if (string.IsNullOrWhiteSpace(nic) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("NIC and Description are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int? userId = FaultRepository.GetUserIdByNIC(nic);
                if (userId == null)
                {
                    MessageBox.Show("No user found with the given NIC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal fine = 0;
                if (!decimal.TryParse(fineText, out fine))
                {
                    MessageBox.Show("Invalid fine amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime faultDate;
                if (!DateTime.TryParse(faultDateText, out faultDate))
                {
                    faultDate = DateTime.Now;
                }

                var fault = new Fault
                {
                    UserId = userId.Value,
                    Description = description,
                    FaultType = faultType,
                    FineAmount = fine,
                    FaultDate = faultDate,
                    RecordedBy = _adminId,
                    Status = "Active"
                };

                bool success = FaultRepository.RecordFault(fault);

                if (success)
                {
                    MessageBox.Show("Fault recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to record the fault.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
