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
    public partial class update_Sach : Form
    {
        private string currentdatasource;
        private string currentuserid;
        private string currentpass;
        private string currentcatalog;
        public update_Sach()
        {
            InitializeComponent();
            currentdatasource = DAL.DAL.datasource;
            currentuserid = DAL.DAL.userid;
            currentpass = DAL.DAL.pass;
            currentcatalog = DAL.DAL.catalog;
        }

        private void update_Sach_Load(object sender, EventArgs e)
        {
            txtid.Text= QL_Sach.idsachchon.ToString();
            // load bang the loai
            BLL.TheLoai_BLL theLoai_BLL = new BLL.TheLoai_BLL();
            DataTable dttheloai = new DataTable();
            dttheloai = theLoai_BLL.getall();
            DataGridViewCheckBoxColumn checkbcl_theloai = new DataGridViewCheckBoxColumn();
            dgtheloai.DataSource = dttheloai;
            dgtheloai.Columns.Add(checkbcl_theloai);
            dgtheloai.AllowUserToAddRows = false;
            //thể loại đã chon
            DataTable dttheloaidachon = new BLL.Sach_BLL().theloai(QL_Sach.idsachchon);
            var listtheloai = from t in dttheloaidachon.AsEnumerable()
                              select t.Field<int>("theloai");
            foreach(int i in listtheloai)
            {
                foreach(DataGridViewRow row in dgtheloai.Rows)
                {
                    if (row.Cells[0].Value.ToString() == i.ToString())
                        row.Cells[2].Value = true;
                }
            }

            //load bang tac gia
            BLL.TacGia_BLL tacGia_BLL = new BLL.TacGia_BLL();
            DataTable dttacgia = new DataTable();
            dttacgia = tacGia_BLL.getall();
            dgtacgia.DataSource = dttacgia;
            DataGridViewCheckBoxColumn checkbcl_tacgia = new DataGridViewCheckBoxColumn();
            dgtacgia.Columns.Add(checkbcl_tacgia);
            dgtacgia.AllowUserToAddRows = false;
            //tac gia da chon
            DataTable dttacgiadachon = new BLL.Sach_BLL().tacgia(QL_Sach.idsachchon);
            var listtacgia = from t in dttacgiadachon.AsEnumerable()
                              select t.Field<int>("tacgia");
            foreach (int i in listtacgia)
            {
                foreach (DataGridViewRow row in dgtacgia.Rows)
                {
                    if (row.Cells[0].Value.ToString() == i.ToString())
                        row.Cells[3].Value = true;
                }
            }
            //load thông tin tac gia
            DataTable dtthongtinsach = new BLL.Sach_BLL().getID(QL_Sach.idsachchon);
            DataRow thongtinsach = dtthongtinsach.Rows[0];
            txtname.Text= thongtinsach.Field<string>("name");
            txtdongia.Text= thongtinsach.Field<float>("dongia").ToString();
            cbnxb.SelectedValue = thongtinsach.Field<int>("nxb");
            txtid.Text = QL_Sach.idsachchon.ToString();
            //load NXB vao combobox
            DataTable dtnxb = new BLL.NXB_BLL().getall();
            cbnxb.DataSource = dtnxb;
            cbnxb.ValueMember = "id";
            cbnxb.DisplayMember = "ten";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable sites = new BLL.DICTON_BLL().selectall();
            foreach (DataRow drow in sites.Rows)
            {
                DAL.DAL.datasource = drow["IPADDRESS"].ToString();
                DAL.DAL.userid = drow["ACCOUNT"].ToString();
                DAL.DAL.pass = drow["PASS"].ToString();
                DAL.DAL.catalog = drow["NAMEDATABASE"].ToString();
                //xóa thông tin tác giả cũ
                new BLL.Sach_Tacgia().dell(QL_Sach.idsachchon);
                //xóa thông tin thể loại đã chon
                new BLL.Sach_Theloai().delete(QL_Sach.idsachchon);
                //them lại thông tin tác giả
                List<int> tacgiasach = new List<int>();
                //dua id cac tac gia da chon vao danh sach
                foreach (DataGridViewRow row in dgtacgia.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[3];
                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        tacgiasach.Add(int.Parse(row.Cells[0].Value.ToString()));
                    }
                }
                //thêm lại thông tin thể loại
                List<int> theloaisach = new List<int>();
                //dua id the loai vao danh sach
                foreach (DataGridViewRow row in dgtheloai.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        theloaisach.Add(int.Parse(row.Cells[0].Value.ToString()));
                    }
                }
                //them  các tác giả của sách
                new BLL.Sach_Tacgia().insert(tacgiasach, QL_Sach.idsachchon);
                //them các thể loại của sách
                new BLL.Sach_Theloai().insert(theloaisach, QL_Sach.idsachchon);
                //update lại thông tin sách
                new BLL.Sach_BLL().update(QL_Sach.idsachchon, txtname.Text, int.Parse(cbnxb.SelectedValue.ToString()), float.Parse(txtdongia.Text));
            }

            DAL.DAL.datasource = currentdatasource;
            DAL.DAL.userid = currentuserid;
            DAL.DAL.pass = currentpass;
            DAL.DAL.catalog = currentcatalog;
        }
    }
}
