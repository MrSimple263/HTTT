using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
   
    public class CTHD_BLL
    {
        DAL.DAL dAL = new DAL.DAL();
        public void insert(int sach,float dongia,int hoadon,int soluong)
        {
            string query = "cthd_insert";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@sach",sach),
                new SqlParameter("@dongia",dongia),
                new SqlParameter("@hoadon",hoadon),
                new SqlParameter("@soluong",soluong)

            };
            dAL.excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
    }
}
