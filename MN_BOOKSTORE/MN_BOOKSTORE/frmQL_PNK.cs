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
    public partial class frmQL_PNK : Form
    {
        public frmQL_PNK()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new frmPNK().ShowDialog();
        }

        private void frmQL_PNK_Load(object sender, EventArgs e)
        {
            dgvPNK.DataSource = new BLL.PNK_BLL().getAll();
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
                    int id = int.Parse(dgvPNK.CurrentRow.Cells[0].Value.ToString());

                    new BLL.PNK_BLL().delete(id);
                    MessageBox.Show("Xóa xong");
                    dgvPNK.DataSource = new BLL.PNK_BLL().getAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn muốn xóa");
                }
            }
        }
    }
}
