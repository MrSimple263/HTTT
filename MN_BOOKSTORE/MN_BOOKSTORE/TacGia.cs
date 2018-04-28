using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace MN_BOOKSTORE
{
    public partial class TacGia : Form
    {
        public TacGia()
        {
            InitializeComponent();
        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            DataTable dttacgia = new BLL.TacGia_BLL().getall();
            dgtacgia.DataSource = dttacgia;
        }

        private void dgtacgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgtacgia.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtten.Text = dgtacgia.Rows[e.RowIndex].Cells[1].Value.ToString();
            rtxtinfor.Text = dgtacgia.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            
            new BLL.TacGia_BLL().insert(txtten.Text, rtxtinfor.Text);
            TacGia_Load(sender, e);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            new BLL.TacGia_BLL().update(int.Parse(txtid.Text), txtten.Text, rtxtinfor.Text);
            TacGia_Load(sender, e);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            new BLL.TacGia_BLL().delete(int.Parse(txtid.Text));
            TacGia_Load(sender, e);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtten.Clear();
            rtxtinfor.Clear();
        }
    }
}
