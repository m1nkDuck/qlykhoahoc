using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DOT;

namespace BLL
{
    internal class BLL_DangKy
    {
        DAL_DangKy dal = new DAL_DangKy();

        public string DangKy(string taiKhoan, string matKhau, string xacNhanMatKhau,
                             string hoTen, DateTime ngaySinh, string gioiTinh,
                             string soDienThoai, string email)
        {
            if (string.IsNullOrWhiteSpace(taiKhoan) ||
                string.IsNullOrWhiteSpace(matKhau) ||
                string.IsNullOrWhiteSpace(xacNhanMatKhau) ||
                string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(soDienThoai) ||
                string.IsNullOrWhiteSpace(email))
            {
                return "Vui lòng nhập đầy đủ thông tin!";
            }

            if (matKhau != xacNhanMatKhau)
                return "Mật khẩu xác nhận không khớp!";

            if (dal.KiemTraTaiKhoanTonTai(taiKhoan))
                return "Tên đăng nhập đã tồn tại!";

            DOT_TaiKhoan tk = new DOT_TaiKhoan(taiKhoan, matKhau, "HocVien");
            int userID = dal.ThemTaiKhoan(tk);

            if (userID <= 0)
                return "Thêm tài khoản thất bại!";

            DOT_HV hv = new DOT_HV(hoTen, ngaySinh, gioiTinh, soDienThoai, email, userID);
            bool kq = dal.ThemHocVien(hv);

            if (!kq)
                return "Đăng ký tài khoản thành công nhưng thêm học viên thất bại!";

            return "Đăng ký thành công!";
        }
    }
}



    

