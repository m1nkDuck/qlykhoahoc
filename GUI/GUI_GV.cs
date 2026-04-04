using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_GV : Form
    {
        private Form frmLogin;
        public GUI_GV()
        {
            InitializeComponent();
        }
        public GUI_GV(Form login)
        {
            InitializeComponent();
            frmLogin = login;
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Bạn có chắc muốn đăng xuất không?",
       "Thông báo",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question );

            if (result == DialogResult.Yes)
            {
                if (frmLogin != null)
                    frmLogin.Show();
                else
                    new GUI_Login().Show();

                this.Close();
            }
        }
    }
}

