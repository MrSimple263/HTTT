using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Kho_BLL
    {
        DAL.DAL dAL = new DAL.DAL();
        public int kiemkho(int idsach)
        {
            string query = "select dbo.kho_kiemkho("+idsach+")";
            return dAL.excutescalar(query, null, System.Data.CommandType.Text);
        }
    }
}
