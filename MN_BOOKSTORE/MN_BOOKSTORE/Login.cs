using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MN_BOOKSTORE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int idsite = int.Parse(cbchinhanh.SelectedValue.ToString());
                DataTable site = new DICTON_BLL().selectid(idsite);
                foreach(DataRow row in site.Rows)
                {
                    DAL.DAL.datasource = row["IPADDRESS"].ToString();
                    DAL.DAL.userid = row["ACCOUNT"].ToString();
                    DAL.DAL.pass = row["PASS"].ToString();
                    DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
                }
                Login_BLL login = new Login_BLL();
                string mess = login.check(txtUserName.Text, txtPassWord.Text).Trim();
                Debug.Write("tin nhan"+ mess);
                if (mess.Equals(""))
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Kết quả",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công", "Kết quả",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (mess.Equals("2")) {
                        this.Hide();
                        new frmDH_NhanVien().ShowDialog();
                    }
                    else if (mess.Equals("1")){
                        this.Hide();
                        new frmDH_QuanLi().ShowDialog();
                    }
                    else if (mess.Equals("3")){
                        this.Hide();
                        new frmDH_ThuKho().ShowDialog();
                    }
                   
                }
            }catch(SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DataTable chinhanhs = new BLL.DICTON_BLL().selectall();
            cbchinhanh.DataSource = chinhanhs;
            cbchinhanh.DisplayMember = "NAME";
            cbchinhanh.ValueMember = "ID";
        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
