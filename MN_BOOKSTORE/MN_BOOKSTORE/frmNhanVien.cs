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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtnhanvien = new BLL.NhanVien_BLL().getall();
            DataTable dtrole = new BLL.Role_BLL().getall();
            cbchucvu.DataSource = dtrole;
            cbchucvu.DisplayMember = "name";
            cbchucvu.ValueMember = "id";
            dgnhanvien.DataSource = dtnhanvien;
            dgnhanvien.Columns[6].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BLL.NhanVien_BLL().insert(txtusername.Text, txtpass.Text,
                txthoten.Text, txtngaysinh.Text, txtsdt.Text, int.Parse(cbchucvu.SelectedValue.ToString()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BLL.NhanVien_BLL().update(txtusername.Text, txtpass.Text,
                txthoten.Text, txtngaysinh.Text, txtsdt.Text, int.Parse(cbchucvu.SelectedValue.ToString())
                ,int.Parse(txtid.Text));
            frmNhanVien_Load(sender, e);
        }

        private void dgnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentrow = e.RowIndex;
            txtid.Text = dgnhanvien.Rows[currentrow].Cells[0].Value.ToString();
            txtusername.Text = dgnhanvien.Rows[currentrow].Cells[1].Value.ToString();
            txtpass.Text = dgnhanvien.Rows[currentrow].Cells[2].Value.ToString();
            txthoten.Text= dgnhanvien.Rows[currentrow].Cells[3].Value.ToString();
            txtsdt.Text = dgnhanvien.Rows[currentrow].Cells[5].Value.ToString();
            txtngaysinh.Text = dgnhanvien.Rows[currentrow].Cells[4].Value.ToString();
            cbchucvu.SelectedValue= dgnhanvien.Rows[currentrow].Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }
    }
}
