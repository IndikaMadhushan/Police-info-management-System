using Forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Forms.DataAccess;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Forms.UserdashBoard.AdminDashboard
{
    public partial class NotificationForm : Form
    {
        private List<NotificationSummary> allNotifications = new List<NotificationSummary>();

        public NotificationForm()
        {
            InitializeComponent();
            SetupGrids();
            cmbFilter.SelectedIndex = 0; // Set to "All"
            cmbFilter.SelectedIndexChanged += CmbFilter_SelectedIndexChanged;
            gridNotifications.SelectionChanged += GridNotifications_SelectionChanged;
        }

        private void SetupGrids()
        {
            // Setup master grid
            gridNotifications.AutoGenerateColumns = true;
            gridNotifications.Columns.Clear();

            gridNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Type",
                DataPropertyName = "NotificationType",
                Width = 150
            });
            gridNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "UserName",
                Width = 200
            });
            gridNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "NIC",
                DataPropertyName = "NIC",
                Width = 150
            });
            gridNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                Width = 120
            });
            gridNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date Submitted",
                DataPropertyName = "DateSubmitted",
                Width = 150
            });
            gridNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "RequestID",
                Visible = false
            });

            // Setup details grid - allow auto-generation for DataTable
            gridNotificationDetails.AutoGenerateColumns = true;
            gridNotificationDetails.AllowUserToAddRows = false;
            gridNotificationDetails.ReadOnly = true;
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            try
            {
                allNotifications.Clear();

                // Load Inquiries
                LoadInquiries();

                // Load Police Report Requests
                LoadPoliceReports();

                // Load Firearm Permissions
                LoadFirearmRequests();

                // Apply current filter
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notifications: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInquiries()
        {
            string query = @"SELECT InquiryID, Name, NIC, status, date_submitted 
                           FROM Inquiries ORDER BY date_submitted DESC";

            using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    allNotifications.Add(new NotificationSummary
                    {
                        RequestID = reader.GetInt32(0),
                        NotificationType = "Inquiry",
                        UserName = reader.GetString(1),
                        NIC = reader.GetString(2),
                        Status = reader.IsDBNull(3) ? "Pending" : reader.GetString(3),
                        DateSubmitted = reader.GetDateTime(4)
                    });
                }
            }
        }

        private void LoadPoliceReports()
        {
            string query = @"SELECT RequestID, FullName, NIC, status, RequestDate 
                           FROM PoliceReportRequests ORDER BY RequestDate DESC";

            using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    allNotifications.Add(new NotificationSummary
                    {
                        RequestID = reader.GetInt32(0),
                        NotificationType = "Police Report",
                        UserName = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        NIC = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Status = reader.IsDBNull(3) ? "Pending" : reader.GetString(3),
                        DateSubmitted = reader.GetDateTime(4)
                    });
                }
            }
        }

        private void LoadFirearmRequests()
        {
            string query = @"SELECT RequestID, FullName, NIC, status, request_date 
                           FROM FirearmPermissions ORDER BY request_date DESC";

            using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    allNotifications.Add(new NotificationSummary
                    {
                        RequestID = reader.GetInt32(0),
                        NotificationType = "Firearm Request",
                        UserName = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        NIC = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Status = reader.IsDBNull(3) ? "Pending" : reader.GetString(3),
                        DateSubmitted = reader.GetDateTime(4)
                    });
                }
            }
        }

        private void ApplyFilter()
        {
            string filter = cmbFilter.SelectedItem?.ToString() ?? "All";

            if (filter == "All")
            {
                gridNotifications.DataSource = allNotifications.ToList();
            }
            else
            {
                string filterType = filter == "Inquiry" ? "Inquiry" :
                                  filter == "Firearm Request" ? "Firearm Request" :
                                  "Police Report";

                var filtered = allNotifications.Where(n => n.NotificationType == filterType).ToList();
                gridNotifications.DataSource = filtered;
            }

            if (gridNotifications.Rows.Count > 0)
            {
                gridNotifications.Rows[0].Selected = true;
            }
            else
            {
                gridNotificationDetails.DataSource = null;
            }
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void GridNotifications_SelectionChanged(object sender, EventArgs e)
        {
            if (gridNotifications.SelectedRows.Count > 0)
            {
                var selectedRow = gridNotifications.SelectedRows[0];
                var notification = selectedRow.DataBoundItem as NotificationSummary;

                if (notification != null)
                {
                    LoadNotificationDetails(notification);
                }
            }
        }

        private void LoadNotificationDetails(NotificationSummary notification)
        {
            try
            {
                DataTable details = new DataTable();

                switch (notification.NotificationType)
                {
                    case "Inquiry":
                        details = LoadInquiryDetails(notification.RequestID);
                        break;
                    case "Police Report":
                        details = LoadPoliceReportDetails(notification.RequestID);
                        break;
                    case "Firearm Request":
                        details = LoadFirearmRequestDetails(notification.RequestID);
                        break;
                }

                // Check if we got data
                if (details != null && details.Rows.Count > 0)
                {
                    gridNotificationDetails.DataSource = details;

                    // Auto-size columns for better readability
                    gridNotificationDetails.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    // Make the Value column fill remaining space
                    if (gridNotificationDetails.Columns.Count > 1)
                    {
                        gridNotificationDetails.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                else
                {
                    MessageBox.Show("No details found for this notification.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading details: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable LoadInquiryDetails(int inquiryId)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT 
                'Inquiry ID' AS Field, CAST(InquiryID AS NVARCHAR) AS Value
                FROM Inquiries WHERE InquiryID = @ID
                UNION ALL
                SELECT 'Name', Name FROM Inquiries WHERE InquiryID = @ID
                UNION ALL
                SELECT 'NIC', NIC FROM Inquiries WHERE InquiryID = @ID
                UNION ALL
                SELECT 'Address', Address FROM Inquiries WHERE InquiryID = @ID
                UNION ALL
                SELECT 'Inquiry Text', InquiryText FROM Inquiries WHERE InquiryID = @ID
                UNION ALL
                SELECT 'Status', ISNULL(status, 'Pending') FROM Inquiries WHERE InquiryID = @ID
                UNION ALL
                SELECT 'Date Submitted', CONVERT(NVARCHAR, date_submitted, 120) FROM Inquiries WHERE InquiryID = @ID
                UNION ALL
                SELECT 'Response', ISNULL(response, 'No response yet') FROM Inquiries WHERE InquiryID = @ID
                UNION ALL
                SELECT 'Date Responded', ISNULL(CONVERT(NVARCHAR, date_responded, 120), 'N/A') FROM Inquiries WHERE InquiryID = @ID";

            using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", inquiryId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        private DataTable LoadPoliceReportDetails(int requestId)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT 
                'Request ID' AS Field, CAST(RequestID AS NVARCHAR) AS Value
                FROM PoliceReportRequests WHERE RequestID = @ID
                UNION ALL
                SELECT 'Full Name', ISNULL(FullName, '') FROM PoliceReportRequests WHERE RequestID = @ID
                UNION ALL
                SELECT 'NIC', ISNULL(NIC, '') FROM PoliceReportRequests WHERE RequestID = @ID
                UNION ALL
                SELECT 'Address', ISNULL(Address, '') FROM PoliceReportRequests WHERE RequestID = @ID
                UNION ALL
                SELECT 'Position', ISNULL(Position, '') FROM PoliceReportRequests WHERE RequestID = @ID
                UNION ALL
                SELECT 'Email', ISNULL(Email, '') FROM PoliceReportRequests WHERE RequestID = @ID
                UNION ALL
                SELECT 'Reason', ISNULL(Reason, '') FROM PoliceReportRequests WHERE RequestID = @ID
                UNION ALL
                SELECT 'Status', ISNULL(status, 'Pending') FROM PoliceReportRequests WHERE RequestID = @ID
                UNION ALL
                SELECT 'Request Date', CONVERT(NVARCHAR, RequestDate, 120) FROM PoliceReportRequests WHERE RequestID = @ID
                UNION ALL
                SELECT 'Response', ISNULL(response, 'No response yet') FROM PoliceReportRequests WHERE RequestID = @ID
                UNION ALL
                SELECT 'Date Completed', ISNULL(CONVERT(NVARCHAR, date_completed, 120), 'N/A') FROM PoliceReportRequests WHERE RequestID = @ID";

            using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", requestId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        private DataTable LoadFirearmRequestDetails(int requestId)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT 
                'Request ID' AS Field, CAST(RequestID AS NVARCHAR) AS Value
                FROM FirearmPermissions WHERE RequestID = @ID
                UNION ALL
                SELECT 'Full Name', ISNULL(FullName, '') FROM FirearmPermissions WHERE RequestID = @ID
                UNION ALL
                SELECT 'NIC', ISNULL(NIC, '') FROM FirearmPermissions WHERE RequestID = @ID
                UNION ALL
                SELECT 'Address', ISNULL(Address, '') FROM FirearmPermissions WHERE RequestID = @ID
                UNION ALL
                SELECT 'Firearm Type', ISNULL(FirearmType, '') FROM FirearmPermissions WHERE RequestID = @ID
                UNION ALL
                SELECT 'Request Reason', ISNULL(RequestReason, '') FROM FirearmPermissions WHERE RequestID = @ID
                UNION ALL
                SELECT 'Status', ISNULL(status, 'Pending') FROM FirearmPermissions WHERE RequestID = @ID
                UNION ALL
                SELECT 'Request Date', CONVERT(NVARCHAR, request_date, 120) FROM FirearmPermissions WHERE RequestID = @ID
                UNION ALL
                SELECT 'Response', ISNULL(response, 'No response yet') FROM FirearmPermissions WHERE RequestID = @ID
                UNION ALL
                SELECT 'Date Processed', ISNULL(CONVERT(NVARCHAR, date_processed, 120), 'N/A') FROM FirearmPermissions WHERE RequestID = @ID
                UNION ALL
                SELECT 'Expiry Date', ISNULL(CONVERT(NVARCHAR, expiry_date, 120), 'N/A') FROM FirearmPermissions WHERE RequestID = @ID";

            using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", requestId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNotifications();
            MessageBox.Show("Notifications refreshed successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NotificationForm_Load_1(object sender, EventArgs e)
        {
            LoadNotifications();
        }
<<<<<<< HEAD

        private void label2_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
    }

    // Helper class for notification summary
    public class NotificationSummary
    {
        public int RequestID { get; set; }
        public string NotificationType { get; set; }
        public string UserName { get; set; }
        public string NIC { get; set; }
        public string Status { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}