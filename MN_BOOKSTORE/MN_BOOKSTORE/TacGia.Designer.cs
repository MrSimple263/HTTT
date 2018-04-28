namespace MN_BOOKSTORE
{
    partial class TacGia
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
            this.dgtacgia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.rtxtinfor = new System.Windows.Forms.RichTextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtacgia
            // 
            this.dgtacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtacgia.Location = new System.Drawing.Point(12, 30);
            this.dgtacgia.Name = "dgtacgia";
            this.dgtacgia.Size = new System.Drawing.Size(591, 226);
            this.dgtacgia.TabIndex = 1;
            this.dgtacgia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtacgia_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Infor";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(53, 274);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 5;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(50, 351);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(234, 20);
            this.txtten.TabIndex = 6;
            // 
            // rtxtinfor
            // 
            this.rtxtinfor.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtinfor.Location = new System.Drawing.Point(304, 293);
            this.rtxtinfor.Name = "rtxtinfor";
            this.rtxtinfor.Size = new System.Drawing.Size(299, 96);
            this.rtxtinfor.TabIndex = 7;
            this.rtxtinfor.Text = "";
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(637, 233);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 8;
            this.btninsert.Text = "Insert ";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(637, 277);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(637, 322);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 10;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(637, 366);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 409);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.rtxtinfor);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtacgia);
            this.Name = "TacGia";
            this.Text = "TacGia";
            this.Load += new System.EventHandler(this.TacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtacgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgtacgia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.RichTextBox rtxtinfor;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnclear;
    }
}