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
    }
}
