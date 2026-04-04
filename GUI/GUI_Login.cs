using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class GUI_Login : Form
    {
        BLL_Login blLogin = new BLL_Login();

        public GUI_Login()
        {
            InitializeComponent();
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {
            chkShowPassword.Checked = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();
            string vaiTro = "";

            if (taiKhoan == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.");
                txtUsername.Focus();
                return;
            }

            if (matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                txtPassword.Focus();
                return;
            }

            if (rdoHocVien.Checked)
                vaiTro = "HocVien";
            else if (rdoGiangVien.Checked)
                vaiTro = "GiangVien";
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò.");
                return;
            }

            DataTable dt = blLogin.DangNhap(taiKhoan, matKhau, vaiTro);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công.");

                if (vaiTro == "HocVien")
                {
                    int maHV = Convert.ToInt32(dt.Rows[0]["MaHV"]);
                    GUI_HV frmHV = new GUI_HV(this, maHV);
                    frmHV.Show();
                    this.Hide();
                }
                else if (vaiTro == "GiangVien")
                {
                    GUI_GV frmGV = new GUI_GV(this);
                    frmGV.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập, mật khẩu hoặc vai trò.");
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUI_Register frm = new GUI_Register();
            frm.Show();
            this.Hide();
        }
    }
}


