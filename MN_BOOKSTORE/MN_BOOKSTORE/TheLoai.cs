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
        private string currentdatasource;
        private string currentuserid;
        private string currentpass;
        private string currentcatalog;
        public TheLoai()
        {
            InitializeComponent();
            currentdatasource = DAL.DAL.datasource;
            currentuserid = DAL.DAL.userid;
            currentpass = DAL.DAL.pass;
            currentcatalog = DAL.DAL.catalog;
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
            DataTable sites = new BLL.DICTON_BLL().selectall();
            foreach (DataRow row in sites.Rows)
            {
                DAL.DAL.datasource = row["IPADDRESS"].ToString();
                DAL.DAL.userid = row["ACCOUNT"].ToString();
                DAL.DAL.pass = row["PASS"].ToString();
                DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
                new BLL.TheLoai_BLL().insert(txtname.Text);
                load();
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
                new BLL.TheLoai_BLL().update(int.Parse(txtid.Text), txtname.Text);
                load();
            }

            DAL.DAL.datasource = currentdatasource;
            DAL.DAL.userid = currentuserid;
            DAL.DAL.pass = currentpass;
            DAL.DAL.catalog = currentcatalog;
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
