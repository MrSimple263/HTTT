using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Role_BLL
    {
        public DataTable getall()
        {
            string query = "select * from role";
            return new DAL.DAL().excutedata(query, null, CommandType.Text);
        }
    }
}
