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
    public partial class frmDH_QuanLi : Form
    {
        public frmDH_QuanLi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TacGia().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TheLoai().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmNXB().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new QL_Sach().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmNhanVien().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new frmQL_HoaDon().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frmQL_PNK().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new frmQL_PXK().ShowDialog();
        }
    }
}
