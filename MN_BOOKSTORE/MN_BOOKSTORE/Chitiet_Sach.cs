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
    public partial class Chitiet_Sach : Form
    {
        public Chitiet_Sach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Chitiet_Sach_Load(object sender, EventArgs e)
        {
            // load bang the loai
            BLL.TheLoai_BLL theLoai_BLL= new BLL.TheLoai_BLL();
            DataTable dttheloai = new DataTable();
            dttheloai = theLoai_BLL.getall();
            DataGridViewCheckBoxColumn checkbcl_theloai = new DataGridViewCheckBoxColumn();
            dgtheloai.DataSource = dttheloai;
            dgtheloai.Columns.Add(checkbcl_theloai);
            dgtheloai.AllowUserToAddRows = false;

            //load bang tac gia
            BLL.TacGia_BLL tacGia_BLL = new BLL.TacGia_BLL();
            DataTable dttacgia = new DataTable();
            dttacgia = tacGia_BLL.getall();
            dgtacgia.DataSource = dttacgia;
            DataGridViewCheckBoxColumn checkbcl_tacgia = new DataGridViewCheckBoxColumn();
            dgtacgia.Columns.Add(checkbcl_tacgia);
            dgtacgia.AllowUserToAddRows = false;
            //load NXB vao combobox
            DataTable dtnxb=new BLL.NXB_BLL().getall();
            cbnxb.DataSource = dtnxb;
            cbnxb.ValueMember = "id";
            cbnxb.DisplayMember = "ten";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> tacgiasach = new List<int>();
            List<int> theloaisach = new List<int>();
            //dua id cac tac gia da chon vao danh sach
            foreach(DataGridViewRow row in dgtacgia.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[3];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    tacgiasach.Add(int.Parse(row.Cells[0].Value.ToString()));
                }
            }
            //dua id the loai vao danh sach
            foreach (DataGridViewRow row in dgtheloai.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    theloaisach.Add(int.Parse(row.Cells[0].Value.ToString()));
                }
            }
            //them thông tin sách vào database
            new BLL.Sach_BLL().insert(txtname.Text,int.Parse(cbnxb.SelectedValue.ToString()), float.Parse(txtdongia.Text));
            //Lay id sach vừa thêm
            int idsach=new BLL.Sach_BLL().getidmax();
            //them  các tác giả của sách
            new BLL.Sach_Tacgia().insert(tacgiasach,idsach);
            //them các thể loại của sách
            new BLL.Sach_Theloai().insert(theloaisach,idsach);
            MessageBox.Show("Đã thêm thành công");
            Chitiet_Sach_Load(sender, e);
        }
    }
}
