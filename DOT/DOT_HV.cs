using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    public class DOT_HV
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public int UserID { get; set; }

        public DOT_HV() { }

        public DOT_HV(string hoTen, DateTime ngaySinh, string gioiTinh, string soDienThoai, string email, int userID)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoDienThoai = soDienThoai;
            Email = email;
            UserID = userID;
        }
    }
}
    

