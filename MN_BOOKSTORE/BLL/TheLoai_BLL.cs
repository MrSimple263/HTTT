using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class TheLoai_BLL
    {
        public DataTable getall()
        {
            string query = "theloai_selectall";
            return (new DAL.DAL().excutedata(query, null, CommandType.StoredProcedure));
        }
        public void insert(string name)
        {
            string query = "theloai_insert";
            System.Data.SqlClient.SqlParameter[] sqlParameters =
            {
                new System.Data.SqlClient.SqlParameter("@ten",name)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
        public void update(int id,string name)
        {
            string query = "theloai_update";
            System.Data.SqlClient.SqlParameter[] sqlParameters =
           {
                new System.Data.SqlClient.SqlParameter("@ten",name),
                new System.Data.SqlClient.SqlParameter("@id",id)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
        public void delete(int id)
        {
            string query = "theloai_delete";
            System.Data.SqlClient.SqlParameter[] sqlParameters =
            {
                new System.Data.SqlClient.SqlParameter("@id",id)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
    }
}
