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
        public update_Sach()
        {
            InitializeComponent();
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
            var listtacgia = from t in dttheloaidachon.AsEnumerable()
                              select t.Field<int>("theloai");
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
      
    }
}
