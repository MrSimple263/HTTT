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
        public DataTable getAllWithCount()
        {
            string query = "sach_selectallwithcount";
            return (new DAL.DAL().excutedata(query, null, CommandType.StoredProcedure));
        }
        public int getidmax()
        {
            string query = "select max(id) from SACH";
            return (new DAL.DAL().excutescalar(query, null, CommandType.Text));
        }
        public DataTable theloai(int idsach)
        {
            string query = "theloaisach";
            SqlParameter[] sqlParameters= {
                new SqlParameter("@idsach",idsach)
            };
            return (new DAL.DAL().excutedata(query, sqlParameters, CommandType.StoredProcedure));
        }
        public void delete (int idsach)
        {
            string query = "sach_delete";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id",idsach)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
        public void insert (string name,int nxb,float dongia)
        {
            string query = "sach_insert";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@name",name),
                new SqlParameter("@dongia",dongia),
                new SqlParameter("@nxb",nxb)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
        public void update(int id, string name, int nxb, float dongia)
        {
            string query = "sach_update";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id",id),
                new SqlParameter("@name",name),
                new SqlParameter("@dongia",dongia),
                new SqlParameter("@nxb",nxb)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
    }
}
