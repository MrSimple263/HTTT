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
using System.Diagnostics;
namespace MN_BOOKSTORE
{
    public partial class Site_QuanliNhanvien : Form
    {
        DataTable hn = new DataTable();
        DataTable hcm = new DataTable();
        public Site_QuanliNhanvien()
        {
            InitializeComponent();
        }
        private void Site_QuanliNhanvien_Load(object sender, EventArgs e)
        {
            DataTable nhanviens = new DataTable();
            //thiet dặt combobox
            DataTable chinhanhs = new DICTON_BLL().selectall();
            DataRow rowtoancuc = chinhanhs.NewRow();
            rowtoancuc["ID"] = 0;
            rowtoancuc["NAME"] = "Tất cả";
            chinhanhs.Rows.InsertAt(rowtoancuc, 0);
            cb_chinhanh.DataSource = chinhanhs;
            cb_chinhanh.DisplayMember = "NAME";
            cb_chinhanh.ValueMember = "ID";

            //load toan bô nhân viên
            foreach(DataRow row in chinhanhs.Rows)
            {
                if(!row["ID"].ToString().Equals("0"))
                {
                    DAL.DAL.datasource = row["IPADDRESS"].ToString();
                    DAL.DAL.userid = row["ACCOUNT"].ToString();
                    DAL.DAL.pass = row["PASS"].ToString();
                    DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
                    NhanVien_BLL nhanvien = new NhanVien_BLL();
                    DataTable dataTable = nhanvien.getall();
                    nhanviens.Merge(dataTable);
                }
                
            }
            dgv_Nhanvien.DataSource = nhanviens;
            /*
        DataTable site1 = new DICTON_BLL().selectid(2);
        foreach (DataRow row in site1.Rows)
        {
            DAL.DAL.datasource = row["IPADDRESS"].ToString();
            DAL.DAL.userid = row["ACCOUNT"].ToString();
            DAL.DAL.pass = row["PASS"].ToString();
            DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
        }
        NhanVien_BLL nhanvienhn = new NhanVien_BLL();
        hn = nhanvienhn.getall();
        DataTable site2 = new DICTON_BLL().selectid(1);
        foreach (DataRow row in site2.Rows)
        {
            DAL.DAL.datasource = row["IPADDRESS"].ToString();
            DAL.DAL.userid = row["ACCOUNT"].ToString();
            DAL.DAL.pass = row["PASS"].ToString();
            DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
        }
        NhanVien_BLL nhanvienhcm = new NhanVien_BLL();
        hcm = nhanvienhcm.getall();
        DataTable dtall = new DataTable();
        dtall = hcm.Copy();
        dtall.Merge(hn);
        dgv_Nhanvien.DataSource = dtall;
        */
        }

        private void dgv_Nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentrow = e.RowIndex;
            txtid.Text = dgv_Nhanvien.Rows[currentrow].Cells[0].Value.ToString();
            txtusername.Text = dgv_Nhanvien.Rows[currentrow].Cells[1].Value.ToString();
            txtpass.Text = dgv_Nhanvien.Rows[currentrow].Cells[2].Value.ToString();
            txthoten.Text = dgv_Nhanvien.Rows[currentrow].Cells[3].Value.ToString();
            txtsdt.Text = dgv_Nhanvien.Rows[currentrow].Cells[5].Value.ToString();
            txtngaysinh.Text = dgv_Nhanvien.Rows[currentrow].Cells[4].Value.ToString();
            cbchucvu.SelectedValue = dgv_Nhanvien.Rows[currentrow].Cells[6].Value.ToString();
        }

        private void cb_chinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_chinhanh_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable nhanviens = new DataTable();
            if (cb_chinhanh.SelectedValue.ToString().Equals("0"))
            {
                DataTable chinhanhs = new DICTON_BLL().selectall();
                foreach (DataRow row in chinhanhs.Rows)
                {
                    if (!row["ID"].ToString().Equals("0"))
                    {
                        DAL.DAL.datasource = row["IPADDRESS"].ToString();
                        DAL.DAL.userid = row["ACCOUNT"].ToString();
                        DAL.DAL.pass = row["PASS"].ToString();
                        DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
                        NhanVien_BLL nhanvien = new NhanVien_BLL();
                        DataTable dataTable = nhanvien.getall();
                        nhanviens.Merge(dataTable);
                    }

                }
                dgv_Nhanvien.DataSource = nhanviens;
            }
            else
            {
                if (cb_chinhanh.SelectedValue.ToString()!= "System.Data.DataRowView")
                {
                    DataTable chinhanhs = new DICTON_BLL().selectid(int.Parse(cb_chinhanh.SelectedValue.ToString()));
                    foreach (DataRow row in chinhanhs.Rows)
                    {
                        DAL.DAL.datasource = row["IPADDRESS"].ToString();
                        DAL.DAL.userid = row["ACCOUNT"].ToString();
                        DAL.DAL.pass = row["PASS"].ToString();
                        DAL.DAL.catalog = row["NAMEDATABASE"].ToString();
                        NhanVien_BLL nhanvien = new NhanVien_BLL();
                        nhanviens = nhanvien.getall();
                    }
                    dgv_Nhanvien.DataSource = nhanviens;

                }

            }
        }
    }
}
