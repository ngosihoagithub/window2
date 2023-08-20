using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DAL
{
    public class DBConnection
    {
        public DBConnection()
        {

        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=NGOSIHOA\SQLEXPRESS; Initial Catalog = QLST; User Id = sa; Password=sa";
            return conn;
        }
    }
}
