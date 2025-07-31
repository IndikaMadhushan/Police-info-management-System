namespace Forms.UserdashBoard.AdminDashboard
{
    partial class AdminDashBoard
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
            buttonChange = new Button();
            buttonFireArm = new Button();
            buttonAddFalts = new Button();
            buttonInquaries = new Button();
            buttonRegister = new Button();
            buttonHome = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(buttonChange);
            panel1.Controls.Add(buttonFireArm);
            panel1.Controls.Add(buttonAddFalts);
            panel1.Controls.Add(buttonInquaries);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(buttonHome);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 667);
            panel1.TabIndex = 0;
            // 
            // buttonChange
            // 
            buttonChange.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChange.Location = new Point(11, 431);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(293, 29);
            buttonChange.TabIndex = 5;
            buttonChange.Text = "CHANGE PROFILE DETAILS";
            buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonFireArm
            // 
            buttonFireArm.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFireArm.Location = new Point(11, 355);
            buttonFireArm.Name = "buttonFireArm";
            buttonFireArm.Size = new Size(293, 29);
            buttonFireArm.TabIndex = 4;
            buttonFireArm.Text = "FIREARM PERMISSION";
            buttonFireArm.UseVisualStyleBackColor = true;
            buttonFireArm.Click += buttonFireArm_Click;
            // 
            // buttonAddFalts
            // 
            buttonAddFalts.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddFalts.Location = new Point(11, 285);
            buttonAddFalts.Name = "buttonAddFalts";
            buttonAddFalts.Size = new Size(293, 29);
            buttonAddFalts.TabIndex = 3;
            buttonAddFalts.Text = "ADD FALTS";
            buttonAddFalts.UseVisualStyleBackColor = true;
            // 
            // buttonInquaries
            // 
            buttonInquaries.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInquaries.Location = new Point(11, 217);
            buttonInquaries.Name = "buttonInquaries";
            buttonInquaries.Size = new Size(293, 29);
            buttonInquaries.TabIndex = 2;
            buttonInquaries.Text = "RESPOND INQUARIES";
            buttonInquaries.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.Location = new Point(11, 149);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(293, 29);
            buttonRegister.TabIndex = 1;
            buttonRegister.Text = "CITIZEN REGITRATION";
            buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.Location = new Point(11, 81);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(293, 29);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "HOME";
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 667);
            Controls.Add(panel1);
            Name = "AdminDashBoard";
            Text = "AdminDashboardForm";
            Load += AdminHomeForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRegister;
        private Button buttonHome;
        private Button buttonInquaries;
        private Button buttonAddFalts;
        private Button buttonChange;
        private Button buttonFireArm;
    }
}