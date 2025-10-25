namespace Forms.UserdashBoard.Dforms
{
    partial class PlaceInquries
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
            textdate = new TextBox();
            textaddress = new RichTextBox();
            textnic = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            textname = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            buttonsave = new Button();
            textinquary = new RichTextBox();
            label10 = new Label();
            label9 = new Label();
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
            splitContainer1.Panel1.Controls.Add(textdate);
            splitContainer1.Panel1.Controls.Add(textaddress);
            splitContainer1.Panel1.Controls.Add(textnic);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(textname);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(192, 192, 255);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(buttonsave);
            splitContainer1.Panel2.Controls.Add(textinquary);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Size = new Size(872, 618);
            splitContainer1.SplitterDistance = 429;
            splitContainer1.TabIndex = 0;
            // 
            // textdate
            // 
            textdate.Location = new Point(106, 548);
            textdate.Name = "textdate";
            textdate.Size = new Size(309, 27);
            textdate.TabIndex = 12;
            // 
            // textaddress
            // 
            textaddress.Location = new Point(106, 297);
            textaddress.Name = "textaddress";
            textaddress.Size = new Size(309, 224);
            textaddress.TabIndex = 11;
            textaddress.Text = "";
            // 
            // textnic
            // 
            textnic.Location = new Point(106, 239);
            textnic.Name = "textnic";
            textnic.Size = new Size(309, 27);
            textnic.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label8.Location = new Point(88, 128);
            label8.Name = "label8";
            label8.Size = new Size(12, 20);
            label8.TabIndex = 9;
            label8.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label7.Location = new Point(88, 297);
            label7.Name = "label7";
            label7.Size = new Size(12, 20);
            label7.TabIndex = 8;
            label7.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label6.Location = new Point(88, 551);
            label6.Name = "label6";
            label6.Size = new Size(12, 20);
            label6.TabIndex = 7;
            label6.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label2.Location = new Point(88, 242);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 6;
            label2.Text = ":";
            label2.Click += label2_Click;
            // 
            // textname
            // 
            textname.Location = new Point(106, 128);
            textname.Name = "textname";
            textname.Size = new Size(309, 93);
            textname.TabIndex = 5;
            textname.Text = "";
            textname.TextChanged += textname_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 242);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "NIC No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 297);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 551);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // buttonsave
            // 
            buttonsave.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonsave.Location = new Point(170, 533);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(234, 38);
            buttonsave.TabIndex = 10;
            buttonsave.Text = "SAVE AND REQUEST";
            buttonsave.UseVisualStyleBackColor = true;
            buttonsave.Click += buttonsave_Click;
            // 
            // textinquary
            // 
            textinquary.Location = new Point(28, 162);
            textinquary.Name = "textinquary";
            textinquary.Size = new Size(376, 325);
            textinquary.TabIndex = 9;
            textinquary.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label10.Location = new Point(90, 128);
            label10.Name = "label10";
            label10.Size = new Size(12, 20);
            label10.TabIndex = 8;
            label10.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label9.Location = new Point(28, 128);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 7;
            label9.Text = "Inquary";
            label9.Click += label9_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(128, 128, 255);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = SystemColors.ActiveCaptionText;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(429, 60);
            panelHeader.TabIndex = 13;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Black;
            lblHeader.Location = new Point(20, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(184, 37);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Place Inqurie";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 60);
            panel1.TabIndex = 11;
            // 
            // PlaceInquries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 618);
            Controls.Add(splitContainer1);
            Name = "PlaceInquries";
            Text = "PlaceInquries";
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private RichTextBox textname;
        private TextBox textdate;
        private RichTextBox textaddress;
        private TextBox textnic;
        private Button buttonsave;
        private RichTextBox textinquary;
        private Label label10;
        private Label label9;
        private Panel panelHeader;
        private Label lblHeader;
        private Panel panel1;
    }
}