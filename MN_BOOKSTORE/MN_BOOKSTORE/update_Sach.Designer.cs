namespace MN_BOOKSTORE
{
    partial class update_Sach
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
            this.cbnxb = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgtheloai = new System.Windows.Forms.DataGridView();
            this.dgtacgia = new System.Windows.Forms.DataGridView();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtheloai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // cbnxb
            // 
            this.cbnxb.FormattingEnabled = true;
            this.cbnxb.Location = new System.Drawing.Point(94, 104);
            this.cbnxb.Name = "cbnxb";
            this.cbnxb.Size = new System.Drawing.Size(391, 21);
            this.cbnxb.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgtheloai
            // 
            this.dgtheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtheloai.Location = new System.Drawing.Point(94, 307);
            this.dgtheloai.Name = "dgtheloai";
            this.dgtheloai.Size = new System.Drawing.Size(391, 96);
            this.dgtheloai.TabIndex = 28;
            // 
            // dgtacgia
            // 
            this.dgtacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtacgia.Location = new System.Drawing.Point(94, 186);
            this.dgtacgia.Name = "dgtacgia";
            this.dgtacgia.Size = new System.Drawing.Size(391, 93);
            this.dgtacgia.TabIndex = 27;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(94, 144);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(391, 20);
            this.txtdongia.TabIndex = 26;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(94, 53);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(391, 20);
            this.txtname.TabIndex = 25;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(94, 12);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(225, 20);
            this.txtid.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Thể Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tác Giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "NXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Sách";
            // 
            // update_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.cbnxb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgtheloai);
            this.Controls.Add(this.dgtacgia);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "update_Sach";
            this.Text = "update_Sach";
            this.Load += new System.EventHandler(this.update_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtheloai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtacgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbnxb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgtheloai;
        private System.Windows.Forms.DataGridView dgtacgia;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}