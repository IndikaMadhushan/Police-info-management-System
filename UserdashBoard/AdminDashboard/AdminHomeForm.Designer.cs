namespace Forms.UserdashBoard.AdminDashboard
{
    partial class AdminHomeForm
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
            btnProfile = new Button();
            buttonchangepwd = new Button();
            buttonLogout = new Button();
            btnHistory = new Button();
            btnNotification = new Button();
            btnUpdate = new Button();
            btnFautls = new Button();
            btnRegister = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(buttonchangepwd);
            panel1.Controls.Add(buttonLogout);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnNotification);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnFautls);
            panel1.Controls.Add(btnRegister);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";

            panel1.Size = new Size(240, 667);

            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);

            btnProfile.Location = new Point(11, 11);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(214, 50);

            btnProfile.TabIndex = 7;
            btnProfile.Text = "PROFILE";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // buttonchangepwd
            // 
            buttonchangepwd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonchangepwd.Location = new Point(11, 506);
            buttonchangepwd.Name = "buttonchangepwd";
            buttonchangepwd.Size = new Size(214, 50);

            buttonchangepwd.TabIndex = 6;
            buttonchangepwd.Text = "CHANGE PASSWORD";
            buttonchangepwd.UseVisualStyleBackColor = true;
            buttonchangepwd.Click += buttonchangepwd_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.White;
            buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogout.ForeColor = SystemColors.ControlText;
            buttonLogout.Location = new Point(11, 594);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(214, 50);

            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "LOG OUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHistory.Location = new Point(11, 328);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(214, 50);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "USER HISTORY";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnNotification
            // 
            btnNotification.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            btnNotification.Location = new Point(11, 415);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(217, 50);
            btnNotification.TabIndex = 3;
            btnNotification.Text = "NOTIFICATION";
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            btnUpdate.Location = new Point(11, 163);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(214, 50);

            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "UPDATE DETAILS";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFautls
            // 
            btnFautls.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFautls.Location = new Point(11, 242);
            btnFautls.Name = "btnFautls";
            btnFautls.Size = new Size(214, 50);
            btnFautls.TabIndex = 1;
            btnFautls.Text = "RECORD FAULTS";
            btnFautls.UseVisualStyleBackColor = true;
            btnFautls.Click += btnFautls_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(11, 85);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(214, 50);

            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += buttonHome_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.userimage;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(245, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1196, 665);

            panel2.TabIndex = 2;
            // 
            // AdminHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 665);

            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminHomeForm";
            Text = "AdminHomeForm";
            Load += AdminHomeForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonchangepwd;
        private Button buttonLogout;
        private Button btnHistory;
        private Button btnNotification;
        private Button btnUpdate;
        private Button btnFautls;
        private Button btnRegister;
        private Panel panel2;
        private Button btnProfile;
    }
}