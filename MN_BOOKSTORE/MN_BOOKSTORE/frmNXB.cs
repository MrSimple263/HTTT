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
    public partial class frmNXB : Form
    {
        public frmNXB()
        {
            InitializeComponent();
        }

        private void frmNXB_Load(object sender, EventArgs e)
        {
            DataTable dtnxb = new BLL.NXB_BLL().getall();
            dgnxb.DataSource = dtnxb;
        }

        private void dgnxb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgnxb.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtten.Text = dgnxb.Rows[e.RowIndex].Cells[1].Value.ToString();
            rtxtinfor.Text = dgnxb.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            new BLL.NXB_BLL().insert(txtten.Text, rtxtinfor.Text);
            frmNXB_Load(sender, e);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            new BLL.NXB_BLL().update(int.Parse(txtid.Text), txtten.Text, rtxtinfor.Text);
            frmNXB_Load(sender, e);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            new BLL.NXB_BLL().delete(int.Parse(txtid.Text));
            frmNXB_Load(sender, e);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtten.Clear();
            rtxtinfor.Clear();
        }
    }
}
