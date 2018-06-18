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
            MessageBox.Show("Thêm thành công!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BLL.NhanVien_BLL().update(txtusername.Text, txtpass.Text,
                txthoten.Text, txtngaysinh.Text, txtsdt.Text, 
                int.Parse(cbchucvu.SelectedValue.ToString())
                ,int.Parse(txtid.Text));
            frmNhanVien_Load(sender, e);
            MessageBox.Show("Cập nhật thành công!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtid.Text);
                new BLL.NhanVien_BLL().delete(id);
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtid.Text);
                new frmCongTac(id, txtusername.Text, txtpass.Text,
                txthoten.Text, txtngaysinh.Text, txtsdt.Text,
                int.Parse(cbchucvu.SelectedValue.ToString())).ShowDialog();
                //load lai du lieu
                DataTable dtnhanvien = new BLL.NhanVien_BLL().getall();
                DataTable dtrole = new BLL.Role_BLL().getall();
                cbchucvu.DataSource = dtrole;
                cbchucvu.DisplayMember = "name";
                cbchucvu.ValueMember = "id";
                dgnhanvien.DataSource = dtnhanvien;
                dgnhanvien.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
        }

        private void dgnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentrow = e.RowIndex;
            txtid.Text = dgnhanvien.Rows[currentrow].Cells[0].Value.ToString();
            txtusername.Text = dgnhanvien.Rows[currentrow].Cells[1].Value.ToString();
            txtpass.Text = dgnhanvien.Rows[currentrow].Cells[2].Value.ToString();
            txthoten.Text = dgnhanvien.Rows[currentrow].Cells[3].Value.ToString();
            txtsdt.Text = dgnhanvien.Rows[currentrow].Cells[5].Value.ToString();
            txtngaysinh.Text = dgnhanvien.Rows[currentrow].Cells[4].Value.ToString();
            cbchucvu.SelectedValue = dgnhanvien.Rows[currentrow].Cells[6].Value.ToString();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            DataTable dtnhanvien = new BLL.NhanVien_BLL().getall();
            string ten = txt.Text.Trim();
            if (ten.Length == 0)
            {
                dgnhanvien.DataSource = dtnhanvien;
                dgnhanvien.Columns[6].Visible = false;
            }
            else
            {
                DataView datafilter = new DataView(dtnhanvien);
                datafilter.RowFilter = "hoten Like '%" + ten + "%'";
                dgnhanvien.DataSource = datafilter;
            }
        }
    }
}
