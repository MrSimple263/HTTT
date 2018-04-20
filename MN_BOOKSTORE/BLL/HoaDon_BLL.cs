using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    class HoaDon_BLL
    {
        DAL.DAL dAL = new DAL.DAL();
        public DataTable getAll()
        {
            string query = "hoadon_selectall";
            return dAL.excutedata(query, null, CommandType.StoredProcedure);
        }
        public void insert(SqlParameter[] sqlParameters,out string notify)
        {
            notify = "";
            string query = "hoadon_insert";
            dAL.excuteupdate(query, sqlParameters, CommandType.StoredProcedure,out notify);
        }
    }
}
