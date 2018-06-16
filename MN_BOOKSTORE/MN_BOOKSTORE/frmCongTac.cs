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
    public partial class frmCongTac : Form
    {
        private string currentdatasource;
        private string currentuserid;
        private string currentpass;
        private string currentcatalog;
        int id;
        string user;
        string pass;
        string hoten;
        string ngsinh;
        string sdt;
        int chucvu;
        DataTable chinhanhs;
        public frmCongTac(int id, string user, string pass, string hoten, 
            string ngsinh, string sdt, int chucvu)
        {
            InitializeComponent();
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.hoten = hoten;
            this.ngsinh = ngsinh;
            this.sdt = sdt;
            this.chucvu = chucvu;
            currentdatasource = DAL.DAL.datasource;
            currentuserid = DAL.DAL.userid;
            currentpass = DAL.DAL.pass;
            currentcatalog = DAL.DAL.catalog;
            chinhanhs = new BLL.DICTON_BLL().selectall();
            foreach (DataRow row in chinhanhs.Rows)
            {
                if (int.Parse(row["ID"].ToString()) == frmLogin.currentIdSite)
                {
                    chinhanhs.Rows.Remove(row);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                foreach (DataRow row in chinhanhs.Rows)
                {
                    if (row["ID"].ToString().Equals(cbchinhanh.SelectedValue.ToString()))
                    {
                        DAL.DAL.datasource = row["IPADDRESS"].ToString();
                        DAL.DAL.userid = row["ACCOUNT"].ToString();
                        DAL.DAL.pass = row["PASS"].ToString();
                        DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
                        new BLL.NhanVien_BLL().insert(user, pass, hoten, ngsinh, sdt, chucvu);
                        break;
                    }
                }
                DAL.DAL.datasource = currentdatasource;
                DAL.DAL.userid = currentuserid;
                DAL.DAL.pass = currentpass;
                DAL.DAL.catalog = currentcatalog;
                new BLL.NhanVien_BLL().delete(id);
                MessageBox.Show("Thành công!");
                this.Close();
            }
        }

        private void frmCongTac_Load(object sender, EventArgs e)
        {
            cbchinhanh.DataSource = chinhanhs;
            cbchinhanh.DisplayMember = "NAME";
            cbchinhanh.ValueMember = "ID";
        }
    }
}
