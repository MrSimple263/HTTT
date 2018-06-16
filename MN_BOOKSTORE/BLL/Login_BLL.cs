using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Login_BLL
    {
        DAL.DAL dal = new DAL.DAL();
        public string check(string username, string password)
        {
            string query = "select dbo.fn_Login('"+username+"', '"+password+"')";
            return dal.excutescalar2(query, null, CommandType.Text);
        }
        
    }
}
