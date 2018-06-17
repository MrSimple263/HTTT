namespace MN_BOOKSTORE
{
    partial class frmNhanVien
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
            this.dgnhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.cbchucvu = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgnhanvien
            // 
            this.dgnhanvien.AllowUserToAddRows = false;
            this.dgnhanvien.AllowUserToDeleteRows = false;
            this.dgnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgnhanvien.Location = new System.Drawing.Point(25, 23);
            this.dgnhanvien.Name = "dgnhanvien";
            this.dgnhanvien.ReadOnly = true;
            this.dgnhanvien.Size = new System.Drawing.Size(673, 213);
            this.dgnhanvien.TabIndex = 0;
            this.dgnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgnhanvien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "sdt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "chức vụ";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(62, 261);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(175, 20);
            this.txtid.TabIndex = 8;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(62, 303);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(175, 20);
            this.txtusername.TabIndex = 9;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(62, 341);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(175, 20);
            this.txtpass.TabIndex = 10;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(304, 264);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(159, 20);
            this.txthoten.TabIndex = 11;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(304, 303);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(159, 20);
            this.txtsdt.TabIndex = 12;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(304, 341);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(159, 20);
            this.txtngaysinh.TabIndex = 13;
            // 
            // cbchucvu
            // 
            this.cbchucvu.FormattingEnabled = true;
            this.cbchucvu.Location = new System.Drawing.Point(534, 263);
            this.cbchucvu.Name = "cbchucvu";
            this.cbchucvu.Size = new System.Drawing.Size(121, 21);
            this.cbchucvu.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "insert ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "làm mới";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(656, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 66);
            this.button5.TabIndex = 19;
            this.button5.Text = "Đổi công tác";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 376);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbchucvu);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgnhanvien);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.ComboBox cbchucvu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}