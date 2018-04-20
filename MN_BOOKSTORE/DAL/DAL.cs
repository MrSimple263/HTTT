using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace DAL
{
    public class DAL
    {
        SqlConnectionStringBuilder connectionStringBuilder;
        SqlConnection conn;
        public DAL()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = "MINH";
            connectionStringBuilder.InitialCatalog = "CUAHANGSACH";
            connectionStringBuilder.UserID = "minh";
            connectionStringBuilder.Password = "123";
            //tạo kết nối tới cơ sở dữ liệu
            conn = new SqlConnection(connectionStringBuilder.ToString());
        }
        //thực hiện query để trả về datatable
        public DataTable excutedata(string query,SqlParameter[] sqlParameters,CommandType commandType)
        {
           
            //
            SqlCommand sqlCommand = new SqlCommand(query,conn);
            //lấy param 
            foreach(SqlParameter param in sqlParameters)
            {
                sqlCommand.Parameters.Add(param);
            }
            DataTable myTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(myTable);
            return myTable;
        }
        //thực hiện updatedate dữ liệu inser/delete/update
        //thuộc tính notify là trả về thông báo thành công hoặc lỗi 
        public void excuteupdate(string query, SqlParameter[] sqlParameters,CommandType commandType,out string notify)
        {
            notify = "";
            conn.Open();
            SqlCommand cmdupdate = new SqlCommand(query, conn);
            foreach(SqlParameter param in sqlParameters)
            {
                cmdupdate.Parameters.Add(param);
            }
            try
            {
                cmdupdate.ExecuteNonQuery();
                notify = "cập nhật thành công";
            }
            catch (SqlException ex)
            {
                notify = ex.Message;
                Debug.Write(ex.ToString());
                
            }
            finally
            {
                conn.Close();
            }
        }
        //trả về giá trị đơn
        //notify trả về thông báo
        //nhớ kiểm tra null và ép kiểu khi xử lí
        public object excutescalar(string query, SqlParameter[] sqlParameters,CommandType commandType, out string notify)
        {
            notify = "";
            conn.Open();
            SqlCommand cmdupdate = new SqlCommand(query, conn);
            foreach (SqlParameter param in sqlParameters)
            {
                cmdupdate.Parameters.Add(param);
            }
            try
            {
                return cmdupdate.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                notify = ex.Message;
                Debug.Write(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}
