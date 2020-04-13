using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Yellow_Cab_Pizza.MVC_Model
{
    class xuly
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static string str = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLYellowCabPizza;Integrated Security=True";

        public static DataTable creatTable(string sql)
            //tạo bảng để load dữ liệu lên datagridview
        {
            con = new SqlConnection(str);
            con.Open();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public static int executeQuery(string sql)
        {
            //thực hiện câu truy vấn
            int re = 0;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                cmd = new SqlCommand(sql, con);
                re = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }
            return re;
        }
        public static int executeScalar(string sql)
        {
            int re = 0;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                cmd = new SqlCommand(sql, con);
                re = (Int32) cmd.ExecuteScalar();
                con.Close();
            }
            catch
            {

            }
            return re;
        }

    }
}
