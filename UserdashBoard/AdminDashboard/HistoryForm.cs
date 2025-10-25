using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Forms.DataAccess;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = System.Drawing.Image;
using Font = System.Drawing.Font;


namespace Forms.UserdashBoard.AdminDashboard
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nic = txtNic.Text.Trim();

            if (string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("Please enter a NIC number.");
                return;
            }

            LoadUserHistory(nic);
        }

        private void LoadUserHistory(string nic)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    // ✅ Step 1: Get User Info
                    string userQuery = "SELECT user_id, name, profile_picture FROM Users WHERE NIC = @nic";
                    int userId = -1;
                    string userName = "";

                    using (SqlCommand cmd = new SqlCommand(userQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", nic);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = Convert.ToInt32(reader["user_id"]);
                                userName = reader["name"].ToString();
                                txtName.Text = userName;

                                // Load profile picture if available
                                if (reader["profile_picture"] != DBNull.Value)
                                {
                                    byte[] imgBytes = (byte[])reader["profile_picture"];
                                    using (MemoryStream ms = new MemoryStream(imgBytes))
                                    {
                                        pictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    // Default image
                                    pictureBox1.Image = Image.FromFile(@"Images\default_profile.png");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No user found with the given NIC.");
                                ClearFields();
                                return;
                            }
                        }
                    }

                    // ✅ Step 2: Load Faults
                    string faultQuery = @"SELECT fault_type AS [Type], description AS [Description], 
                                          fine_amount AS [Fine Amount], fault_date AS [Date], status AS [Status]
                                          FROM Faults WHERE user_id = @userId";
                    using (SqlDataAdapter da = new SqlDataAdapter(faultQuery, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@userId", userId);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        gridFault.DataSource = dt;
                        StyleDataGridView(gridFault);
                    }

                    // ✅ Step 3: Load Bounties
                    string bountyQuery = @"SELECT Bounties.bounty_id AS [Bounty ID], 
                                           Bounties.amount AS [Amount], 
                                           Bounties.payment_method AS [Payment Method],
                                           Bounties.date_paid AS [Date Paid], 
                                           Faults.description AS [Related Fault]
                                           FROM Bounties 
                                           INNER JOIN Faults ON Bounties.fault_id = Faults.fault_id
                                           WHERE Bounties.user_id = @userId";
                    using (SqlDataAdapter da = new SqlDataAdapter(bountyQuery, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@userId", userId);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        gridBounty.DataSource = dt;
                        StyleDataGridView(gridBounty);
                    }

                    // ✅ Step 4: Load Inquiries
                    string inquiryQuery = @"SELECT InquiryID AS [Inquiry ID], InquiryText AS [Inquiry], 
                                            Date AS [Inquiry Date], response AS [Response], status AS [Status]
                                            FROM Inquiries WHERE UserID = @userId";
                    using (SqlDataAdapter da = new SqlDataAdapter(inquiryQuery, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@userId", userId);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        gridInquiries.DataSource = dt;
                        StyleDataGridView(gridInquiries);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user history: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            pictureBox1.Image = null;
            gridFault.DataSource = null;
            gridBounty.DataSource = null;
            gridInquiries.DataSource = null;
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            // General appearance
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 167, 191);
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            StyleDataGridView(gridFault);
            StyleDataGridView(gridBounty);
            StyleDataGridView(gridInquiries);
        }



       

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
             try
            {
                if (string.IsNullOrWhiteSpace(txtNic.Text))
                {
                    MessageBox.Show("Please search for a user first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files|*.pdf",
                    Title = "Save User History PDF",
                    FileName = $"{txtName.Text}_History_{DateTime.Now:yyyyMMdd}.pdf"
                };

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                Document doc = new Document(PageSize.A4, 36, 36, 36, 36);
                PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                doc.Open();

                // ✅ Define fonts using iTextSharp only
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLUE);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);

                // ✅ Add Header
                doc.Add(new Paragraph("Police Information Management System", titleFont));
                doc.Add(new Paragraph("User History Report", headerFont));
                doc.Add(new Paragraph($"Generated on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", normalFont));
                doc.Add(new Paragraph("------------------------------------------------------------"));
                doc.Add(new Paragraph("\n"));

                // ✅ Add User Details
                doc.Add(new Paragraph($"NIC: {txtNic.Text}", normalFont));
                doc.Add(new Paragraph($"Name: {txtName.Text}", normalFont));
                doc.Add(new Paragraph("\n"));

                // ✅ Add profile picture (if loaded)
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        iTextSharp.text.Image userImage = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        userImage.ScaleAbsolute(100f, 100f);
                        userImage.Alignment = Element.ALIGN_LEFT;
                        doc.Add(userImage);
                    }
                    doc.Add(new Paragraph("\n"));
                }

                // ✅ Add Fault Table
                doc.Add(new Paragraph("Fault Details", headerFont));
                PdfPTable faultTable = CreatePdfTableFromGrid(gridFault);
                doc.Add(faultTable);
                doc.Add(new Paragraph("\n"));

                // ✅ Add Bounty Table
                doc.Add(new Paragraph("Bounty Details", headerFont));
                PdfPTable bountyTable = CreatePdfTableFromGrid(gridBounty);
                doc.Add(bountyTable);
                doc.Add(new Paragraph("\n"));

                // ✅ Add Inquiry Table
                doc.Add(new Paragraph("Inquiry Details", headerFont));
                PdfPTable inquiryTable = CreatePdfTableFromGrid(gridInquiries);
                doc.Add(inquiryTable);

                doc.Close();
                MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PdfPTable CreatePdfTableFromGrid(DataGridView grid)
        {
            PdfPTable table = new PdfPTable(grid.Columns.Count);
            table.WidthPercentage = 100;

            // Add column headers
            foreach (DataGridViewColumn column in grid.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
            }

            // Add rows
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellText = cell.Value?.ToString() ?? "";
                    table.AddCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 9)));
                }
            }

            return table;
        }

    }
}
