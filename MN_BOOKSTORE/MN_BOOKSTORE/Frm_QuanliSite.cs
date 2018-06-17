using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace MN_BOOKSTORE
{
    public partial class Frm_QuanliSite : Form
    {
        string datasource;
        string userid;
        string pass;
        string catalog;
        public Frm_QuanliSite()
        {
            InitializeComponent();
            DataTable site1 = new DICTON_BLL().selectid(1);
            foreach (DataRow row in site1.Rows)
            {
                datasource = row["IPADDRESS"].ToString();
                userid = row["ACCOUNT"].ToString();
                pass = row["PASS"].ToString();
                catalog = row["NAMEDATABASE"].ToString();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DAL.datasource = datasource;
            DAL.DAL.userid = userid;
            DAL.DAL.pass = pass;
            DAL.DAL.catalog = catalog;
            QL_Sach qL_Sach = new QL_Sach();
            qL_Sach.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL.DAL.datasource = datasource;
            DAL.DAL.userid = userid;
            DAL.DAL.pass = pass;
            DAL.DAL.catalog = catalog;
            TacGia frmtacgia = new TacGia();
            frmtacgia.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAL.DAL.datasource = datasource;
            DAL.DAL.userid = userid;
            DAL.DAL.pass = pass;
            DAL.DAL.catalog = catalog;
            TheLoai frmtheloai = new TheLoai();
            frmtheloai.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DAL.DAL.datasource = datasource;
            DAL.DAL.userid = userid;
            DAL.DAL.pass = pass;
            DAL.DAL.catalog = catalog;
            frmNXB frmNXB = new frmNXB();
            frmNXB.ShowDialog();
        }

        private void bnt_QuanliNhanvien_Click_1(object sender, EventArgs e)
        {
            Site_QuanliNhanvien f = new Site_QuanliNhanvien();
            f.ShowDialog();
        }
    }
}
