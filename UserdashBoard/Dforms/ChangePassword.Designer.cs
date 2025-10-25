
namespace Forms.UserdashBoard.Dforms
{
    partial class ChangePassword
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
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 145);
            label1.Name = "label1";
            label1.Size = new Size(155, 24);
            label1.TabIndex = 0;
            label1.Text = "Current Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 145);
            label2.Name = "label2";
            label2.Size = new Size(14, 24);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(432, 264);
            label5.Name = "label5";
            label5.Size = new Size(14, 24);
            label5.TabIndex = 5;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(246, 264);
            label6.Name = "label6";
            label6.Size = new Size(129, 24);
            label6.TabIndex = 4;
            label6.Text = "New Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(521, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(521, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(392, 27);
            textBox3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(246, 386);
            label7.Name = "label7";
            label7.Size = new Size(163, 24);
            label7.TabIndex = 2;
            label7.Text = " Confirm Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(432, 386);
            label8.Name = "label8";
            label8.Size = new Size(14, 24);
            label8.TabIndex = 3;
            label8.Text = ":";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(521, 383);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(392, 27);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(779, 483);
            button1.Name = "button1";
            button1.Size = new Size(134, 38);
            button1.TabIndex = 9;
            button1.Text = "CONFIRM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(128, 128, 255);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = SystemColors.ActiveCaptionText;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1170, 60);
            panelHeader.TabIndex = 10;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Black;
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(242, 37);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Change Password";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1170, 600);
            Controls.Add(panelHeader);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private Button button1;
        private Panel panelHeader;
        private Label lblHeader;
    }
}