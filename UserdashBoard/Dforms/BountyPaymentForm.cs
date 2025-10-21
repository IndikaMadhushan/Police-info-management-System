using Forms.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Forms.UserdashBoard.UserDashboard
{
    public partial class BountyPaymentForm : Form
    {
        private int loggedInUserId; // passed from login or dashboard

        public BountyPaymentForm(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void BountyPaymentForm_Load(object sender, EventArgs e)
        {
            LoadUnpaidFaults(); // load all unpaid faults related to this user
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Card");
        }

        /// <summary>
        /// Loads all faults that the user has which are not yet paid.
        /// </summary>
        private void LoadUnpaidFaults()
        {
            try
            {
                using (SqlConnection con = DatabaseConnection.Instance.GetConnection())
                {
                    string query = @"
                        SELECT f.fault_id, f.description AS FaultDescription, f.fine_amount AS Amount
                        FROM Faults f
                        WHERE f.user_id = @UserID AND f.Status <> 'Paid'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", loggedInUserId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvBounties.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faults: " + ex.Message);
            }
        }

        private void dgvBounties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtFaultID.Text = dgvBounties.Rows[e.RowIndex].Cells["fault_id"].Value.ToString();
                txtAmount.Text = dgvBounties.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFaultID.Text))
            {
                MessageBox.Show("Please select a fault to pay.");
                return;
            }

            if (cmbPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Select a payment method.");
                return;
            }

            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            try
            {
                using (SqlConnection con = DatabaseConnection.Instance.GetConnection())
                {
                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        // Generate unique receipt number
                        string receiptNumber = $"RCPT-{Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}";

                        // 1️⃣ Insert into Bounties table
                        string insertQuery = @"
                            INSERT INTO Bounties (user_id, fault_id, amount, payment_method, date_paid, is_notified, receipt_number)
                            VALUES (@UserID, @FaultID, @Amount, @PaymentMethod, GETDATE(), 0, @ReceiptNumber)";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@UserID", loggedInUserId);
                            cmd.Parameters.AddWithValue("@FaultID", txtFaultID.Text);
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@ReceiptNumber", receiptNumber);
                            cmd.ExecuteNonQuery();
                        }

                        // 2️⃣ Update fault status to Paid
                        string updateQuery = @"UPDATE Faults SET Status = 'Paid' WHERE fault_id = @FaultID";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@FaultID", txtFaultID.Text);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        lblStatus.ForeColor = System.Drawing.Color.Green;
                        lblStatus.Text = "✅ Payment successful!";

                        LoadUnpaidFaults();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                        lblStatus.Text = "Payment failed: " + ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUnpaidFaults();
        }
    }
}
