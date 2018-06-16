namespace MN_BOOKSTORE
{
    partial class Site_QuanliPNK
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
            this.cbx_chinhanh = new System.Windows.Forms.ComboBox();
            this.dgv_PNK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNK)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_chinhanh
            // 
            this.lbl_chinhanh.AutoSize = true;
            this.lbl_chinhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chinhanh.Location = new System.Drawing.Point(71, 28);
            this.lbl_chinhanh.Name = "lbl_chinhanh";
            this.lbl_chinhanh.Size = new System.Drawing.Size(97, 24);
            this.lbl_chinhanh.TabIndex = 5;
            this.lbl_chinhanh.Text = "Chi nhánh";
            // 
            // cbx_chinhanh
            // 
            this.cbx_chinhanh.FormattingEnabled = true;
            this.cbx_chinhanh.Location = new System.Drawing.Point(174, 31);
            this.cbx_chinhanh.Name = "cbx_chinhanh";
            this.cbx_chinhanh.Size = new System.Drawing.Size(217, 21);
            this.cbx_chinhanh.TabIndex = 4;
            this.cbx_chinhanh.SelectionChangeCommitted += new System.EventHandler(this.cbx_chinhanh_SelectionChangeCommitted);
            // 
            // dgv_PNK
            // 
            this.dgv_PNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PNK.Location = new System.Drawing.Point(66, 73);
            this.dgv_PNK.Name = "dgv_PNK";
            this.dgv_PNK.Size = new System.Drawing.Size(366, 329);
            this.dgv_PNK.TabIndex = 3;
            // 
            // Site_QuanliPNK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.lbl_chinhanh);
            this.Controls.Add(this.cbx_chinhanh);
            this.Controls.Add(this.dgv_PNK);
            this.Name = "Site_QuanliPNK";
            this.Text = "Site_QuanliPNK";
            this.Load += new System.EventHandler(this.Site_QuanliPNK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PNK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chinhanh;
        private System.Windows.Forms.ComboBox cbx_chinhanh;
        private System.Windows.Forms.DataGridView dgv_PNK;
    }
}