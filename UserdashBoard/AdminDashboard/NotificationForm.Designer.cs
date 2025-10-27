namespace Forms.UserdashBoard.AdminDashboard
{
    partial class NotificationForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private DataGridView gridNotifications;
        private DataGridView gridNotificationDetails;
        private Label labelMaster;

        private Label labelDetails;

        private ComboBox cmbFilter;
        private Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();

            labelMaster = new Label();
            cmbFilter = new ComboBox();
            btnRefresh = new Button();
            gridNotifications = new DataGridView();

            gridNotificationDetails = new DataGridView();
            panelHeader = new Panel();
            lblHeader = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridNotifications).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridNotificationDetails).BeginInit();
            panelHeader.SuspendLayout();

            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(panelHeader);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);

            panel1.Controls.Add(labelMaster);
            panel1.Controls.Add(cmbFilter);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(gridNotifications);

            panel1.Controls.Add(gridNotificationDetails);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1196, 663);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(201, 331);
            label2.Name = "label2";
            label2.Size = new Size(17, 25);
            label2.TabIndex = 8;
            label2.Text = ":";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 331);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 7;
            label3.Text = "Notification Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(146, 84);
            label1.Name = "label1";
            label1.Size = new Size(17, 25);
            label1.TabIndex = 6;
            label1.Text = ":";
            // 
            // labelMaster
            // 
            labelMaster.AutoSize = true;
            labelMaster.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMaster.ForeColor = Color.Black;
            labelMaster.Location = new Point(18, 84);
            labelMaster.Name = "labelMaster";
            labelMaster.Size = new Size(122, 25);

            labelMaster.TabIndex = 0;
            labelMaster.Text = "Notifications";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.AddRange(new object[] { "All", "Inquiry", "Firearm Request", "Report Request" });
            cmbFilter.Location = new Point(189, 85);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(234, 28);

            cmbFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(440, 82);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(89, 31);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;

            btnRefresh.Click += btnRefresh_Click;
            // 
            // gridNotifications
            // 
            gridNotifications.BackgroundColor = SystemColors.ButtonHighlight;
            gridNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridNotifications.Location = new Point(18, 123);

            gridNotifications.Name = "gridNotifications";
            gridNotifications.ReadOnly = true;
            gridNotifications.RowHeadersWidth = 51;
            gridNotifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridNotifications.Size = new Size(1156, 179);
            gridNotifications.TabIndex = 3;
            // 
            // gridNotificationDetails
            // 
            gridNotificationDetails.BackgroundColor = SystemColors.ButtonHighlight;
            gridNotificationDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridNotificationDetails.Location = new Point(18, 369);
            gridNotificationDetails.Name = "gridNotificationDetails";
            gridNotificationDetails.ReadOnly = true;
            gridNotificationDetails.RowHeadersWidth = 51;
            gridNotificationDetails.Size = new Size(1156, 282);
            gridNotificationDetails.TabIndex = 5;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(128, 128, 255);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = SystemColors.ActiveCaptionText;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1196, 60);
            panelHeader.TabIndex = 9;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Black;
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(172, 37);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Notification";
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 665);

            Controls.Add(panel1);
            Name = "NotificationForm";
            Text = "NotificationForm";
            Load += NotificationForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridNotifications).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridNotificationDetails).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panelHeader;
        private Label lblHeader;

    }
}
