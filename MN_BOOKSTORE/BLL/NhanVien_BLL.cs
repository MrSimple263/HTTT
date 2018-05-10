using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BLL
{
    public class NhanVien_BLL
    {
        public DataTable getall()
        {
            string query = "nhanvien_selectall";
            return new DAL.DAL().excutedata(query, null, System.Data.CommandType.StoredProcedure);
        }
        public void insert(string username,string pass,string hoten,string ngaysinh,
            string sdt,int role)
        {
            string query = "nhanvien_insert";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@username",username),
                new SqlParameter("@pass",pass),
                new SqlParameter("hoten",hoten),
                new SqlParameter("@ngaysinh",ngaysinh),
                new SqlParameter("@sdt",sdt),
                new SqlParameter("@role",role)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, System.Data.CommandType.StoredProcedure);
        }
        public void update(string username, string pass, string hoten, string ngaysinh,
            string sdt, int role,int id)
        {
            string query = "nhanvien_update";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@username",username),
                new SqlParameter("@pass",pass),
                new SqlParameter("@hoten",hoten),
                new SqlParameter("@ngaysinh",ngaysinh),
                new SqlParameter("@sdt",sdt),
                new SqlParameter("@role",role),
                new SqlParameter("@id",id)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, System.Data.CommandType.StoredProcedure);
        }
        public void delete(int idnhanvien)
        {
            string query = "nhanvien_delete";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@id",idnhanvien)
            };
            new DAL.DAL().excuteupdate(query, sqlParameters, System.Data.CommandType.StoredProcedure);
        }
    }
}
