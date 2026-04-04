using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAL
{
    public class DAL_Login : DBConnect
    {
        public DataTable DangNhap(string taiKhoan, string matKhau, string vaiTro)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string sql = "";

                if (vaiTro == "HocVien")
                {
                    sql = @"
                SELECT 
                    u.*,
                    hv.MaHV,
                    hv.HoTen,
                    hv.NgaySinh,
                    hv.GioiTinh,
                    hv.SDT,
                    hv.Email,
                    hv.DiaChi
                FROM [User] u
                INNER JOIN HocVien hv ON u.UserID = hv.[User]
                WHERE u.TaiKhoan = @TaiKhoan
                  AND u.Mk = @Mk
                  AND u.VaiTro = @VaiTro";
                }
                else if (vaiTro == "GiangVien")
                {
                    sql = @"
                SELECT *
                FROM [User]
                WHERE TaiKhoan = @TaiKhoan
                  AND Mk = @Mk
                  AND VaiTro = @VaiTro";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                cmd.Parameters.AddWithValue("@Mk", matKhau);
                cmd.Parameters.AddWithValue("@VaiTro", vaiTro);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
    }
}

