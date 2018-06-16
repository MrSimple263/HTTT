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
    public class DAL
    {
        SqlConnectionStringBuilder connectionStringBuilder;
        SqlConnection conn;
        public static string datasource;
        public static string userid;
        public static string pass;
        public static string catalog;
        public DAL()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource =datasource;
            connectionStringBuilder.InitialCatalog =catalog;
            connectionStringBuilder.UserID = userid;
            connectionStringBuilder.Password = pass;
            //tạo kết nối tới cơ sở dữ liệu
            conn = new SqlConnection(connectionStringBuilder.ToString());
            conn.Open();
            conn.Close();
        }
        public DAL(string datasource,string userid,string pass,string catalog)
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = datasource;
            connectionStringBuilder.InitialCatalog = catalog;
            connectionStringBuilder.UserID = userid;
            connectionStringBuilder.Password = pass;
            //tạo kết nối tới cơ sở dữ liệu
            conn = new SqlConnection(connectionStringBuilder.ToString());
            conn.Open();
            conn.Close();
        }
        //thực hiện query để trả về datatable
        public DataTable excutedata(string query,SqlParameter[] sqlParameters,CommandType commandType)
        {
           
            //
            SqlCommand sqlCommand = new SqlCommand(query,conn);
            sqlCommand.CommandType = commandType;
            //lấy param 
            if (sqlParameters!=null)
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
        public void excuteupdate(string query, SqlParameter[] sqlParameters,CommandType commandType)
        {
            conn.Open();
            SqlCommand cmdupdate = new SqlCommand(query, conn);
            cmdupdate.CommandType = commandType;
            foreach(SqlParameter param in sqlParameters)
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
        //trả về giá trị đơn
        public int excutescalar(string query, SqlParameter[] sqlParameters,CommandType commandType)
        {
            conn.Open();
            SqlCommand cmdupdate = new SqlCommand(query, conn);
            if (sqlParameters != null)
            {
                foreach (SqlParameter param in sqlParameters)
                {
                    cmdupdate.Parameters.Add(param);
                }
            }
           try
                {
                Debug.Write(cmdupdate.ExecuteScalar());
                    if (cmdupdate.ExecuteScalar() != null)
                         {
                            return int.Parse(cmdupdate.ExecuteScalar().ToString());
                         } 
                }
            catch (SqlException ex)
                {
                    Debug.Write(ex.ToString());
                }
            finally
                {
                    conn.Close();
                }
        
            return -1;
        }
        //trả về đơn giá trị 2
        public string excutescalar2(string query, SqlParameter[] sqlParameters, CommandType commandType)
        {
            conn.Open();
            SqlCommand cmdupdate = new SqlCommand(query, conn);
            if (sqlParameters != null)
            {
                foreach (SqlParameter param in sqlParameters)
                {
                    cmdupdate.Parameters.Add(param);
                }
            }
            try
            {
                Debug.Write(cmdupdate.ExecuteScalar());
                if (cmdupdate.ExecuteScalar() != null)
                {
                    return cmdupdate.ExecuteScalar().ToString();
                }
            }
            catch (SqlException ex)
            {
                Debug.Write(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return "";
        }
    }
}
