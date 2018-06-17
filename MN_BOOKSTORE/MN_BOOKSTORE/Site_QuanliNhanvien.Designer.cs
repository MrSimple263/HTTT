namespace MN_BOOKSTORE
{
    partial class Site_QuanliNhanvien
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
            this.lbl_chinhanh = new System.Windows.Forms.Label();
            this.dgv_Nhanvien = new System.Windows.Forms.DataGridView();
            this.cb_chinhanh = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbchucvu = new System.Windows.Forms.ComboBox();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_chinhanh
            // 
            this.lbl_chinhanh.AutoSize = true;
            this.lbl_chinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chinhanh.Location = new System.Drawing.Point(36, 20);
            this.lbl_chinhanh.Name = "lbl_chinhanh";
            this.lbl_chinhanh.Size = new System.Drawing.Size(97, 24);
            this.lbl_chinhanh.TabIndex = 8;
            this.lbl_chinhanh.Text = "Chi nhánh";
            // 
            // dgv_Nhanvien
            // 
            this.dgv_Nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Nhanvien.Location = new System.Drawing.Point(40, 64);
            this.dgv_Nhanvien.Name = "dgv_Nhanvien";
            this.dgv_Nhanvien.Size = new System.Drawing.Size(661, 265);
            this.dgv_Nhanvien.TabIndex = 6;
            this.dgv_Nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Nhanvien_CellClick);
            // 
            // cb_chinhanh
            // 
            this.cb_chinhanh.FormattingEnabled = true;
            this.cb_chinhanh.Location = new System.Drawing.Point(139, 25);
            this.cb_chinhanh.Name = "cb_chinhanh";
            this.cb_chinhanh.Size = new System.Drawing.Size(130, 21);
            this.cb_chinhanh.TabIndex = 9;
            this.cb_chinhanh.SelectedIndexChanged += new System.EventHandler(this.cb_chinhanh_SelectedIndexChanged);
            this.cb_chinhanh.SelectedValueChanged += new System.EventHandler(this.cb_chinhanh_SelectedValueChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(607, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "làm mới";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(607, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "insert ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbchucvu
            // 
            this.cbchucvu.FormattingEnabled = true;
            this.cbchucvu.Location = new System.Drawing.Point(580, 346);
            this.cbchucvu.Name = "cbchucvu";
            this.cbchucvu.Size = new System.Drawing.Size(121, 21);
            this.cbchucvu.TabIndex = 32;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(350, 424);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(159, 20);
            this.txtngaysinh.TabIndex = 31;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(350, 386);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(159, 20);
            this.txtsdt.TabIndex = 30;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(350, 347);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(159, 20);
            this.txthoten.TabIndex = 29;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(108, 424);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(175, 20);
            this.txtpass.TabIndex = 28;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(108, 386);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(175, 20);
            this.txtusername.TabIndex = 27;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(108, 344);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(175, 20);
            this.txtid.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "chức vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "sdt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // Site_QuanliNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
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
            this.Controls.Add(this.cb_chinhanh);
            this.Controls.Add(this.lbl_chinhanh);
            this.Controls.Add(this.dgv_Nhanvien);
            this.Name = "Site_QuanliNhanvien";
            this.Text = "Site_QuanliNhanvien";
            this.Load += new System.EventHandler(this.Site_QuanliNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chinhanh;
        private System.Windows.Forms.DataGridView dgv_Nhanvien;
        private System.Windows.Forms.ComboBox cb_chinhanh;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbchucvu;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}