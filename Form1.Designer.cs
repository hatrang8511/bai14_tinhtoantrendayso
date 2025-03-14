namespace bai14_tinhtoantrendayso
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblbatdau = new System.Windows.Forms.Label();
            this.txtbatdau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txttong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttongchan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttongle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH TOÁN TRÊN DÃY SỐ";
            // 
            // lblbatdau
            // 
            this.lblbatdau.AutoSize = true;
            this.lblbatdau.Location = new System.Drawing.Point(81, 158);
            this.lblbatdau.Name = "lblbatdau";
            this.lblbatdau.Size = new System.Drawing.Size(87, 20);
            this.lblbatdau.TabIndex = 1;
            this.lblbatdau.Text = "Số bắt đầu";
            // 
            // txtbatdau
            // 
            this.txtbatdau.Location = new System.Drawing.Point(191, 157);
            this.txtbatdau.Name = "txtbatdau";
            this.txtbatdau.Size = new System.Drawing.Size(100, 26);
            this.txtbatdau.TabIndex = 2;
            this.txtbatdau.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số kết thúc";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "100";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(334, 256);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(102, 42);
            this.btntinh.TabIndex = 3;
            this.btntinh.Text = "TÍNH";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "tổng";
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(191, 328);
            this.txttong.Name = "txttong";
            this.txttong.ReadOnly = true;
            this.txttong.Size = new System.Drawing.Size(100, 26);
            this.txttong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "tổng chẵn";
            // 
            // txttongchan
            // 
            this.txttongchan.Location = new System.Drawing.Point(191, 384);
            this.txttongchan.Name = "txttongchan";
            this.txttongchan.ReadOnly = true;
            this.txttongchan.Size = new System.Drawing.Size(100, 26);
            this.txttongchan.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "tổng lẻ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txttongle
            // 
            this.txttongle.Location = new System.Drawing.Point(191, 443);
            this.txttongle.Name = "txttongle";
            this.txttongle.ReadOnly = true;
            this.txttongle.Size = new System.Drawing.Size(100, 26);
            this.txttongle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 692);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttongle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttongchan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbatdau);
            this.Controls.Add(this.lblbatdau);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbatdau;
        private System.Windows.Forms.TextBox txtbatdau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttongchan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttongle;
    }
}

