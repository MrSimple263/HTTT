using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PNK_BLL
    {
        DAL.DAL dAL = new DAL.DAL();
        public void insert(int sach, int soluong, string date)
        {
            string query = "pnk_insert";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@sach",sach),
                new SqlParameter("@soluong",soluong),
                new SqlParameter("@ngaynhap",date)
            };
            dAL.excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
    }
}
