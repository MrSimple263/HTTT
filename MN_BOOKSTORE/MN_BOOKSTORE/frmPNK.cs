using BLL;
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
    public partial class frmPNK : Form
    {
        List<VO.SACH_KHO> pnks;
        DataTable dataTable;
        public frmPNK()
        {
            InitializeComponent();
        }

        private void frmPNK_Load(object sender, EventArgs e)
        {
            //load thông tin sách
            dataTable = new DataTable();
            dataTable = new BLL.Sach_BLL().getAll();
            pnks = new List<VO.SACH_KHO>();
            dgvPNK.DataSource = pnks;
            txtId.Focus();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int msp = int.Parse(txtId.Text.ToString());
                //lấy tên và đơn giá sản phẩm theo id
                var s = from c in dataTable.AsEnumerable()
                        where c.Field<int>("id") == msp
                        select new { name = c.Field<string>("name") };

                if (s.Count() != 0)
                {
                    txtName.Text = s.First().name.ToString();
                    numCount.Maximum = 100000000;
                }
                else
                {
                    txtName.Clear();
                    numCount.Maximum = 0;
                }
            }catch(Exception ex)
            {
                txtName.Clear();
                numCount.Maximum = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPNK.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvPNK.SelectedRows[0].Cells[0].Value.ToString());
                pnks.Remove(pnks.Where(s => s.id == id).First());
                dgvPNK.DataSource = pnks.ToList();
            }
            else
            {
                MessageBox.Show("Hãy chọn một hàng để xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            VO.SACH_KHO pxk = new VO.SACH_KHO();
            if (String.IsNullOrEmpty(txtId.Text) || String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn chưa nhập sách nào");
            }
            else
            {
                pxk.id = int.Parse(txtId.Text.Trim().ToString());
                pxk.name = txtName.Text.ToString().Trim();
                pxk.count = int.Parse(numCount.Value.ToString());
                pnks.Add(pxk);
                dgvPNK.DataSource = pnks.ToList();
                txtId.Clear();
                txtName.Clear();
                numCount.Maximum = 0;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            foreach (VO.SACH_KHO pxk in pnks)
            {
                new PNK_BLL().insert(pxk.id, pxk.count, date);
            }
            MessageBox.Show("Phiếu xuất kho đã tạo xong");
            pnks.Clear();
            dgvPNK.DataSource = pnks.ToList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new Chitiet_Sach().ShowDialog();
            dataTable.Clear();
            dataTable = new BLL.Sach_BLL().getAll();
        }
    }
}
