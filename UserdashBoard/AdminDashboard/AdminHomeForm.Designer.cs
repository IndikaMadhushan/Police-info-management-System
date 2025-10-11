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
            panel1.BackColor = Color.RoyalBlue;
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
            panel1.Size = new Size(270, 700);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(12, 12);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(241, 52);
            btnProfile.TabIndex = 7;
            btnProfile.Text = "PROFILE";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // buttonchangepwd
            // 
            buttonchangepwd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonchangepwd.Location = new Point(9, 474);
            buttonchangepwd.Name = "buttonchangepwd";
            buttonchangepwd.Size = new Size(241, 52);
            buttonchangepwd.TabIndex = 6;
            buttonchangepwd.Text = "CHANGE PASSWORD";
            buttonchangepwd.UseVisualStyleBackColor = true;
            buttonchangepwd.Click += buttonchangepwd_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Red;
            buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogout.ForeColor = SystemColors.ControlText;
            buttonLogout.Location = new Point(12, 633);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(241, 52);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "LOG OUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHistory.Location = new Point(12, 318);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(241, 52);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "USER HISTORY";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnNotification
            // 
            btnNotification.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNotification.Location = new Point(9, 398);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(244, 52);
            btnNotification.TabIndex = 3;
            btnNotification.Text = "NOTIFICATION";
            btnNotification.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(12, 166);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(241, 52);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "UPDATE DETAILS";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFautls
            // 
            btnFautls.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFautls.Location = new Point(12, 242);
            btnFautls.Name = "btnFautls";
            btnFautls.Size = new Size(241, 52);
            btnFautls.TabIndex = 1;
            btnFautls.Text = "RECORD FAULTS";
            btnFautls.UseVisualStyleBackColor = true;
            btnFautls.Click += btnFautls_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(12, 91);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(241, 52);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += buttonHome_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(276, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1345, 698);
            panel2.TabIndex = 2;
            // 
            // AdminHomeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1617, 698);
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