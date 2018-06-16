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
    public partial class Frm_QuanliSite : Form
    {
        public Frm_QuanliSite()
        {
            InitializeComponent();
        }
        private void bnt_QuanliHoadon_Click(object sender, EventArgs e)
        {
            Site_QuanliHoadon f = new Site_QuanliHoadon();          
            f.ShowDialog();
        }

        private void bnt_QuanliPNK_Click(object sender, EventArgs e)
        {      
            Site_QuanliPNK f = new Site_QuanliPNK();
            f.ShowDialog();
        }

        private void bnt_PXK_Click(object sender, EventArgs e)
        {
            Site_QuanliPXK f = new Site_QuanliPXK();
            f.ShowDialog();
        }

        private void bnt_QuanliNhanvien_Click(object sender, EventArgs e)
        {
            Site_QuanliNhanvien f = new Site_QuanliNhanvien();
            f.ShowDialog();
        }
    }
}
