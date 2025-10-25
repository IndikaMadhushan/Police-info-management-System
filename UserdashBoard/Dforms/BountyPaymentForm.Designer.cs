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
<<<<<<< HEAD
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
=======
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBounties).BeginInit();
            panelDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
<<<<<<< HEAD
            panelHeader.BackColor = Color.FromArgb(128, 128, 255);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = SystemColors.ActiveCaptionText;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1080, 60);
=======
            panelHeader.BackColor = Color.RoyalBlue;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1215, 63);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
<<<<<<< HEAD
            lblHeader.ForeColor = Color.Black;
            lblHeader.Location = new Point(20, 15);
=======
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(22, 16);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(360, 37);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "💰 Bounty Payment Portal";
            // 
            // panelMain
            // 
<<<<<<< HEAD
            panelMain.BackColor = Color.FromArgb(192, 192, 255);
            panelMain.Controls.Add(lblDetailsHeader);
=======
            panelMain.BackColor = Color.WhiteSmoke;
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            panelMain.Controls.Add(dgvBounties);
            panelMain.Controls.Add(lblBounties);
            panelMain.Controls.Add(btnRefresh);
            panelMain.Controls.Add(panelDetails);
            panelMain.Dock = DockStyle.Fill;
<<<<<<< HEAD
            panelMain.Location = new Point(0, 60);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1080, 560);
=======
            panelMain.Location = new Point(0, 63);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1215, 588);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            panelMain.TabIndex = 1;
            // 
            // dgvBounties
            // 
            dgvBounties.AllowUserToAddRows = false;
            dgvBounties.AllowUserToDeleteRows = false;
            dgvBounties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBounties.BackgroundColor = Color.White;
            dgvBounties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            dgvBounties.Location = new Point(30, 80);
=======
            dgvBounties.Location = new Point(34, 84);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            dgvBounties.MultiSelect = false;
            dgvBounties.Name = "dgvBounties";
            dgvBounties.ReadOnly = true;
            dgvBounties.RowHeadersVisible = false;
            dgvBounties.RowHeadersWidth = 51;
<<<<<<< HEAD
            dgvBounties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBounties.Size = new Size(544, 400);
=======
            dgvBounties.RowTemplate.Height = 29;
            dgvBounties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBounties.Size = new Size(675, 420);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            dgvBounties.TabIndex = 3;
            dgvBounties.CellClick += dgvBounties_CellClick;
            // 
            // lblBounties
            // 
            lblBounties.AutoSize = true;
<<<<<<< HEAD
            lblBounties.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBounties.Location = new Point(30, 40);
            lblBounties.Name = "lblBounties";
            lblBounties.Size = new Size(135, 25);
=======
            lblBounties.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBounties.Location = new Point(34, 42);
            lblBounties.Name = "lblBounties";
            lblBounties.Size = new Size(142, 25);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            lblBounties.TabIndex = 2;
            lblBounties.Text = "Your Bounties:";
            // 
            // btnRefresh
            // 
<<<<<<< HEAD
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(454, 30);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 35);
=======
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(574, 31);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(135, 37);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh 🔄";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelDetails
            // 
            panelDetails.BackColor = Color.White;
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
<<<<<<< HEAD
            panelDetails.Controls.Add(label5);
            panelDetails.Controls.Add(label4);
            panelDetails.Controls.Add(label3);
            panelDetails.Controls.Add(label2);
            panelDetails.Controls.Add(label1);
=======
            panelDetails.Controls.Add(lblDetailsHeader);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
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
<<<<<<< HEAD
            panelDetails.Location = new Point(615, 80);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(425, 400);
=======
            panelDetails.Location = new Point(742, 84);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(427, 420);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            panelDetails.TabIndex = 0;
            // 
            // lblDetailsHeader
            // 
            lblDetailsHeader.AutoSize = true;
            lblDetailsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
<<<<<<< HEAD
            lblDetailsHeader.Location = new Point(615, 37);
            lblDetailsHeader.Name = "lblDetailsHeader";
            lblDetailsHeader.Size = new Size(178, 28);
            lblDetailsHeader.TabIndex = 0;
            lblDetailsHeader.Text = "Payment Details :";
=======
            lblDetailsHeader.Location = new Point(22, 16);
            lblDetailsHeader.Name = "lblDetailsHeader";
            lblDetailsHeader.Size = new Size(167, 28);
            lblDetailsHeader.TabIndex = 0;
            lblDetailsHeader.Text = "Payment Details";
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            // 
            // lblBountyID
            // 
            lblBountyID.AutoSize = true;
<<<<<<< HEAD
            lblBountyID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBountyID.Location = new Point(10, 67);
            lblBountyID.Name = "lblBountyID";
            lblBountyID.Size = new Size(80, 20);
            lblBountyID.TabIndex = 1;
            lblBountyID.Text = "Bounty ID";
            // 
            // txtBountyID
            // 
            txtBountyID.Location = new Point(208, 64);
            txtBountyID.Name = "txtBountyID";
            txtBountyID.ReadOnly = true;
            txtBountyID.Size = new Size(200, 27);
=======
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
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            txtBountyID.TabIndex = 2;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
<<<<<<< HEAD
            lblAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAmount.Location = new Point(10, 158);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(67, 20);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(208, 155);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(200, 27);
=======
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
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            txtAmount.TabIndex = 4;
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
<<<<<<< HEAD
            lblMethod.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMethod.Location = new Point(10, 198);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(130, 20);
            lblMethod.TabIndex = 5;
            lblMethod.Text = "Payment Method";
=======
            lblMethod.Location = new Point(22, 209);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(131, 21);
            lblMethod.TabIndex = 5;
            lblMethod.Text = "Payment Method:";
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Card" });
<<<<<<< HEAD
            cmbPaymentMethod.Location = new Point(208, 195);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(200, 28);
=======
            cmbPaymentMethod.Location = new Point(169, 205);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(224, 29);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            cmbPaymentMethod.TabIndex = 6;
            // 
            // lblTransaction
            // 
            lblTransaction.AutoSize = true;
<<<<<<< HEAD
            lblTransaction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTransaction.Location = new Point(10, 238);
            lblTransaction.Name = "lblTransaction";
            lblTransaction.Size = new Size(110, 20);
            lblTransaction.TabIndex = 7;
            lblTransaction.Text = "Transaction ID";
            // 
            // txtTransactionID
            // 
            txtTransactionID.Location = new Point(208, 235);
            txtTransactionID.Name = "txtTransactionID";
            txtTransactionID.Size = new Size(200, 27);
=======
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
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            txtTransactionID.TabIndex = 8;
            // 
            // btnPay
            // 
<<<<<<< HEAD
            btnPay.BackColor = Color.FromArgb(192, 192, 255);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPay.ForeColor = Color.Black;
            btnPay.Location = new Point(150, 310);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(120, 40);
=======
            btnPay.BackColor = Color.RoyalBlue;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(169, 294);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(135, 42);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            btnPay.TabIndex = 9;
            btnPay.Text = "💳 Pay Now";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.DarkGreen;
<<<<<<< HEAD
            lblStatus.Location = new Point(20, 310);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
=======
            lblStatus.Location = new Point(22, 326);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 21);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            lblStatus.TabIndex = 10;
            // 
            // lblFaultID
            // 
            lblFaultID.AutoSize = true;
<<<<<<< HEAD
            lblFaultID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFaultID.Location = new Point(10, 113);
            lblFaultID.Name = "lblFaultID";
            lblFaultID.Size = new Size(64, 20);
            lblFaultID.TabIndex = 11;
            lblFaultID.Text = "Fault ID";
            // 
            // txtFaultID
            // 
            txtFaultID.Location = new Point(208, 110);
            txtFaultID.Name = "txtFaultID";
            txtFaultID.ReadOnly = true;
            txtFaultID.Size = new Size(200, 27);
            txtFaultID.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(166, 67);
            label1.Name = "label1";
            label1.Size = new Size(13, 20);
            label1.TabIndex = 13;
            label1.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(166, 198);
            label2.Name = "label2";
            label2.Size = new Size(13, 20);
            label2.TabIndex = 14;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(166, 158);
            label3.Name = "label3";
            label3.Size = new Size(13, 20);
            label3.TabIndex = 15;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(166, 113);
            label4.Name = "label4";
            label4.Size = new Size(13, 20);
            label4.TabIndex = 16;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(166, 238);
            label5.Name = "label5";
            label5.Size = new Size(13, 20);
            label5.TabIndex = 17;
            label5.Text = ":";
            // 
            // BountyPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 620);
=======
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
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
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
<<<<<<< HEAD
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
=======

>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
    }
}
