﻿using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                Login_BLL login = new Login_BLL();
                string mess = login.check(txtUserName.Text, txtPassWord.Text).Trim();
                if (mess.Equals(""))
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Kết quả",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công", "Kết quả",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (mess.Equals("NHAN VIEN")) {
                        //
                    }
                    else if (mess.Equals("QUAN LY")){
                        //
                    }
                    else if (mess.Equals("THU KHO")){
                        //
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
    }
}
