namespace MN_BOOKSTORE
{
    partial class TheLoai
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
            this.dgtheloai = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtheloai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtheloai
            // 
            this.dgtheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtheloai.Location = new System.Drawing.Point(29, 40);
            this.dgtheloai.Name = "dgtheloai";
            this.dgtheloai.Size = new System.Drawing.Size(391, 308);
            this.dgtheloai.TabIndex = 0;
            this.dgtheloai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtheloai_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(452, 101);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(71, 20);
            this.txtid.TabIndex = 2;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(454, 214);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 3;
            this.btninsert.Text = "Insert ";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(546, 214);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(454, 259);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 5;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(546, 259);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(452, 172);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(213, 20);
            this.txtname.TabIndex = 8;
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 376);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtheloai);
            this.Name = "TheLoai";
            this.Text = "TheLoai";
            this.Load += new System.EventHandler(this.TheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtheloai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtheloai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
    }
}