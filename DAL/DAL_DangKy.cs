using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT;

namespace DAL
{
    public class DAL_DangKy
    {
        private string connectionString = @"Data Source=DESKTOP-GV5SVQ5\SQLEXPRESS;Initial Catalog=TenCSDL;Integrated Security=True";

        public bool KiemTraTaiKhoanTonTai(string taiKhoan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public int ThemTaiKhoan(DOT_TaiKhoan tk)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    INSERT INTO TaiKhoan(TaiKhoan, Mk, VaiTro)
                    VALUES(@TaiKhoan, @Mk, @VaiTro);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TaiKhoan", tk.TaiKhoan);
                cmd.Parameters.AddWithValue("@Mk", tk.Mk);
                cmd.Parameters.AddWithValue("@VaiTro", tk.VaiTro);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        public bool ThemHocVien(DOT_HV hv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    INSERT INTO HocVien(HoTen, NgaySinh, GioiTinh, SoDienThoai, Email, UserID)
                    VALUES(@HoTen, @NgaySinh, @GioiTinh, @SoDienThoai, @Email, @UserID)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HoTen", hv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", hv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", hv.GioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", hv.SoDienThoai);
                cmd.Parameters.AddWithValue("@Email", hv.Email);
                cmd.Parameters.AddWithValue("@UserID", hv.UserID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
    }
};
    

