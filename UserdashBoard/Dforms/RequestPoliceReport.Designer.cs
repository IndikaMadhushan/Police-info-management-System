namespace Forms.UserdashBoard.Dforms
{
    partial class RequestPoliceReport
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
            splitContainer1 = new SplitContainer();
            textmail = new TextBox();
            textpossition = new TextBox();
            textaddress = new RichTextBox();
            textnic = new TextBox();
            textname = new RichTextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textreason = new RichTextBox();
            label4 = new Label();
            label8 = new Label();
            panelHeader = new Panel();
            lblHeader = new Label();
            panel1 = new Panel();

            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(192, 192, 255);
            splitContainer1.Panel1.Controls.Add(panelHeader);

            splitContainer1.Panel1.Controls.Add(textmail);
            splitContainer1.Panel1.Controls.Add(textpossition);
            splitContainer1.Panel1.Controls.Add(textaddress);
            splitContainer1.Panel1.Controls.Add(textnic);
            splitContainer1.Panel1.Controls.Add(textname);
            splitContainer1.Panel1.Controls.Add(label13);
            splitContainer1.Panel1.Controls.Add(label12);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(192, 192, 255);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(textreason);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Size = new Size(872, 618);
            splitContainer1.SplitterDistance = 435;

            splitContainer1.TabIndex = 0;
            // 
            // textmail
            // 
            textmail.Location = new Point(140, 551);
            textmail.Name = "textmail";
            textmail.Size = new Size(281, 27);

            textmail.TabIndex = 15;
            // 
            // textpossition
            // 
            textpossition.Location = new Point(140, 483);
            textpossition.Name = "textpossition";
            textpossition.Size = new Size(281, 27);

            textpossition.TabIndex = 14;
            // 
            // textaddress
            // 
            textaddress.Location = new Point(140, 296);
            textaddress.Name = "textaddress";
            textaddress.Size = new Size(281, 161);

            textaddress.TabIndex = 13;
            textaddress.Text = "";
            // 
            // textnic
            // 
            textnic.Location = new Point(140, 219);
            textnic.Name = "textnic";
            textnic.Size = new Size(281, 27);

            textnic.TabIndex = 12;
            // 
            // textname
            // 
            textname.Location = new Point(140, 116);
            textname.Name = "textname";
            textname.Size = new Size(281, 86);

            textname.TabIndex = 11;
            textname.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(107, 551);

            label13.Name = "label13";
            label13.Size = new Size(14, 24);
            label13.TabIndex = 8;
            label13.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 551);

            label12.Name = "label12";
            label12.Size = new Size(54, 24);
            label12.TabIndex = 8;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(107, 219);

            label11.Name = "label11";
            label11.Size = new Size(14, 24);
            label11.TabIndex = 10;
            label11.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(107, 296);

            label10.Name = "label10";
            label10.Size = new Size(14, 24);
            label10.TabIndex = 9;
            label10.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(107, 483);

            label9.Name = "label9";
            label9.Size = new Size(14, 24);
            label9.TabIndex = 8;
            label9.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(107, 116);

            label7.Name = "label7";
            label7.Size = new Size(14, 24);
            label7.TabIndex = 6;
            label7.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 420);

            label6.Name = "label6";
            label6.Size = new Size(0, 24);
            label6.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 483);

            label5.Name = "label5";
            label5.Size = new Size(84, 24);
            label5.TabIndex = 4;
            label5.Text = "Possition";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 219);

            label3.Name = "label3";
            label3.Size = new Size(71, 24);
            label3.TabIndex = 2;
            label3.Text = "NIC No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 296);

            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 116);

            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(214, 543);
            button1.Name = "button1";
            button1.Size = new Size(196, 35);

            button1.TabIndex = 9;
            button1.Text = "Request";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textreason
            // 
            textreason.Location = new Point(15, 146);
            textreason.Name = "textreason";
            textreason.Size = new Size(395, 364);
            textreason.TabIndex = 8;
            textreason.Text = "";
            textreason.TextChanged += textreason_TextChanged;

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 116);

            label4.Name = "label4";
            label4.Size = new Size(68, 24);
            label4.TabIndex = 3;
            label4.Text = "Reason";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(89, 116);

            label8.Name = "label8";
            label8.Size = new Size(14, 24);
            label8.TabIndex = 7;
            label8.Text = ":";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(128, 128, 255);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = SystemColors.ActiveCaptionText;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(435, 60);
            panelHeader.TabIndex = 16;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Black;
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(308, 37);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Request Pollice Report";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 60);
            panel1.TabIndex = 10;

            // 
            // RequestPoliceReport
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 649);
            Controls.Add(splitContainer1);
            Name = "RequestPoliceReport";
            Text = "RequestPoliceReport";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textmail;
        private TextBox textpossition;
        private RichTextBox textaddress;
        private TextBox textnic;
        private RichTextBox textname;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private RichTextBox textreason;
        private Label label8;
        private Button button1;
        private Panel panelHeader;
        private Label lblHeader;
        private Panel panel1;
    }
}