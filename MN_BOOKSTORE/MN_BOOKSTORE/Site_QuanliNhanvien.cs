using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
namespace MN_BOOKSTORE
{
    public partial class Site_QuanliNhanvien : Form
    {
        DataTable hn = new DataTable();
        DataTable hcm = new DataTable();
        public Site_QuanliNhanvien()
        {
            InitializeComponent();
        }
        private void Site_QuanliNhanvien_Load(object sender, EventArgs e)
        {
            
            DataTable site1 = new DICTON_BLL().selectid(2);
            foreach (DataRow row in site1.Rows)
            {
                DAL.DAL.datasource = row["IPADDRESS"].ToString();
                DAL.DAL.userid = row["ACCOUNT"].ToString();
                DAL.DAL.pass = row["PASS"].ToString();
                DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
            }
            NhanVien_BLL nhanvienhn = new NhanVien_BLL();
            hn = nhanvienhn.getall();
            DataTable site2 = new DICTON_BLL().selectid(1);
            foreach (DataRow row in site2.Rows)
            {
                DAL.DAL.datasource = row["IPADDRESS"].ToString();
                DAL.DAL.userid = row["ACCOUNT"].ToString();
                DAL.DAL.pass = row["PASS"].ToString();
                DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
            }
            NhanVien_BLL nhanvienhcm = new NhanVien_BLL();
            hcm = nhanvienhcm.getall();
            DataTable dtall = new DataTable();
            dtall = hcm.Copy();
            dtall.Merge(hn);
            dgv_Nhanvien.DataSource = dtall;
        }
    }
}
