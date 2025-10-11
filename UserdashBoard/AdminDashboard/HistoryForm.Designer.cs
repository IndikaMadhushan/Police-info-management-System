namespace Forms.UserdashBoard.AdminDashboard
{
    partial class HistoryForm
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
            btnExportPDF = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            gridInquiries = new DataGridView();
            gridBounty = new DataGridView();
            gridFault = new DataGridView();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtNic = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridInquiries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBounty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridFault).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnExportPDF);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(gridInquiries);
            panel1.Controls.Add(gridBounty);
            panel1.Controls.Add(gridFault);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtNic);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 699);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Location = new Point(247, 634);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(165, 36);
            btnExportPDF.TabIndex = 13;
            btnExportPDF.Text = "Export to PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 472);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 12;
            label6.Text = "Inquiries";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 242);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 11;
            label5.Text = "Bounty Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 19);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 10;
            label4.Text = "Fault Details";
            // 
            // gridInquiries
            // 
            gridInquiries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridInquiries.Location = new Point(532, 496);
            gridInquiries.Name = "gridInquiries";
            gridInquiries.RowHeadersWidth = 51;
            gridInquiries.Size = new Size(797, 188);
            gridInquiries.TabIndex = 9;
            // 
            // gridBounty
            // 
            gridBounty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBounty.Location = new Point(532, 266);
            gridBounty.Name = "gridBounty";
            gridBounty.RowHeadersWidth = 51;
            gridBounty.Size = new Size(797, 188);
            gridBounty.TabIndex = 8;
            // 
            // gridFault
            // 
            gridFault.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFault.Location = new Point(532, 43);
            gridFault.Name = "gridFault";
            gridFault.RowHeadersWidth = 51;
            gridFault.Size = new Size(797, 188);
            gridFault.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 472);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 6;
            label3.Text = "Photo";
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 544);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(289, 39);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 547);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(56, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 240);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(312, 113);
            button1.Name = "button1";
            button1.Size = new Size(100, 36);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNic
            // 
            txtNic.Location = new Point(123, 43);
            txtNic.Multiline = true;
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(289, 39);
            txtNic.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 43);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 0;
            label1.Text = "NIC";
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 698);
            Controls.Add(panel1);
            Name = "HistoryForm";
            Text = "HistoryForm";
            Load += HistoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridInquiries).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBounty).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridFault).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox txtNic;
        private Label label1;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView gridFault;
        private Label label4;
        private DataGridView gridInquiries;
        private DataGridView gridBounty;
        private Label label5;
        private Label label6;
        private Button btnExportPDF;
    }
}