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
    public partial class Site_QuanliPNK : Form
    {
        public Site_QuanliPNK()
        {
            InitializeComponent();
        }

        private void Site_QuanliPNK_Load(object sender, EventArgs e)
        {
            DataTable chinhanhs = new BLL.DICTON_BLL().selectall();
            cbx_chinhanh.DataSource = chinhanhs;
            cbx_chinhanh.DisplayMember = "NAME";
            cbx_chinhanh.ValueMember = "ID";
        }

        private void cbx_chinhanh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idsite = int.Parse(cbx_chinhanh.SelectedValue.ToString());
            DataTable site = new DICTON_BLL().selectid(idsite);
            foreach (DataRow row in site.Rows)
            {
                DAL.DAL.datasource = row["IPADDRESS"].ToString();
                DAL.DAL.userid = row["ACCOUNT"].ToString();
                DAL.DAL.pass = row["PASS"].ToString();
                DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
            }
            PNK_BLL pnk = new PNK_BLL();
            dgv_PNK.DataSource = pnk.getAll();
        }
    }
}
