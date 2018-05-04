namespace MN_BOOKSTORE
{
    partial class QL_Sach
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
            this.dgsach = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgsach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgsach
            // 
            this.dgsach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsach.Location = new System.Drawing.Point(3, 46);
            this.dgsach.Name = "dgsach";
            this.dgsach.Size = new System.Drawing.Size(517, 305);
            this.dgsach.TabIndex = 0;
            this.dgsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsach_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(571, 161);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(678, 161);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(571, 236);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(75, 23);
            this.btnchitiet.TabIndex = 4;
            this.btnchitiet.Text = "làm mới";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(678, 236);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // QL_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgsach);
            this.Name = "QL_Sach";
            this.Text = "QL_Sach";
            this.Load += new System.EventHandler(this.QL_Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgsach;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.Button btnxoa;
    }
}