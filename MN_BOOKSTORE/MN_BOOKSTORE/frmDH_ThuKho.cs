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
    public partial class frmDH_ThuKho : Form
    {
        public frmDH_ThuKho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmPNK().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmPXK().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmQLKHO().ShowDialog();
        }
    }
}
