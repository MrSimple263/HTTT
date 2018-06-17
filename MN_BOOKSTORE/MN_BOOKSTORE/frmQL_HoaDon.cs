using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace MN_BOOKSTORE
{
    public partial class frmQL_HoaDon : Form
    {
        public frmQL_HoaDon()
        {
            InitializeComponent();
        }

        private void frmQL_HoaDon_Load(object sender, EventArgs e)
        { 
            dgvHD.DataSource = new BLL.HoaDon_BLL().getAll();
            dgvCTHD.DataSource = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new TaoHoaDon().ShowDialog();
            dgvHD.DataSource = new BLL.HoaDon_BLL().getAll();
            dgvCTHD.DataSource = null;
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
                    int id = int.Parse(dgvHD.CurrentRow.Cells[0].Value.ToString());

                    new BLL.HoaDon_BLL().delete(id);
                    MessageBox.Show("Xóa xong");
                    dgvHD.DataSource = new BLL.HoaDon_BLL().getAll();
                    dgvCTHD.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn muốn xóa");
                }
            }
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvHD.CurrentRow.Cells[0].Value.ToString());
            DataTable cthd = new BLL.CTHD_BLL().getById(id);
            cthd.Columns.RemoveAt(0);
            cthd.Columns.RemoveAt(2);
            dgvCTHD.DataSource = cthd;
        }
    }
}
