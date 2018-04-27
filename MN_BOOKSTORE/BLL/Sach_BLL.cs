using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Sach_BLL
    {
        public DataTable getAll()
        {
            string query = "sach_selectall";
            return (new DAL.DAL().excutedata(query,null, CommandType.StoredProcedure));
        }
        public DataTable theloai(int idsach)
        {
            string query = "theloaisach";
            SqlParameter[] sqlParameters= {
                new SqlParameter("@idsach",idsach)
            };
            return (new DAL.DAL().excutedata(query, sqlParameters, CommandType.StoredProcedure));
        }
    }
}
