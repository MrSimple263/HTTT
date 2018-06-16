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
    public partial class TacGia : Form
    {
        private string currentdatasource;
        private string currentuserid;
        private string currentpass;
        private string currentcatalog;
        public TacGia()
        {
            InitializeComponent();
            currentdatasource = DAL.DAL.datasource;
            currentuserid = DAL.DAL.userid;
            currentpass = DAL.DAL.pass;
            currentcatalog = DAL.DAL.catalog;
        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            DataTable dttacgia = new BLL.TacGia_BLL().getall();
            dgtacgia.DataSource = dttacgia;
        }

        private void dgtacgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgtacgia.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtten.Text = dgtacgia.Rows[e.RowIndex].Cells[1].Value.ToString();
            rtxtinfor.Text = dgtacgia.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            DataTable sites = new BLL.DICTON_BLL().selectall();
            foreach (DataRow row in sites.Rows)
            {
                DAL.DAL.datasource = row["IPADDRESS"].ToString();
                DAL.DAL.userid = row["ACCOUNT"].ToString();
                DAL.DAL.pass = row["PASS"].ToString();
                DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
                new BLL.TacGia_BLL().insert(txtten.Text, rtxtinfor.Text);
                TacGia_Load(sender, e);
            }

            DAL.DAL.datasource = currentdatasource;
            DAL.DAL.userid = currentuserid;
            DAL.DAL.pass = currentpass;
            DAL.DAL.catalog = currentcatalog;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataTable sites = new BLL.DICTON_BLL().selectall();
            foreach (DataRow row in sites.Rows)
            {
                DAL.DAL.datasource = row["IPADDRESS"].ToString();
                DAL.DAL.userid = row["ACCOUNT"].ToString();
                DAL.DAL.pass = row["PASS"].ToString();
                DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
                new BLL.TacGia_BLL().update(int.Parse(txtid.Text), txtten.Text, rtxtinfor.Text);
                TacGia_Load(sender, e) ;
            }

            DAL.DAL.datasource = currentdatasource;
            DAL.DAL.userid = currentuserid;
            DAL.DAL.pass = currentpass;
            DAL.DAL.catalog = currentcatalog;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            new BLL.TacGia_BLL().delete(int.Parse(txtid.Text));
            TacGia_Load(sender, e);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtten.Clear();
            rtxtinfor.Clear();
        }
    }
}
