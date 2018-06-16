using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;
using System.Data;
namespace BLL
{
    public class DICTON_BLL
    {
        public DataTable selectall()
        {
            string query = "select * from SITE";
            return new DAL.DAL_DD().excutedata(query, null, CommandType.Text);
        }
        public DataTable selectid(int id)
        {
            string query = "select * from SITE where ID="+id+"";
            return new DAL.DAL_DD().excutedata(query, null, CommandType.Text);
        }
        public string checkTRUNGTAM(string username, string password)
        {
            string query = "select dbo.login_check('" + username + "','" + password + "')";
            return new DAL.DAL_DD().excutescalar2(query, null, CommandType.Text);
        }
    }
}
