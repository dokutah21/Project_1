using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class DAL_ChiTietXuat
    {
        public static DataTable getData()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_GetAllChiTietXuat", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertChiTietHDX(Entity_ChiTietHDX ctx)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_InsertChiTietXuat", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDX", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MaSach", SqlDbType.VarChar, 50);
            command.Parameters.Add("@SoLuong", SqlDbType.Int);
            command.Parameters.Add("@DonGia", SqlDbType.Int);


            command.Parameters["@MaHDX"].Value = ctx.MaHDX1;
            command.Parameters["@MaSach"].Value = ctx.MaSach1;
            command.Parameters["@SoLuong"].Value = ctx.SoLuong1;
            command.Parameters["@DonGia"].Value = ctx.DonGia1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateChiTietHDX(Entity_ChiTietHDX ctx)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_UpdateChiTietXuat", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDX", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MaSach", SqlDbType.VarChar, 50);
            command.Parameters.Add("@SoLuong", SqlDbType.Int);
            command.Parameters.Add("@DonGia", SqlDbType.Int);


            command.Parameters["@MaHDX"].Value = ctx.MaHDX1;
            command.Parameters["@MaSach"].Value = ctx.MaSach1;
            command.Parameters["@SoLuong"].Value = ctx.SoLuong1;
            command.Parameters["@DonGia"].Value = ctx.DonGia1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteChiTietHDX(string mahdx)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_DeleteChiTietXuat", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDX", SqlDbType.VarChar, 10);

            command.Parameters["@MaHDX"].Value = mahdx;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
