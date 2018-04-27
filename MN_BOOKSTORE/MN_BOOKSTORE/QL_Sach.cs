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
    public partial class QL_Sach : Form
    {
        DataTable dtsach;
        int currentrow=-1;
        
        public QL_Sach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chitiet_Sach chitiet_Sach = new Chitiet_Sach();
            chitiet_Sach.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dgsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentrow = e.RowIndex;
            btnxoa.Enabled=true;
            btnsua.Enabled = true;
            btnchitiet.Enabled = true;
        }

        private void QL_Sach_Load(object sender, EventArgs e)
        {
            load();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnchitiet.Enabled = false;
        }
        public void load()
        {
            dtsach = new DataTable();
            BLL.Sach_BLL sach_BLL = new BLL.Sach_BLL();
            dtsach = sach_BLL.getAll();
            dgsach.DataSource = dtsach;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            dgsach.Columns.Add(checkBoxColumn);
            dgsach.AllowUserToAddRows = false;
            dgsach.Rows[1].Cells[4].Value = true;
            
        }
    }
}
