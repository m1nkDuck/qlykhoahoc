using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(
     @"Data Source=DESKTOP-GV5SVQ5\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True;TrustServerCertificate=True");
    }
}
