using Org.BouncyCastle.Asn1.Crmf;
//using static System.Net.Mime.MediaTypeNames;
using System.Drawing;


namespace Forms.UserdashBoard.UserDashboard
{
    partial class BountyPaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblHeader = new Label();
            panelMain = new Panel();
            dgvBounties = new DataGridView();
            lblBounties = new Label();
            btnRefresh = new Button();
            panelDetails = new Panel();
            lblDetailsHeader = new Label();
            lblBountyID = new Label();
            txtBountyID = new TextBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            lblTransaction = new Label();
            txtTransactionID = new TextBox();
            btnPay = new Button();
            lblStatus = new Label();
            lblFaultID = new Label();
            txtFaultID = new TextBox();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBounties).BeginInit();
            panelDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.RoyalBlue;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1215, 63);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(22, 16);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(360, 37);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "💰 Bounty Payment Portal";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Controls.Add(dgvBounties);
            panelMain.Controls.Add(lblBounties);
            panelMain.Controls.Add(btnRefresh);
            panelMain.Controls.Add(panelDetails);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 63);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1215, 588);
            panelMain.TabIndex = 1;
            // 
            // dgvBounties
            // 
            dgvBounties.AllowUserToAddRows = false;
            dgvBounties.AllowUserToDeleteRows = false;
            dgvBounties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBounties.BackgroundColor = Color.White;
            dgvBounties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBounties.Location = new Point(34, 84);
            dgvBounties.MultiSelect = false;
            dgvBounties.Name = "dgvBounties";
            dgvBounties.ReadOnly = true;
            dgvBounties.RowHeadersVisible = false;
            dgvBounties.RowHeadersWidth = 51;
            dgvBounties.RowTemplate.Height = 29;
            dgvBounties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBounties.Size = new Size(675, 420);
            dgvBounties.TabIndex = 3;
            dgvBounties.CellClick += dgvBounties_CellClick;
            // 
            // lblBounties
            // 
            lblBounties.AutoSize = true;
            lblBounties.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBounties.Location = new Point(34, 42);
            lblBounties.Name = "lblBounties";
            lblBounties.Size = new Size(142, 25);
            lblBounties.TabIndex = 2;
            lblBounties.Text = "Your Bounties:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(574, 31);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(135, 37);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh 🔄";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelDetails
            // 
            panelDetails.BackColor = Color.White;
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Controls.Add(lblDetailsHeader);
            panelDetails.Controls.Add(lblBountyID);
            panelDetails.Controls.Add(txtBountyID);
            panelDetails.Controls.Add(lblAmount);
            panelDetails.Controls.Add(txtAmount);
            panelDetails.Controls.Add(lblMethod);
            panelDetails.Controls.Add(cmbPaymentMethod);
            panelDetails.Controls.Add(lblTransaction);
            panelDetails.Controls.Add(txtTransactionID);
            panelDetails.Controls.Add(btnPay);
            panelDetails.Controls.Add(lblStatus);
            panelDetails.Controls.Add(lblFaultID);
            panelDetails.Controls.Add(txtFaultID);
            panelDetails.Location = new Point(742, 84);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(427, 420);
            panelDetails.TabIndex = 0;
            // 
            // lblDetailsHeader
            // 
            lblDetailsHeader.AutoSize = true;
            lblDetailsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetailsHeader.Location = new Point(22, 16);
            lblDetailsHeader.Name = "lblDetailsHeader";
            lblDetailsHeader.Size = new Size(167, 28);
            lblDetailsHeader.TabIndex = 0;
            lblDetailsHeader.Text = "Payment Details";
            // 
            // lblBountyID
            // 
            lblBountyID.AutoSize = true;
            lblBountyID.Location = new Point(22, 74);
            lblBountyID.Name = "lblBountyID";
            lblBountyID.Size = new Size(81, 21);
            lblBountyID.TabIndex = 1;
            lblBountyID.Text = "Bounty ID:";
            // 
            // txtBountyID
            // 
            txtBountyID.Location = new Point(169, 70);
            txtBountyID.Name = "txtBountyID";
            txtBountyID.ReadOnly = true;
            txtBountyID.Size = new Size(224, 29);
            txtBountyID.TabIndex = 2;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(22, 166);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(69, 21);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(169, 163);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(224, 29);
            txtAmount.TabIndex = 4;
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Location = new Point(22, 209);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(131, 21);
            lblMethod.TabIndex = 5;
            lblMethod.Text = "Payment Method:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Card" });
            cmbPaymentMethod.Location = new Point(169, 205);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(224, 29);
            cmbPaymentMethod.TabIndex = 6;
            // 
            // lblTransaction
            // 
            lblTransaction.AutoSize = true;
            lblTransaction.Location = new Point(22, 250);
            lblTransaction.Name = "lblTransaction";
            lblTransaction.Size = new Size(111, 21);
            lblTransaction.TabIndex = 7;
            lblTransaction.Text = "Transaction ID:";
            // 
            // txtTransactionID
            // 
            txtTransactionID.Location = new Point(169, 247);
            txtTransactionID.Name = "txtTransactionID";
            txtTransactionID.Size = new Size(224, 29);
            txtTransactionID.TabIndex = 8;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.RoyalBlue;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(169, 294);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(135, 42);
            btnPay.TabIndex = 9;
            btnPay.Text = "💳 Pay Now";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.DarkGreen;
            lblStatus.Location = new Point(22, 326);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 21);
            lblStatus.TabIndex = 10;
            // 
            // lblFaultID
            // 
            lblFaultID.AutoSize = true;
            lblFaultID.Location = new Point(22, 119);
            lblFaultID.Name = "lblFaultID";
            lblFaultID.Size = new Size(65, 21);
            lblFaultID.TabIndex = 11;
            lblFaultID.Text = "Fault ID:";
            // 
            // txtFaultID
            // 
            txtFaultID.Location = new Point(169, 116);
            txtFaultID.Name = "txtFaultID";
            txtFaultID.ReadOnly = true;
            txtFaultID.Size = new Size(224, 29);
            txtFaultID.TabIndex = 12;
            // 
            // BountyPaymentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 651);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Name = "BountyPaymentForm";
            Text = "BountyPaymentForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBounties).EndInit();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelMain;
        private DataGridView dgvBounties;
        private Label lblBounties;
        private Button btnRefresh;
        private Panel panelDetails;
        private Label lblDetailsHeader;
        private Label lblBountyID;
        private TextBox txtBountyID;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblMethod;
        private ComboBox cmbPaymentMethod;
        private Label lblTransaction;
        private TextBox txtTransactionID;
        private Button btnPay;
        private Label lblStatus;
        private Label lblFaultID;
        private TextBox txtFaultID;

    }
}
