using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL
{
    public class TacGia_BLL
    {
        public DataTable getall()
        {
            string query = "tacgia_selectall";
            return (new DAL.DAL().excutedata(query,null,CommandType.StoredProcedure));
        }
        public void insert(string name,string infor)
        {
            string query = "tacgia_insert";
            System.Data.SqlClient.SqlParameter[] sqlParameters =
            {
                new System.Data.SqlClient.SqlParameter("@hoten",name),
                new System.Data.SqlClient.SqlParameter("@infor",infor)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
        public void update(int id, string name,string infor)
        {
            string query = "tacgia_update";
            System.Data.SqlClient.SqlParameter[] sqlParameters =
           {
                new System.Data.SqlClient.SqlParameter("@hoten",name),
                new System.Data.SqlClient.SqlParameter("@id",id),
                new System.Data.SqlClient.SqlParameter("@infor",infor)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
        public void delete(int id)
        {
            string query = "tacgia_delete";
            System.Data.SqlClient.SqlParameter[] sqlParameters =
            {
                new System.Data.SqlClient.SqlParameter("@id",id)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
    }
}
