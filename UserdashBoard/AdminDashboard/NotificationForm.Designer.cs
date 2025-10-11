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
            labelMaster = new Label();
            cmbFilter = new ComboBox();
            btnRefresh = new Button();
            gridNotifications = new DataGridView();
            labelDetails = new Label();
            gridNotificationDetails = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridNotifications).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridNotificationDetails).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(labelMaster);
            panel1.Controls.Add(cmbFilter);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(gridNotifications);
            panel1.Controls.Add(labelDetails);
            panel1.Controls.Add(gridNotificationDetails);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1345, 696);
            panel1.TabIndex = 0;
            // 
            // labelMaster
            // 
            labelMaster.AutoSize = true;
            labelMaster.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelMaster.ForeColor = Color.White;
            labelMaster.Location = new Point(20, 20);
            labelMaster.Name = "labelMaster";
            labelMaster.Size = new Size(162, 32);
            labelMaster.TabIndex = 0;
            labelMaster.Text = "Notifications";
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.AddRange(new object[] { "All", "Inquiry", "Firearm Request", "Report Request" });
            cmbFilter.Location = new Point(180, 20);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(150, 29);
            cmbFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(350, 20);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 28);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // gridNotifications
            // 
            gridNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridNotifications.Location = new Point(20, 60);
            gridNotifications.Name = "gridNotifications";
            gridNotifications.ReadOnly = true;
            gridNotifications.RowHeadersWidth = 51;
            gridNotifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridNotifications.Size = new Size(1300, 188);
            gridNotifications.TabIndex = 3;
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelDetails.ForeColor = Color.White;
            labelDetails.Location = new Point(20, 266);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(236, 32);
            labelDetails.TabIndex = 4;
            labelDetails.Text = "Notification Details";
            // 
            // gridNotificationDetails
            // 
            gridNotificationDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridNotificationDetails.Location = new Point(20, 313);
            gridNotificationDetails.Name = "gridNotificationDetails";
            gridNotificationDetails.ReadOnly = true;
            gridNotificationDetails.RowHeadersWidth = 51;
            gridNotificationDetails.Size = new Size(1300, 371);
            gridNotificationDetails.TabIndex = 5;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 698);
            Controls.Add(panel1);
            Name = "NotificationForm";
            Text = "NotificationForm";
            Load += NotificationForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridNotifications).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridNotificationDetails).EndInit();
            ResumeLayout(false);
        }
    }
}
