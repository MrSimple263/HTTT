namespace MN_BOOKSTORE
{
    partial class frmPNK
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPNK = new System.Windows.Forms.DataGridView();
            this.lblPXK = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(244, 508);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Xuất Phiếu";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(136, 508);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 508);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(94, 461);
            this.numCount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(120, 20);
            this.numCount.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 418);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 17;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(94, 368);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 16;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã sách";
            // 
            // dgvPNK
            // 
            this.dgvPNK.BackgroundColor = System.Drawing.Color.White;
            this.dgvPNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPNK.Location = new System.Drawing.Point(26, 59);
            this.dgvPNK.Name = "dgvPNK";
            this.dgvPNK.Size = new System.Drawing.Size(293, 294);
            this.dgvPNK.TabIndex = 12;
            // 
            // lblPXK
            // 
            this.lblPXK.AutoSize = true;
            this.lblPXK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPXK.ForeColor = System.Drawing.Color.Red;
            this.lblPXK.Location = new System.Drawing.Point(62, 16);
            this.lblPXK.Name = "lblPXK";
            this.lblPXK.Size = new System.Drawing.Size(190, 25);
            this.lblPXK.TabIndex = 11;
            this.lblPXK.Text = "PHIẾU NHẬP KHO";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(244, 365);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 23);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Sách Mới";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmPNK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 542);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPNK);
            this.Controls.Add(this.lblPXK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPNK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPNK";
            this.Load += new System.EventHandler(this.frmPNK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPNK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPNK;
        private System.Windows.Forms.Label lblPXK;
        private System.Windows.Forms.Button btnCreate;
    }
}