using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class GUI_Register : Form
    {
        public GUI_Register()
        {
            InitializeComponent();
        }

        private void GUI_Register_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;

            rdoNam.Checked = true;
            dtpNgaySinh.MaxDate = DateTime.Now;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();
            string xacNhanMatKhau = txtConfirmPass.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            bool gioiTinh = rdoNam.Checked;
            string diaChi = textBox1.Text.Trim();
            string soDienThoai = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();

            string ketQua = DangKyTaiKhoan(
                taiKhoan,
                matKhau,
                xacNhanMatKhau,
                hoTen,
                ngaySinh,
                gioiTinh,
                soDienThoai,
                email,
                diaChi
            );

            MessageBox.Show(ketQua);

            if (ketQua == "Đăng ký thành công!")
            {
                GUI_Login frmLogin = new GUI_Login();
                frmLogin.Show();
                this.Hide();
            }
        }

        private string DangKyTaiKhoan(
            string taiKhoan,
            string matKhau,
            string xacNhanMatKhau,
            string hoTen,
            DateTime ngaySinh,
            bool gioiTinh,
            string soDienThoai,
            string email,
            string diaChi)
        {
            if (string.IsNullOrWhiteSpace(taiKhoan))
                return "Vui lòng nhập tài khoản.";

            if (string.IsNullOrWhiteSpace(matKhau))
                return "Vui lòng nhập mật khẩu.";

            if (string.IsNullOrWhiteSpace(xacNhanMatKhau))
                return "Vui lòng nhập xác nhận mật khẩu.";

            if (string.IsNullOrWhiteSpace(hoTen))
                return "Vui lòng nhập họ tên.";

            if (string.IsNullOrWhiteSpace(diaChi))
                return "Vui lòng nhập địa chỉ.";

            if (string.IsNullOrWhiteSpace(soDienThoai))
                return "Vui lòng nhập số điện thoại.";

            if (string.IsNullOrWhiteSpace(email))
                return "Vui lòng nhập email.";

            if (matKhau != xacNhanMatKhau)
                return "Mật khẩu xác nhận không khớp.";

            if (!Regex.IsMatch(soDienThoai, @"^\d{10,11}$"))
                return "Số điện thoại không hợp lệ.";

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Email không hợp lệ.";

            string connectionString = @"Data Source=DESKTOP-GV5SVQ5\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlTransaction tran = conn.BeginTransaction();

                    try
                    {
                        // 1. Kiểm tra tài khoản đã tồn tại chưa
                        string checkUserQuery = @"
                            SELECT COUNT(*)
                            FROM [User]
                            WHERE TaiKhoan = @TaiKhoan";

                        using (SqlCommand cmdCheck = new SqlCommand(checkUserQuery, conn, tran))
                        {
                            cmdCheck.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                            int count = (int)cmdCheck.ExecuteScalar();
                            if (count > 0)
                            {
                                tran.Rollback();
                                return "Tài khoản đã tồn tại.";
                            }
                        }

                        // 2. Insert vào bảng User và lấy UserID mới
                        string insertUserQuery = @"
                            INSERT INTO [User] (TaiKhoan, Mk, VaiTro)
                            VALUES (@TaiKhoan, @Mk, @VaiTro);

                            SELECT SCOPE_IDENTITY();";

                        int newUserId;

                        using (SqlCommand cmdInsertUser = new SqlCommand(insertUserQuery, conn, tran))
                        {
                            cmdInsertUser.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                            cmdInsertUser.Parameters.AddWithValue("@Mk", matKhau);
                            cmdInsertUser.Parameters.AddWithValue("@VaiTro", "HocVien");

                            object result = cmdInsertUser.ExecuteScalar();
                            newUserId = Convert.ToInt32(result);
                        }

                        // 3. Insert vào bảng HocVien
                        string insertHocVienQuery = @"
                            INSERT INTO HocVien (HoTen, NgaySinh, GioiTinh, SDT, Email, DiaChi, [User])
                            VALUES (@HoTen, @NgaySinh, @GioiTinh, @SDT, @Email, @DiaChi, @UserID)";

                        using (SqlCommand cmdInsertHV = new SqlCommand(insertHocVienQuery, conn, tran))
                        {
                            cmdInsertHV.Parameters.AddWithValue("@HoTen", hoTen);
                            cmdInsertHV.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                            cmdInsertHV.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                            cmdInsertHV.Parameters.AddWithValue("@SDT", soDienThoai);
                            cmdInsertHV.Parameters.AddWithValue("@Email", email);
                            cmdInsertHV.Parameters.AddWithValue("@DiaChi", diaChi);
                            cmdInsertHV.Parameters.AddWithValue("@UserID", newUserId);

                            cmdInsertHV.ExecuteNonQuery();
                        }

                        tran.Commit();
                        return "Đăng ký thành công!";
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        return "Lỗi SQL: " + ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối CSDL: " + ex.Message;
            }
        }

        private void lnkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_Login frmLogin = new GUI_Login();
            frmLogin.Show();
            this.Hide();
        }
    }
}