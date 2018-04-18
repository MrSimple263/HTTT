using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace MN_BOOKSTORE.DAO
{
    class Connection
    {
        SqlConnection sqlConnection;
        SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
        public Connection()
        {

            sqlConnectionStringBuilder.DataSource = "MINH";
            sqlConnectionStringBuilder.InitialCatalog = "CUAHANGSACH";
            sqlConnectionStringBuilder.UserID = "minh";
            sqlConnectionStringBuilder.Password = "123";
            sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ToString());
            try
            {
                sqlConnection.Open();
                Debug.Write("kết nối thành công");

            }
            catch (SqlException ex)
            {
                Debug.Write(ex.Message);
            }

        }
    }
}
