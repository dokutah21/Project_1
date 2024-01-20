using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class DAL_ChiTietNhap
    {
        public static DataTable getData()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_GetAllChiTietNhap", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertChiTietHDN(Entity_ChiTietHDN ctn)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_InsertChiTietNhap", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDN", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MaSach", SqlDbType.VarChar, 50);
            command.Parameters.Add("@SoLuong", SqlDbType.Int);
            command.Parameters.Add("@DonGia", SqlDbType.Int);


            command.Parameters["@MaHDN"].Value = ctn.MaHDN1;
            command.Parameters["@MaSach"].Value = ctn.MaSach1;
            command.Parameters["@SoLuong"].Value = ctn.SoLuong1;
            command.Parameters["@DonGia"].Value = ctn.DonGia1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateChiTietHDN(Entity_ChiTietHDN ctn)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_UpdateChiTietNhap", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDN", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MaSach", SqlDbType.VarChar, 50);
            command.Parameters.Add("@SoLuong", SqlDbType.Int);
            command.Parameters.Add("@DonGia", SqlDbType.Int);


            command.Parameters["@MaHDN"].Value = ctn.MaHDN1;
            command.Parameters["@MaSach"].Value = ctn.MaSach1;
            command.Parameters["@SoLuong"].Value = ctn.SoLuong1;
            command.Parameters["@DonGia"].Value = ctn.DonGia1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteChiTietHDN(string mahdn)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_DeleteChiTietNhap", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDN", SqlDbType.VarChar, 10);

            command.Parameters["@MaHDN"].Value = mahdn;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
