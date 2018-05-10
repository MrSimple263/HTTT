using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MN_BOOKSTORE
{
    public partial class frmQL_PXK : Form
    {
        public frmQL_PXK()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                try
                {
                    int id = int.Parse(dgvPXK.CurrentRow.Cells[0].Value.ToString());

                    new BLL.PXK_BLL().delete(id);
                    MessageBox.Show("Xóa xong");
                    dgvPXK.DataSource = new BLL.PXK_BLL().getAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn muốn xóa");
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new frmPXK().ShowDialog();
            dgvPXK.DataSource = new BLL.PXK_BLL().getAll();
        }

        private void frmQL_PXK_Load(object sender, EventArgs e)
        {
            dgvPXK.DataSource = new BLL.PXK_BLL().getAll();
        }
    }
}
