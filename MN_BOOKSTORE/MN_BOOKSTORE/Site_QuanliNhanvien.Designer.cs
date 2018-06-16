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
            this.dgv_Nhanvien.Size = new System.Drawing.Size(716, 329);
            this.dgv_Nhanvien.TabIndex = 6;
            // 
            // Site_QuanliNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}