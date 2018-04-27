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
    public partial class TaoHoaDon : Form
    {
        List<VO.SACH_KHMUA> sachs;
        DataTable dataTable;
        float s = 0;
        public TaoHoaDon()
        {
            InitializeComponent();
        }

        private void TaoHoaDon_Load(object sender, EventArgs e) {
            //load thông tin sách
            dataTable = new DataTable();
            dataTable = new BLL.Sach_BLL().getAll();
            sachs = new List<VO.SACH_KHMUA>();
            dghoadon.DataSource = sachs;
            sl.DataSource = new int[]{ 1,2,3,4,5};
            
        }

        private void txtmsp_TextChanged(object sender, EventArgs e)
        {
            //xử lí sự kiện khi mã id thay đổi
            if (!String.IsNullOrEmpty(txtmsp.Text.ToString())){
                int msp = int.Parse(txtmsp.Text.ToString());
                //lấy tên và đơn giá sản phẩm theo id
                var s = from c in dataTable.AsEnumerable()
                        where c.Field<int>("id") == msp
                        select new { name = c.Field<string>("name"), dongia = c.Field<float>("dongia") };
                if (s.Count()!=0)
                {
                    txttensach.Text = s.First().name.ToString();
                    txtdongia.Text = s.First().dongia.ToString();
                    txttongtien.Text = (int.Parse(sl.SelectedItem.ToString()) * float.Parse(txtdongia.Text)).ToString();
                }else
                {
                    txttensach.Clear();
                    txtdongia.Clear();
                    txttongtien.Clear();
                }
            }   
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //thêm một sách mà khách hàng mua
            VO.SACH_KHMUA sach = new VO.SACH_KHMUA();
            if (String.IsNullOrEmpty(txtmsp.Text) || String.IsNullOrEmpty(txttensach.Text))
            {
                MessageBox.Show("Bạn chưa nhập sách nào");
            }
            else
            {
                sach.id = int.Parse(txtmsp.Text.ToString().Trim());
                sach.name = txttensach.Text;
                sach.soluong = int.Parse(sl.SelectedItem.ToString());
                sach.dongia = float.Parse(txtdongia.Text);
                sachs.Add(sach);
                dghoadon.DataSource = sachs.ToList();
                s=s+float.Parse(txttongtien.Text);
                tongtien.Text = s.ToString();
            }
        }

        private void sl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtdongia.Text))
            txttongtien.Text = (int.Parse(sl.SelectedItem.ToString()) * float.Parse(txtdongia.Text)).ToString();
        }

        //Tạo hóa đơn và chi tiết hóa đơn lưu vào CSDL
        private void button2_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            float ttien = s;
            new HoaDon_BLL().insert(date,ttien);
            int idhoadon = new HoaDon_BLL().getMax();
            //tạo chi tiết hóa đơn
            foreach(VO.SACH_KHMUA sach in sachs)
            {
                new CTHD_BLL().insert(sach.id, sach.dongia, idhoadon, sach.soluong);
            }
        }

        //xóa một SÁCH trong hóa đơn
        private void button5_Click(object sender, EventArgs e)
        {
            if (dghoadon.SelectedRows.Count > 0)
            {
                int id=int.Parse(dghoadon.SelectedRows[0].Cells[0].Value.ToString());
                sachs.Remove(sachs.Where(index => index.id == id).First());
                VO.SACH_KHMUA sach_xoa = sachs.Where(s => s.id == id).First();
                s = s - (sach_xoa.soluong * sach_xoa.dongia);
                tongtien.Text =""+ s;
                dghoadon.DataSource = sachs.ToList();
            }
            else
            {
                MessageBox.Show("Hãy chọn một hàng để xóa");
            }
           
        }

        //đưa frm tạo hóa đơn về với mặc định
        private void clear_Click(object sender, EventArgs e)
        {
            sachs.Clear();
            dghoadon.DataSource = sachs.ToList();
            txtdongia.Clear();
            txtmsp.Clear();
            txttensach.Clear();
            txttongtien.Clear();
        }
    }
}
