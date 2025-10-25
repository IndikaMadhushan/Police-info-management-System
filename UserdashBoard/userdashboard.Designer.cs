
namespace Forms.UserdashBoard
{
    partial class userdashboard
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
            buttonchangepwd = new Button();
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
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(buttonchangepwd);
            panel1.Controls.Add(buttonLogout);
            panel1.Controls.Add(buttonInquiries);
            panel1.Controls.Add(buttonFirearm);
            panel1.Controls.Add(buttonPay);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonHome);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
<<<<<<< HEAD
            panel1.Size = new Size(283, 667);
=======
            panel1.Size = new Size(318, 700);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonchangepwd
            // 
            buttonchangepwd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonchangepwd.Location = new Point(12, 495);
            buttonchangepwd.Name = "buttonchangepwd";
<<<<<<< HEAD
            buttonchangepwd.Size = new Size(255, 50);
=======
            buttonchangepwd.Size = new Size(287, 52);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            buttonchangepwd.TabIndex = 6;
            buttonchangepwd.Text = "CHANGE PASSWORD";
            buttonchangepwd.UseVisualStyleBackColor = true;
            buttonchangepwd.Click += buttonchangepwd_Click;
            // 
            // buttonLogout
            // 
<<<<<<< HEAD
            buttonLogout.BackColor = Color.White;
            buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogout.ForeColor = SystemColors.ControlText;
            buttonLogout.Location = new Point(11, 570);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(255, 50);
=======
            buttonLogout.BackColor = Color.Red;
            buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogout.ForeColor = SystemColors.ControlText;
            buttonLogout.Location = new Point(12, 633);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(287, 52);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "LOG OUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonInquiries
            // 
            buttonInquiries.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonInquiries.Location = new Point(12, 301);
            buttonInquiries.Name = "buttonInquiries";
<<<<<<< HEAD
            buttonInquiries.Size = new Size(255, 50);
=======
            buttonInquiries.Size = new Size(287, 52);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            buttonInquiries.TabIndex = 4;
            buttonInquiries.Text = "PLACE INQUIRIES";
            buttonInquiries.UseVisualStyleBackColor = true;
            buttonInquiries.Click += buttonInquiries_Click;
            // 
            // buttonFirearm
            // 
            buttonFirearm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonFirearm.Location = new Point(12, 399);
            buttonFirearm.Name = "buttonFirearm";
<<<<<<< HEAD
            buttonFirearm.Size = new Size(255, 50);
=======
            buttonFirearm.Size = new Size(287, 52);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            buttonFirearm.TabIndex = 3;
            buttonFirearm.Text = "REQUEST FIREARM PERMISSION";
            buttonFirearm.UseVisualStyleBackColor = true;
            buttonFirearm.Click += buttonFirearm_Click;
            // 
            // buttonPay
            // 
            buttonPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonPay.Location = new Point(12, 113);
            buttonPay.Name = "buttonPay";
<<<<<<< HEAD
            buttonPay.Size = new Size(255, 50);
=======
            buttonPay.Size = new Size(287, 52);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            buttonPay.TabIndex = 2;
            buttonPay.Text = "PAY BOUNTY FEE";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // buttonReport
            // 
            buttonReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReport.Location = new Point(12, 208);
            buttonReport.Name = "buttonReport";
<<<<<<< HEAD
            buttonReport.Size = new Size(255, 50);
=======
            buttonReport.Size = new Size(287, 52);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            buttonReport.TabIndex = 1;
            buttonReport.Text = "REQUEST POLLICE REPORT";
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(12, 29);
            buttonHome.Name = "buttonHome";
<<<<<<< HEAD
            buttonHome.Size = new Size(255, 50);
=======
            buttonHome.Size = new Size(287, 52);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            buttonHome.TabIndex = 0;
            buttonHome.Text = "PROFILE";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // panel2
            // 
<<<<<<< HEAD
            panel2.BackgroundImage = Properties.Resources.userimage;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(289, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1151, 665);
=======
            panel2.Location = new Point(325, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1295, 698);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            panel2.TabIndex = 1;
            // 
            // userdashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1437, 665);
=======
            ClientSize = new Size(1617, 698);
>>>>>>> 5f8a7de4a9b66f0f8425ae0faa07ffca445e934e
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "userdashboard";
            Text = "DashBoard";
            Load += UserDashboard_Load_1;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void UserDashboard_Load_1(object sender, EventArgs e)
        {
           
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
        private Button buttonchangepwd;
    }
}