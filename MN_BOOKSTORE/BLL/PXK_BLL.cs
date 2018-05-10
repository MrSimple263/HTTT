using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PXK_BLL
    {
        DAL.DAL dAL = new DAL.DAL();
        public void insert(int sach, int soluong, string date)
        {
            string query = "pxk_insert";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@sach",sach),
                new SqlParameter("@soluong",soluong),
                new SqlParameter("@ngayxuat",date)
            };
            dAL.excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }

        public DataTable getAll()
        {
            string query = "pxk_selectall";
            return (new DAL.DAL().excutedata(query, null, CommandType.StoredProcedure));
        }

        public void delete(int id)
        {
            string query = "pxk_delete";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id",id)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
    }
}
