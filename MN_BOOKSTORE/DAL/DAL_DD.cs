using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;


namespace DAL
{
    public class DAL_DD
    {
        SqlConnectionStringBuilder connectionStringBuilder;
        SqlConnection conn;
        public DAL_DD()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = "den1.mssql1.gear.host";
            connectionStringBuilder.InitialCatalog = "datadictionary";
            connectionStringBuilder.UserID = "datadictionary";
            connectionStringBuilder.Password = "Va7iG!1O1JU?";
            //tạo kết nối tới cơ sở dữ liệu
            conn = new SqlConnection(connectionStringBuilder.ToString());
            conn.Open();
            conn.Close();
        }
        public DataTable excutedata(string query, SqlParameter[] sqlParameters, CommandType commandType)
        {

            //
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.CommandType = commandType;
            //lấy param 
            if (sqlParameters != null)
            {
                foreach (SqlParameter param in sqlParameters)
                {
                    sqlCommand.Parameters.Add(param);
                }
            }
            DataTable myTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(myTable);
            return myTable;
        }
        //thực hiện updatedate dữ liệu inser/delete/update
        public void excuteupdate(string query, SqlParameter[] sqlParameters, CommandType commandType)
        {
            conn.Open();
            SqlCommand cmdupdate = new SqlCommand(query, conn);
            cmdupdate.CommandType = commandType;
            foreach (SqlParameter param in sqlParameters)
            {
                cmdupdate.Parameters.Add(param);
            }
            try
            {
                cmdupdate.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Debug.Write(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
