
namespace Forms.UserdashBoard.Dforms
{
    partial class Home
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
            textaddress = new TextBox();
            textDate = new TextBox();
            textmail = new TextBox();
            texttel = new TextBox();
            textjob = new TextBox();
            textid = new TextBox();
            textname = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            richBoxBounty = new RichTextBox();
            panelHeader = new Panel();
            lblHeader = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(textaddress);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(textmail);
            splitContainer1.Panel1.Controls.Add(texttel);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(textjob);
            splitContainer1.Panel1.Controls.Add(textid);
            splitContainer1.Panel1.Controls.Add(textname);
            splitContainer1.Panel1.Controls.Add(label14);
            splitContainer1.Panel1.Controls.Add(label13);
            splitContainer1.Panel1.Controls.Add(label12);
            splitContainer1.Panel1.Controls.Add(label11);
            splitContainer1.Panel1.Controls.Add(label10);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint_1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(192, 192, 255);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(textDate);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Size = new Size(1124, 611);
            splitContainer1.SplitterDistance = 571;
            splitContainer1.TabIndex = 1;
            // 
            // textaddress
            // 
            textaddress.Enabled = false;
            textaddress.Location = new Point(152, 359);
            textaddress.Multiline = true;
            textaddress.Name = "textaddress";
            textaddress.ReadOnly = true;
            textaddress.Size = new Size(384, 28);
            textaddress.TabIndex = 21;
            textaddress.TextChanged += textaddress_TextChanged;
            // 
            // textDate
            // 
            textDate.Enabled = false;
            textDate.Location = new Point(149, 81);
            textDate.Name = "textDate";
            textDate.ReadOnly = true;
            textDate.Size = new Size(384, 27);
            textDate.TabIndex = 20;
            // 
            // textmail
            // 
            textmail.Enabled = false;
            textmail.Location = new Point(152, 549);
            textmail.Name = "textmail";
            textmail.ReadOnly = true;
            textmail.Size = new Size(384, 27);
            textmail.TabIndex = 19;
            // 
            // texttel
            // 
            texttel.Enabled = false;
            texttel.Location = new Point(152, 489);
            texttel.Name = "texttel";
            texttel.ReadOnly = true;
            texttel.Size = new Size(384, 27);
            texttel.TabIndex = 18;
            // 
            // textjob
            // 
            textjob.Enabled = false;
            textjob.Location = new Point(152, 428);
            textjob.Multiline = true;
            textjob.Name = "textjob";
            textjob.ReadOnly = true;
            textjob.Size = new Size(384, 28);
            textjob.TabIndex = 17;
            // 
            // textid
            // 
            textid.Enabled = false;
            textid.Location = new Point(152, 301);
            textid.Name = "textid";
            textid.ReadOnly = true;
            textid.Size = new Size(384, 27);
            textid.TabIndex = 16;
            // 
            // textname
            // 
            textname.Enabled = false;
            textname.Location = new Point(152, 240);
            textname.Name = "textname";
            textname.ReadOnly = true;
            textname.Size = new Size(384, 27);
            textname.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label14.Location = new Point(136, 240);
            label14.Name = "label14";
            label14.Size = new Size(12, 20);
            label14.TabIndex = 14;
            label14.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label13.Location = new Point(136, 309);
            label13.Name = "label13";
            label13.Size = new Size(12, 20);
            label13.TabIndex = 13;
            label13.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label12.Location = new Point(136, 367);
            label12.Name = "label12";
            label12.Size = new Size(12, 20);
            label12.TabIndex = 12;
            label12.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label11.Location = new Point(136, 428);
            label11.Name = "label11";
            label11.Size = new Size(12, 20);
            label11.TabIndex = 11;
            label11.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label10.Location = new Point(136, 493);
            label10.Name = "label10";
            label10.Size = new Size(12, 20);
            label10.TabIndex = 10;
            label10.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label9.Location = new Point(136, 553);
            label9.Name = "label9";
            label9.Size = new Size(12, 20);
            label9.TabIndex = 9;
            label9.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(126, 84);
            label8.Name = "label8";
            label8.Size = new Size(12, 20);
            label8.TabIndex = 8;
            label8.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 84);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 7;
            label7.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 553);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 6;
            label6.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 493);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 5;
            label5.Text = "Tel";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 428);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 4;
            label4.Text = "Job";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 367);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Address ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 309);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "NIC   ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 240);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Name  ";
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.OutlineButton;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(185, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 168);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richBoxBounty);
            groupBox1.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 430);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bounty Details :";
            // 
            // richBoxBounty
            // 
            richBoxBounty.Location = new Point(12, 25);
            richBoxBounty.Name = "richBoxBounty";
            richBoxBounty.Size = new Size(508, 565);
            richBoxBounty.TabIndex = 0;
            richBoxBounty.Text = "";
            richBoxBounty.TextChanged += richBoxBounty_TextChanged;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(128, 128, 255);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = SystemColors.ActiveCaptionText;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(571, 60);
            panelHeader.TabIndex = 22;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Black;
            lblHeader.Location = new Point(22, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(95, 37);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Home";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 60);
            panel1.TabIndex = 21;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 611);
            Controls.Add(splitContainer1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        //private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textaddress;
        private TextBox textDate;
        private TextBox textmail;
        private TextBox texttel;
        private TextBox textjob;
        private TextBox textid;
        private TextBox textname;
        private GroupBox groupBox1;
        private RichTextBox richBoxBounty;
        private Panel panelHeader;
        private Label lblHeader;
        private Panel panel1;
    }
}