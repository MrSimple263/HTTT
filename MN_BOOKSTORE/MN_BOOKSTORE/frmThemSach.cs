using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace MN_BOOKSTORE
{
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {
            var dsNXB = new NXB_BLL().getall();
            var ds = from c in dsNXB.AsEnumerable()
                     select new { item = c.Field<int>("id") + " " + c.Field<string>("ten") };
            foreach (var nxb in ds.ToList()) {
                string item = nxb.item;
                cmbNXB.Items.Add(item);
            }
            cmbNXB.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            numMoney.Value = 0;
            cmbNXB.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn chưa nhập sách nào");
            }
            else
            {
                string nxb = "";
                foreach (char s in cmbNXB.Text.ToString())
                {
                    if (s != ' ')
                    {
                        nxb = nxb + s;
                    }
                    else
                    {
                        break;
                    }
                }
                int inxb = int.Parse(nxb.ToString());
                new Sach_BLL().insert(txtName.Text, inxb, float.Parse(numMoney.Value.ToString()));
                MessageBox.Show("Thêm thành công!!!");
            }
        }
    }
}
