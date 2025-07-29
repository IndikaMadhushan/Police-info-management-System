namespace Forms.UserdashBoard
{
    partial class Userdashboard
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
            panel1 = new Panel();
            buttonLogout = new Button();
            buttonInquiries = new Button();
            buttonFirearm = new Button();
            buttonPay = new Button();
            buttonReport = new Button();
            buttonHome = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(buttonLogout);
            panel1.Controls.Add(buttonInquiries);
            panel1.Controls.Add(buttonFirearm);
            panel1.Controls.Add(buttonPay);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonHome);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 667);
            panel1.TabIndex = 0;
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogout.Location = new Point(3, 584);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(310, 50);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "LOG OUT";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonInquiries
            // 
            buttonInquiries.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonInquiries.Location = new Point(3, 354);
            buttonInquiries.Name = "buttonInquiries";
            buttonInquiries.Size = new Size(310, 50);
            buttonInquiries.TabIndex = 4;
            buttonInquiries.Text = "PLACE INQUIRIES";
            buttonInquiries.UseVisualStyleBackColor = true;
            buttonInquiries.Click += buttonInquiries_Click;
            // 
            // buttonFirearm
            // 
            buttonFirearm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonFirearm.Location = new Point(3, 467);
            buttonFirearm.Name = "buttonFirearm";
            buttonFirearm.Size = new Size(310, 50);
            buttonFirearm.TabIndex = 3;
            buttonFirearm.Text = "REQUEST FIREARM PERMISSION";
            buttonFirearm.UseVisualStyleBackColor = true;
            buttonFirearm.Click += buttonFirearm_Click;
            // 
            // buttonPay
            // 
            buttonPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPay.Location = new Point(3, 139);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(310, 50);
            buttonPay.TabIndex = 2;
            buttonPay.Text = "PAY BOUNTY FEE";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // buttonReport
            // 
            buttonReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReport.Location = new Point(3, 246);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(310, 50);
            buttonReport.TabIndex = 1;
            buttonReport.Text = "REQUEST POLLICE REPORT";
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(3, 28);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(310, 50);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "HOME";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(320, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(890, 665);
            panel2.TabIndex = 1;
            // 
            // Userdashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 667);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Userdashboard";
            Text = "DashBoard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonLogout;
        private Button buttonInquiries;
        private Button buttonFirearm;
        private Button buttonPay;
        private Button buttonReport;
        private Button buttonHome;
        private Panel panel2;
    }
}