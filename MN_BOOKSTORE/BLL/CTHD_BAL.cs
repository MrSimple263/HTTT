using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
   
    class CTHD_BAL
    {
        DAL.DAL dAL = new DAL.DAL();
        public void insert(SqlParameter[] sqlParameters,out string notify)
        {
            notify = "";
            string query = "cthd_insert";
            dAL.excuteupdate(query, sqlParameters, CommandType.StoredProcedure, out notify);
        }
    }
}
