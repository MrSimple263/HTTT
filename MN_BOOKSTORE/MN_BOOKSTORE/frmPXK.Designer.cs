namespace MN_BOOKSTORE
{
    partial class frmPXK
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
            this.lblPXK = new System.Windows.Forms.Label();
            this.dgvPXK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPXK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPXK
            // 
            this.lblPXK.AutoSize = true;
            this.lblPXK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPXK.ForeColor = System.Drawing.Color.Red;
            this.lblPXK.Location = new System.Drawing.Point(72, 26);
            this.lblPXK.Name = "lblPXK";
            this.lblPXK.Size = new System.Drawing.Size(188, 25);
            this.lblPXK.TabIndex = 0;
            this.lblPXK.Text = "PHIẾU XUẤT KHO";
            // 
            // dgvPXK
            // 
            this.dgvPXK.BackgroundColor = System.Drawing.Color.White;
            this.dgvPXK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPXK.Location = new System.Drawing.Point(36, 69);
            this.dgvPXK.Name = "dgvPXK";
            this.dgvPXK.Size = new System.Drawing.Size(293, 294);
            this.dgvPXK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(104, 378);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 428);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 6;
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(104, 471);
            this.numCount.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(120, 20);
            this.numCount.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(32, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(146, 518);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(254, 518);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Xuất Phiếu";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmPXK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 567);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPXK);
            this.Controls.Add(this.lblPXK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPXK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPXK";
            this.Load += new System.EventHandler(this.frmPXK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPXK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPXK;
        private System.Windows.Forms.DataGridView dgvPXK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
    }
}