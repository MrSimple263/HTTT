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
    public partial class frmQLKHO : Form
    {
        DataTable dataTable;
        public frmQLKHO()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new frmThemSach().ShowDialog();
            dataTable.Clear();
            dataTable = new BLL.Sach_BLL().getAllWithCount();
            dgv.DataSource = dataTable;
        }

        private void frmQLKHO_Load(object sender, EventArgs e)
        {
            //load thông tin sách
            dataTable = new DataTable();
            dataTable = new BLL.Sach_BLL().getAllWithCount();
            dgv.DataSource = dataTable;

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv.CurrentCell.RowIndex;
            this.txtId.Text = dgv.Rows[r].Cells[0].Value.ToString();
            this.txtName.Text = dgv.Rows[r].Cells[1].Value.ToString();
            this.numMoney.Value = decimal.Parse(dgv.Rows[r].Cells[3].Value.ToString());
            var dsNXB = new NXB_BLL().getall();
            var ds = from c in dsNXB.AsEnumerable()
                     select new { item = c.Field<int>("id") + " " + c.Field<string>("ten") };
            foreach (var nxb in ds.ToList())
            {
                string item = nxb.item;
                cmbNXB.Items.Add(item);
            }
            cmbNXB.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            cmbNXB.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Bạn chưa chọn sách nào");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                new Sach_BLL().delete(id);
                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Bạn chưa chọn sách nào");
            }
            else
            {
                string nxb = "";
                foreach (char s in cmbNXB.Text.ToString())
                {
                    if (s != ' ')
                    {
                        nxb = nxb + s;
                    }
                    else
                    {
                        break;
                    }
                }
                int inxb = int.Parse(nxb.ToString());
                new Sach_BLL().update(int.Parse(txtId.Text), txtName.Text, inxb, float.Parse(numMoney.Value.ToString()));
                MessageBox.Show("Lưu thành công!!!");
                dataTable.Clear();
                dataTable = new BLL.Sach_BLL().getAllWithCount();
                dgv.DataSource = dataTable;
                txtId.Clear();
                txtName.Clear();
                cmbNXB.Items.Clear();
            }
        }
    }
}
