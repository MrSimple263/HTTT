using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BLL
{
    public class NXB_BLL
    {
        public DataTable getall()
        {
            string query = "nxb_selectall";
            return new DAL.DAL().excutedata(query, null, CommandType.StoredProcedure);
        }
        public void insert(string name, string infor)
        {
            string query = "nxb_insert";
            System.Data.SqlClient.SqlParameter[] sqlParameters =
            {
                new System.Data.SqlClient.SqlParameter("@ten",name),
                new System.Data.SqlClient.SqlParameter("@infor",infor)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
        public void update(int id, string name, string infor)
        {
            string query = "nxb_update";
            System.Data.SqlClient.SqlParameter[] sqlParameters =
           {
                new System.Data.SqlClient.SqlParameter("@ten",name),
                new System.Data.SqlClient.SqlParameter("@id",id),
                new System.Data.SqlClient.SqlParameter("@infor",infor)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
        public void delete(int id)
        {
            string query = "nxb_delete";
            System.Data.SqlClient.SqlParameter[] sqlParameters =
            {
                new System.Data.SqlClient.SqlParameter("@id",id)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
    }
}
