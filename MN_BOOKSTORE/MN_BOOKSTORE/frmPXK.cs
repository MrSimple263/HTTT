using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace MN_BOOKSTORE
{
    public partial class frmPXK : Form
    {
        List<VO.SACH_KHO> pxks;
        DataTable dataTable;
        public frmPXK()
        {
            InitializeComponent();
        }

        private void frmPXK_Load(object sender, EventArgs e)
        {
            //load thông tin sách
            dataTable = new DataTable();
            dataTable = new BLL.Sach_BLL().getAll();
            pxks = new List<VO.SACH_KHO>();
            dgvPXK.DataSource = pxks;
            txtId.Focus();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            //
            if (!String.IsNullOrEmpty(txtId.Text.ToString()))
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
                        //kiểm tra sách trong kho còn không
                        BLL.Kho_BLL kho_BLL = new BLL.Kho_BLL();
                        int count = kho_BLL.kiemkho(msp);
                        if (count != 0)
                        {
                            txtName.Text = s.First().name.ToString();
                            numCount.Maximum = count;
                        }
                        else
                        {
                            MessageBox.Show("Hết hàng!!!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        txtName.Clear();
                        numCount.Maximum = 0;
                    }
                }
                catch (Exception ex)
                {
                    txtName.Clear();
                    numCount.Maximum = 0;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPXK.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvPXK.SelectedRows[0].Cells[0].Value.ToString());
                pxks.Remove(pxks.Where(s => s.id == id).First());
                dgvPXK.DataSource = pxks.ToList();
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
                pxks.Add(pxk);
                dgvPXK.DataSource = pxks.ToList();
                txtId.Clear();
                txtName.Clear();
                numCount.Maximum = 0;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");


            foreach (VO.SACH_KHO pxk in pxks)
            {
                   new PXK_BLL().insert(pxk.id, pxk.count, date);
            }
            MessageBox.Show("Phiếu xuất kho đã tạo xong");
            pxks.Clear();
            dgvPXK.DataSource = pxks.ToList();
        }
    }
}