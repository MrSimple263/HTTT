using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BLL
{
    public class Sach_Tacgia
    {
        public void insert(List<int> list,int idsach)
        {
            string query = "sach_tacgia_insert";
            foreach (int i in list)
            {
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@idsach",idsach),
                    new SqlParameter("@idtacgia",i)
                };
                new DAL.DAL().excuteupdate(query, sqlParameters, System.Data.CommandType.StoredProcedure);
            }
        }
        public void dell(int idsach)
        {
            string query = "sach_theloai_dell";
            SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@idsach",idsach)
                };
            new DAL.DAL().excuteupdate(query, sqlParameters, System.Data.CommandType.StoredProcedure);
        }
    }
}
