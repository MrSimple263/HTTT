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
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgtheloai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgtheloai.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text= dgtheloai.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnupdate.Enabled = true;
            btndel.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtid.Clear();
            btnupdate.Enabled = false;
            btndel.Enabled = false;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            new BLL.TheLoai_BLL().insert(txtname.Text);
            load();
           
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            new BLL.TheLoai_BLL().update(int.Parse(txtid.Text),txtname.Text);
            load();
        }

        public void load()
        {
            DataTable dtthloai = new BLL.TheLoai_BLL().getall();
            dgtheloai.DataSource = dtthloai;
            btnupdate.Enabled = false;
            btndel.Enabled = false;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            new BLL.TheLoai_BLL().delete(int.Parse(txtid.Text));
            btnclear_Click(sender, e);
            load();
        }
    }
}
