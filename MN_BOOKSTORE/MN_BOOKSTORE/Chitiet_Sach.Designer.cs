namespace MN_BOOKSTORE
{
    partial class Chitiet_Sach
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.dgtacgia = new System.Windows.Forms.DataGridView();
            this.dgtheloai = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.cbnxb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtacgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtheloai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NXB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tác Giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thể Loại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(99, 79);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(391, 20);
            this.txtname.TabIndex = 7;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(99, 170);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(391, 20);
            this.txtdongia.TabIndex = 9;
            // 
            // dgtacgia
            // 
            this.dgtacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtacgia.Location = new System.Drawing.Point(99, 212);
            this.dgtacgia.Name = "dgtacgia";
            this.dgtacgia.Size = new System.Drawing.Size(391, 93);
            this.dgtacgia.TabIndex = 14;
            // 
            // dgtheloai
            // 
            this.dgtheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtheloai.Location = new System.Drawing.Point(99, 333);
            this.dgtheloai.Name = "dgtheloai";
            this.dgtheloai.Size = new System.Drawing.Size(391, 96);
            this.dgtheloai.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbnxb
            // 
            this.cbnxb.FormattingEnabled = true;
            this.cbnxb.Location = new System.Drawing.Point(99, 130);
            this.cbnxb.Name = "cbnxb";
            this.cbnxb.Size = new System.Drawing.Size(391, 21);
            this.cbnxb.TabIndex = 17;
            // 
            // Chitiet_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 472);
            this.Controls.Add(this.cbnxb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgtheloai);
            this.Controls.Add(this.dgtacgia);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chitiet_Sach";
            this.Text = "Chitiet_Sach";
            this.Load += new System.EventHandler(this.Chitiet_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtacgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtheloai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.DataGridView dgtacgia;
        private System.Windows.Forms.DataGridView dgtheloai;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbnxb;
    }
}