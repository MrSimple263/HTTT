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
    public partial class KiemKho : Form
    {
        public KiemKho()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtidsach.Text))
            {
                MessageBox.Show("Bạn chưa nhập gì cả");
            }
            else
            {
                BLL.Kho_BLL kho = new BLL.Kho_BLL();
                sl.Text = "" + kho.kiemkho(int.Parse(txtidsach.Text));
            }
        }

        private void KiemKho_Load(object sender, EventArgs e)
        {

        }
    }
}
