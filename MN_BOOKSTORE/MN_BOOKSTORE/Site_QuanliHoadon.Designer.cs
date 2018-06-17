namespace MN_BOOKSTORE
{
    partial class Site_QuanliHoadon
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
            this.dgv_Hoadon = new System.Windows.Forms.DataGridView();
            this.cbx_chinhanh = new System.Windows.Forms.ComboBox();
            this.lbl_chinhanh = new System.Windows.Forms.Label();
            this.dgv_Chitiethoadon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Hoadon
            // 
            this.dgv_Hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hoadon.Location = new System.Drawing.Point(39, 65);
            this.dgv_Hoadon.Name = "dgv_Hoadon";
            this.dgv_Hoadon.Size = new System.Drawing.Size(366, 329);
            this.dgv_Hoadon.TabIndex = 0;
            this.dgv_Hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hoadon_CellClick);
            // 
            // cbx_chinhanh
            // 
            this.cbx_chinhanh.FormattingEnabled = true;
            this.cbx_chinhanh.Location = new System.Drawing.Point(154, 24);
            this.cbx_chinhanh.Name = "cbx_chinhanh";
            this.cbx_chinhanh.Size = new System.Drawing.Size(217, 21);
            this.cbx_chinhanh.TabIndex = 2;
            this.cbx_chinhanh.SelectionChangeCommitted += new System.EventHandler(this.cbx_chinhanh_SelectionChangeCommitted);
            // 
            // lbl_chinhanh
            // 
            this.lbl_chinhanh.AutoSize = true;
            this.lbl_chinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chinhanh.Location = new System.Drawing.Point(51, 21);
            this.lbl_chinhanh.Name = "lbl_chinhanh";
            this.lbl_chinhanh.Size = new System.Drawing.Size(97, 24);
            this.lbl_chinhanh.TabIndex = 2;
            this.lbl_chinhanh.Text = "Chi nhánh";
            // 
            // dgv_Chitiethoadon
            // 
            this.dgv_Chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Chitiethoadon.Location = new System.Drawing.Point(426, 66);
            this.dgv_Chitiethoadon.Name = "dgv_Chitiethoadon";
            this.dgv_Chitiethoadon.Size = new System.Drawing.Size(355, 327);
            this.dgv_Chitiethoadon.TabIndex = 3;
            // 
            // Site_QuanliHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Chitiethoadon);
            this.Controls.Add(this.lbl_chinhanh);
            this.Controls.Add(this.cbx_chinhanh);
            this.Controls.Add(this.dgv_Hoadon);
            this.Name = "Site_QuanliHoadon";
            this.Text = "Site_QuanliHoadon";
            this.Load += new System.EventHandler(this.Site_QuanliHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chitiethoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Hoadon;
        private System.Windows.Forms.ComboBox cbx_chinhanh;
        private System.Windows.Forms.Label lbl_chinhanh;
        private System.Windows.Forms.DataGridView dgv_Chitiethoadon;
    }
}