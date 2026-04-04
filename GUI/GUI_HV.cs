using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GUI
{
    public partial class GUI_HV : Form
    {
        private Form frmLogin;
        private int maHocVien;
        private string connectionString = @"Data Source=DESKTOP-GV5SVQ5\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True;TrustServerCertificate=True";

        public GUI_HV()
        {
            InitializeComponent();
            LoadLichHoc();
            LoadLichThi();

        }

        public GUI_HV(Form login, int maHV)
        {
            InitializeComponent();
            frmLogin = login;
            maHocVien = maHV;
            LoadThongTinHocVien();
            LoadLichHoc();
            LoadLichThi();
            


        }

        private void GUI_HV_Load(object sender, EventArgs e)
        {
        }

        private void LoadLichHoc()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            MaLichHoc,
                            MaLopHoc,
                            NgayHoc,
                            GioBatDau,
                            GioKetThuc,
                            PhongHoc,
                            MaGV,
                            ThoiLuongHoc,
                            GhiChu
                        FROM LichHoc";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLichHoc.AutoGenerateColumns = true;
                    dgvLichHoc.ColumnHeadersVisible = true;
                    dgvLichHoc.RowHeadersVisible = true;
                    dgvLichHoc.DataSource = null;
                    dgvLichHoc.Columns.Clear();
                    dgvLichHoc.DataSource = dt;
                    dgvLichHoc.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load lịch học: " + ex.Message);
            }
        }

        private void LoadLichThi()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            MaLichThi,
                            MaLop,
                            NgayThi,
                            GioBatDau,
                            GioKetThuc,
                            PhongThi,
                            MaGV,
                            HinhThucThi,
                            GhiChu
                        FROM LichThi";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLichThi.AutoGenerateColumns = true;
                    dgvLichThi.ColumnHeadersVisible = true;
                    dgvLichThi.RowHeadersVisible = true;
                    dgvLichThi.DataSource = null;
                    dgvLichThi.Columns.Clear();
                    dgvLichThi.DataSource = dt;
                    dgvLichThi.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load lịch thi: " + ex.Message);
            }
        }

        private void GUI_HV_Load_1(object sender, EventArgs e)
        {
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                if (frmLogin != null)
                {
                    frmLogin.Show();
                }
                else
                {
                    GUI_Login login = new GUI_Login();
                    login.Show();
                }

                this.Close();
            }
        }
        private void LoadThongTinHocVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    MaHV,
                    HoTen,
                    GioiTinh,
                    NgaySinh,
                    DiaChi,
                    SDT,
                    Email
                FROM HocVien
                WHERE MaHV = @MaHV";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHV", maHocVien);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        valMaHV.Text = reader["MaHV"].ToString();
                        valTen.Text = reader["HoTen"].ToString();

                        string gioiTinh = reader["GioiTinh"].ToString();
                        if (gioiTinh == "1")
                            valGioiTinh.Text = "Nam";
                        else if (gioiTinh == "0")
                            valGioiTinh.Text = "Nữ";
                        else
                            valGioiTinh.Text = gioiTinh;

                        if (reader["NgaySinh"] != DBNull.Value)
                            valNgaySinh.Text = Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy");
                        else
                            valNgaySinh.Text = "";

                        valdiachi.Text = reader["DiaChi"].ToString();
                        valSDT.Text = reader["SDT"].ToString();
                        valEmail.Text = reader["Email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy học viên có mã: " + maHocVien);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin học viên: " + ex.Message);
            }
        }
        private void gbxThongTin_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }
    }
}









