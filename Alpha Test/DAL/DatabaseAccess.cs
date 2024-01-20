using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlConnectionData
    {
        //Tạo chuỗi kết nối CSDL

        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=NHNAM-HYN\SQLEXPRESS01;Initial Catalog=QuanLySach;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); //khởi tạo connect
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLoginEntity(TaiKhoan taikhoan)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect(); //connect to csdl
            conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.sTaiKhoan);
            command.Parameters.AddWithValue(@"pass", taikhoan.sMatKhau);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }

            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }

            return user;
        }
    }

}
