using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    public class DOT_TaiKhoan
    {
        public string TaiKhoan { get; set; }
        public string Mk { get; set; }
        public string VaiTro { get; set; }

        public DOT_TaiKhoan() { }

        public DOT_TaiKhoan(string taiKhoan, string mk, string vaiTro)
        {
            TaiKhoan = taiKhoan;
            Mk = mk;
            VaiTro = vaiTro;
        }
    }
}

