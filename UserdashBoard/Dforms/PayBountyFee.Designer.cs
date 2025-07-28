namespace Forms.UserdashBoard.Dforms
{
    partial class PayBountyFee
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textName = new TextBox();
            textNic = new TextBox();
            textAddress = new TextBox();
            textPay = new TextBox();
            buttonPay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 11F, FontStyle.Bold);
            label1.Location = new Point(44, 87);
            label1.Name = "label1";
            label1.Size = new Size(63, 26);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 195);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 1;
            label2.Text = "NIC No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 420);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 2;
            label3.Text = "Payment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 306);
            label4.Name = "label4";
            label4.Size = new Size(77, 24);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(141, 87);
            label5.Name = "label5";
            label5.Size = new Size(14, 24);
            label5.TabIndex = 4;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(141, 306);
            label6.Name = "label6";
            label6.Size = new Size(14, 24);
            label6.TabIndex = 5;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(141, 195);
            label7.Name = "label7";
            label7.Size = new Size(14, 24);
            label7.TabIndex = 6;
            label7.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display Semib", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(141, 420);
            label8.Name = "label8";
            label8.Size = new Size(14, 24);
            label8.TabIndex = 7;
            label8.Text = ":";
            // 
            // textName
            // 
            textName.Location = new Point(175, 87);
            textName.Name = "textName";
            textName.Size = new Size(666, 27);
            textName.TabIndex = 8;
            // 
            // textNic
            // 
            textNic.Location = new Point(175, 195);
            textNic.Name = "textNic";
            textNic.Size = new Size(666, 27);
            textNic.TabIndex = 9;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(175, 306);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(666, 27);
            textAddress.TabIndex = 10;
            // 
            // textPay
            // 
            textPay.Location = new Point(175, 420);
            textPay.Name = "textPay";
            textPay.Size = new Size(666, 27);
            textPay.TabIndex = 11;
            // 
            // buttonPay
            // 
            buttonPay.Font = new Font("Segoe UI Variable Display Semib", 14F, FontStyle.Bold);
            buttonPay.Location = new Point(336, 497);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(150, 72);
            buttonPay.TabIndex = 12;
            buttonPay.Text = "Pay";
            buttonPay.UseVisualStyleBackColor = true;
            // 
            // PayBountyFee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(872, 618);
            Controls.Add(buttonPay);
            Controls.Add(textPay);
            Controls.Add(textAddress);
            Controls.Add(textNic);
            Controls.Add(textName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PayBountyFee";
            Text = "PayBountyFee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textName;
        private TextBox textNic;
        private TextBox textAddress;
        private TextBox textPay;
        private Button buttonPay;
    }
}