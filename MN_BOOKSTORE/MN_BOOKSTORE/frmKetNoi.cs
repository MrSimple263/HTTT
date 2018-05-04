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

namespace MN_BOOKSTORE
{
    public partial class frmKetNoi : Form
    {
        public frmKetNoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DAL.datasource = txtserver.Text;
            DAL.DAL.userid = txtusername.Text;
            DAL.DAL.pass = txtpass.Text;
            try
            {
                new DAL.DAL();
                new frmLogin().ShowDialog();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
