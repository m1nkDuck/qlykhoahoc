using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL 
{
    public class BLL_Login
    {
        DAL_Login dalLogin = new DAL_Login();

        public DataTable DangNhap(string taiKhoan, string matKhau, string vaiTro)
        {
            return dalLogin.DangNhap(taiKhoan, matKhau, vaiTro);
        }
    }
}


