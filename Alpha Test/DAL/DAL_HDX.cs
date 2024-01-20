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
    public class DAL_HDX
    {
        public static DataTable getData()
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_GetAllHoaDonXuat", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertHDX(Entity_HDX hdx)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_InsertHoaDonXuat", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDX", SqlDbType.VarChar, 10);
            command.Parameters.Add("@NgayXuat", SqlDbType.Date);
            command.Parameters.Add("@NgayNhan", SqlDbType.Date);
            command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MaKho", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TongTien", SqlDbType.Int);


            command.Parameters["@MaHDX"].Value = hdx.MaHDX1;
            command.Parameters["@NgayXuat"].Value = hdx.NgayXuat1;
            command.Parameters["@NgayNhan"].Value = hdx.NgayNhan1;
            command.Parameters["@MaNV"].Value = hdx.MaNV1;
            command.Parameters["@MaKho"].Value = hdx.MaKho1;
            command.Parameters["@TrangThai"].Value = hdx.TrangThai1;
            command.Parameters["@TongTien"].Value = hdx.TongTien1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateHDX(Entity_HDX hdx)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_UpdateHoaDonXuat", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDX", SqlDbType.VarChar, 10);
            command.Parameters.Add("@NgayXuat", SqlDbType.Date);
            command.Parameters.Add("@NgayNhan", SqlDbType.Date);
            command.Parameters.Add("@MaNV", SqlDbType.VarChar, 10);
            command.Parameters.Add("@MaKho", SqlDbType.VarChar, 10);
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TongTien", SqlDbType.Int);


            command.Parameters["@MaHDX"].Value = hdx.MaHDX1;
            command.Parameters["@NgayXuat"].Value = hdx.NgayXuat1;
            command.Parameters["@NgayNhan"].Value = hdx.NgayNhan1;
            command.Parameters["@MaNV"].Value = hdx.MaNV1;
            command.Parameters["@MaKho"].Value = hdx.MaKho1;
            command.Parameters["@TrangThai"].Value = hdx.TrangThai1;
            command.Parameters["@TongTien"].Value = hdx.TongTien1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteHDX(string mahdx)
        {
            SqlConnection Conn = SqlConnectionData.Connect();
            SqlCommand command = new SqlCommand("sp_DeleteHoaDonXuat", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaHDX", SqlDbType.VarChar, 10);

            command.Parameters["@MaHDX"].Value = mahdx;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
