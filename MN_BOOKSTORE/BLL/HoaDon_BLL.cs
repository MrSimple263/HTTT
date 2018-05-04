using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class HoaDon_BLL
    {
        DAL.DAL dAL = new DAL.DAL();
        public DataTable getAll()
        {
            string query = "hoadon_selectall";
            return dAL.excutedata(query, null, CommandType.StoredProcedure);
        }
        public int getMax()
        {
            string query = "select max(id) from HOADON";
            return dAL.excutescalar(query, null, CommandType.Text);
         }
        public void insert(string date,float tongtien)
        {
        
            string query = "hoadon_insert";
            SqlParameter[] sqlParameters= {
                new SqlParameter("@ngaylap", date),
                new SqlParameter("@tongtien", tongtien)
            };
            dAL.excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
        
        public void delete(int id)
        {
            string query = "hoadon_delete";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@id", id)
            };
            dAL.excuteupdate(query, sqlParameters, CommandType.StoredProcedure);
        }
    }
}
