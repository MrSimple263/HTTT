using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MN_BOOKSTORE.DAO;
using System.Data.SqlClient;

namespace MN_BOOKSTORE
{
    public partial class TaoHoaDon : Form
    {
        DataSet dataSet = new DataSet();
        DataTable dtHoaDon = new DataTable("HOADON");
        Connection conn;
        SqlDataAdapter daHoadon;
        SACH sach = new SACH();
       
        public TaoHoaDon()
        {
            InitializeComponent();
        }

        private void TaoHoaDon_Load(object sender, EventArgs e) { 
            
         
           
            
        }

        private void cbmasach_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtmsp_TextChanged(object sender, EventArgs e)
        {
        List<SACH> sachs = sach.getall();
            int id=int.Parse(txtmsp.Text);

            txtdongia.Text=""+ sachs.FindIndex(s=>s.id.Equals(id));
                  MessageBox.Show()
        }
    }
}
